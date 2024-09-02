using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;
using System.Text;
using UnityEngine;
using TEngine;
using UnityEditor.VersionControl;

public enum LockMsgStatus
{
    Unlock,     // 解除独占
    Lock,       // 独占
    TimeOut,    // 超时解除独占
}

public class LockMsgInfo
{
    System.Type _msgType;
    System.Type _resMsgType;
    float _lockTime;

    public LockMsgInfo(System.Type msgType, float lockTime, System.Type resMsgType)
    {
        _msgType = msgType;
        _lockTime = lockTime;
        _resMsgType = resMsgType;
    }

    public System.Type MsgType
    {
        get { return _msgType; }
    }

    public System.Type ResMsgType
    {
        get { return _resMsgType; }
    }

    public float LockTime
    {
        get { return _lockTime; }
    }
}

public class UnityNetWork : Module
{
    const float PROTOCAL_PROCESS_INTERVAL = 0.2f;
    const int LOCK_TIME = 10;

    #region Event
    public event Action OnConnectedEvent;
    public event Action<bool> OnNetDropedEvent;
    public event Action<LockMsgStatus> OnLockMsgStatusChangeEvent;
    public event Action<LockMsgInfo> OnLockMsgTimeOutEvent;
    #endregion

    public float keepAliveIdle = 10f;
    public float keepAliveWait = 5f;
    public string encryptionKey = "bleach";

    TcpConnect _tcpConnection = null;
    Protocol _protocol = null;

    // TimerEvent _timer;

    bool _isRunning = false;
    bool _isConnected = false;
    bool _isNetDroped = false;

    List<Message> _failedToSendMessageList = new List<Message>();

    int _receivedMsgCount = 0;

    int _isNewMsgReceived;
    float _lastReceivedTime;
    float _keepAliveSendTime;

    ReqKeepAliveMessage _reqKeepAliveMsg = new ReqKeepAliveMessage();

    Dictionary<System.Type, LockMsgInfo> _lockMsgDic = new Dictionary<Type, LockMsgInfo>();
    LockMsgInfo _curLockMsgInfo;    // 当前独占消息
    LockMsgStatus _curLockStatus;   // 独占消息状态
    float _lockMsgOverTime;         // 独占消息超时时间

    /// <summary>
    /// 接收消息总数
    /// </summary>
    public int ReceivedMessageCount
    {
        get { return _receivedMsgCount; }
    }

    public LockMsgInfo CurLockMsgInfo
    {
        get { return _curLockMsgInfo; }
    }

    public LockMsgStatus LockStatus
    {
        get { return _curLockStatus; }
        private set
        {
            if (_curLockStatus == value)
                return;
            _curLockStatus = value;

            Debug.Log(string.Format("~~~Message {0} lock state changed {1}, {2}!~~~", _curLockMsgInfo.MsgType, _curLockStatus, Time.realtimeSinceStartup));

            if (OnLockMsgStatusChangeEvent != null)
                OnLockMsgStatusChangeEvent(_curLockStatus);
        }
    }

    bool IsNewMsgReceived
    {
        get { return _isNewMsgReceived != 0; }
        set
        {
            Interlocked.Exchange(ref _isNewMsgReceived, (value ? 1 : 0));
        }
    }

    public int FailedToSendMessageCount
    {
        get { return _failedToSendMessageList.Count; }
    }

    public Protocol Protocol
    {
        get
        {
            return _protocol;
        }
    }

    public TcpConnect TcpConnection
    {
        get { return _tcpConnection; }
    }


    public NetState CurNetState
    {
        get
        {
            return _tcpConnection.CurNetState;
        }
    }

    protected void Start()
    {
        _protocol = new Protocol();
        _tcpConnection = new TcpConnect();
        _tcpConnection.EncryptionKey = Encoding.UTF8.GetBytes(encryptionKey);
        _tcpConnection.ReceiveMsgEvent += ReceiveProtocol;
        _protocol.OnReceiveMsgEvent += OnReceiveMsg;

        // _timer = TimerEventMgr.Instance.Add(0, Tick, 0, PROTOCAL_PROCESS_INTERVAL);

        var id = GameModule.Timer.AddTimer(Tick, 1, true);
        GameModule.Timer.Restart(id);

        InitLockMsg();
    }

    protected void OnDestroy()
    {
        _tcpConnection.ReceiveMsgEvent -= ReceiveProtocol;
        _protocol.OnReceiveMsgEvent -= OnReceiveMsg;
    }

    #region Network thread

    // Network thread
    void ReceiveProtocol(Stream msgStream)
    {
        IsNewMsgReceived = true;
        _protocol.ReceiveProtocol(msgStream);
    }

    #endregion Network thread

    void Tick(object[] objects)
    {
        //  CheckLockMsgTimeout();

        _protocol.ProcessProtocol(); // 确保断线时先处理消息

        if (CurNetState != NetState.Connected)
        {
            if (CurNetState == NetState.Droped)
            {
                OnNetDroped();
            }
            return;
        }

        if (!_isConnected)
        {
            _isConnected = true;
            _isNetDroped = false;   // 清除断线标志

            if (OnConnectedEvent != null)
                OnConnectedEvent();
        }

        CheckTcpConnection();
    }

    /// <summary>
    /// 定时发送 keep alive 消息，超时未收到回复则表示Tcp连接已经异常断开
    /// </summary>
    void CheckTcpConnection()
    {
        var isReceived = IsNewMsgReceived;
        if (isReceived)
        {
            _lastReceivedTime = Time.unscaledTime;
        }

        var curTime = Time.unscaledTime;

        if (_keepAliveSendTime != 0)
        {
            if (isReceived)  // reset
            {
                _keepAliveSendTime = 0;
            }
            else
            {
                if (curTime - _keepAliveSendTime > keepAliveWait) // Timeout
                {
                    _tcpConnection.TcpKeepAliveTimeout();
                    _keepAliveSendTime = 0;
                }
            }
        }
        else
        {
            if (curTime - _lastReceivedTime > keepAliveIdle) // 超过空闲等待时间
            {
                _keepAliveSendTime = curTime;
                SendMessage(_reqKeepAliveMsg);
                Debug.Log("Send keep alive msg: " + curTime);
            }
        }

        if (isReceived)
        {
            IsNewMsgReceived = false;
        }
    }

    /// <summary>
    /// Start network
    /// </summary>
    public void StartNetWork(string _ipAddress, int _port)
    {
        if (_isRunning)
            return;
        _isRunning = true;
        _isConnected = false;
        _tcpConnection.StartConnect(_ipAddress, _port);

        _receivedMsgCount = 0;

        _keepAliveSendTime = 0;
        IsNewMsgReceived = false;
        _lastReceivedTime = Time.unscaledTime;
    }

    public void StopNetWork()
    {
        if (!_isRunning)
            return;
        _isRunning = false;

        _isConnected = false;
        _tcpConnection.CloseConnect();

        // clear 
        _protocol.Clear();

        // 关闭网络连接时，如果有独占消息，确保触发独占消息超时事件
        if (LockStatus == LockMsgStatus.Lock)
        {
            if (OnLockMsgTimeOutEvent != null)
            {
                OnLockMsgTimeOutEvent(_curLockMsgInfo);
            }

            LockStatus = LockMsgStatus.Unlock;
            _curLockMsgInfo = null;
        }
    }

    /// <summary>
    /// 重发未发送消息
    /// </summary>
    public void ResendFailedToSendMessage()
    {
        if (_failedToSendMessageList.Count != 0)
        {
            Debug.LogFormat("Resend failed to send message!: {0} ", Time.unscaledTime);
        }

        for (var i = 0; i < _failedToSendMessageList.Count; ++i)
        {
            _tcpConnection.SendMessage(_failedToSendMessageList[i], false);
        }
        _failedToSendMessageList.Clear();
    }

    /// <summary>
    /// 清除未发送消息
    /// </summary>
    public void ClearFailedToSendMessage()
    {
        if (_failedToSendMessageList.Count != 0)
        {
            Debug.LogFormat("Clear failed to send message!: {0}", Time.unscaledTime);
        }

        _failedToSendMessageList.Clear();
    }

    void AddFailedToSendMessage(Message msg)
    {
        Debug.LogWarningFormat("Failed to send msg {0}, invalid network state: {1}.", msg.ToString(), CurNetState);
        _failedToSendMessageList.Add(msg);
    }

    public void SendMessage(Message msg, bool enableEncryption = false)
    {
        if (CurNetState == NetState.Droped) // Handle net drop.
        {
            OnNetDroped(msg);
            return;
        }

        if (_isNetDroped)                   // 断线中，加入未发送消息列表中
        {
            AddFailedToSendMessage(msg);    // TODO: 处理消息加密
            return;
        }

        var msgType = msg.GetType();

        if (CurNetState != NetState.Connected)
        {
            Debug.LogWarningFormat("Send message {0} failed, tcp not connected!", msgType);
            return;
        }

        var lockMsgInfo = GetLockMsgInfo(msgType);
        if (lockMsgInfo != null)
        {
            if (LockStatus == LockMsgStatus.Lock)
            {
                Debug.LogWarningFormat("Network is in lock mode {0}, skip msg {1}.", _curLockMsgInfo.MsgType, lockMsgInfo.MsgType);
                return;
            }

            SetLockStatus(lockMsgInfo);
        }

        _tcpConnection.SendMessage(msg, enableEncryption);

        if (CurNetState == NetState.Droped)
        {
            OnNetDroped(msg);
        }
    }

    void OnNetDroped(Message failedToSendMsg)
    {
        AddFailedToSendMessage(failedToSendMsg);
        OnNetDroped();
    }

    void OnNetDroped()
    {
        _isNetDroped = true;

        Debug.LogWarningFormat("Net droped, failed to send message count {0}", FailedToSendMessageCount);

        if (OnNetDropedEvent != null)
            OnNetDropedEvent(FailedToSendMessageCount > 0);
    }

    //提前注册处理接收到的消息
    public Message SetMessage<T>(Action<Message> action) where T : Message, new()
    {
        var mes = new T();
        Protocol.SetMessage(mes.GetId(), mes);
        GameEvent.AddEventListener(mes.GetId(), action);
        return mes;
    }


    // 初始化需要独占的消息信息
    void InitLockMsg()
    {
        // 角色系统
        RegistLockMsg(typeof(ReqUnLockCharacterMessage), LOCK_TIME, typeof(ResUnLockCharacterMessage));
        RegistLockMsg(typeof(ReqCharacterStageUpMessage), LOCK_TIME, typeof(ResCharacterStageUpMessage));

        // 浦原，竞技场，灵魂，番队商店
        RegistLockMsg(typeof(ReqShopRefreshMessage), LOCK_TIME, typeof(ResShopInfoMessage));
        RegistLockMsg(typeof(ReqShopBuyMessage), LOCK_TIME, typeof(ResShopBuyMessage));

        // 女性死神协会
        RegistLockMsg(typeof(ReqGirlGetGirlMessage), LOCK_TIME, typeof(ResGirlSingleInfoMessage));
        RegistLockMsg(typeof(ReqGirlDateMessage), LOCK_TIME, typeof(ResGirlDateMessage));
        RegistLockMsg(typeof(ReqGirlEnableSuitMessage), LOCK_TIME, typeof(ResGirlSingleInfoMessage));
        RegistLockMsg(typeof(ReqFastDateGirlMessage), LOCK_TIME, typeof(ResFastDateGirlMessage));

        // 成就
        RegistLockMsg(typeof(ReqAchievementRewardMessage), LOCK_TIME, typeof(ResAchievementRewardMessage));
        // 日常
        RegistLockMsg(typeof(ReqDailyMissionRewardMessage), LOCK_TIME, typeof(ResDailyMissionRewardMessage));

        // 温泉
        RegistLockMsg(typeof(ReqEnterSpringMessage), LOCK_TIME, typeof(ResEnterSpringMessage));

        //灵魂试炼
        RegistLockMsg(typeof(ReqStartSoulTrialMessage), LOCK_TIME, typeof(ResStartSoulTrialMessage));
        RegistLockMsg(typeof(ReqRewardSoulTrialMessage), LOCK_TIME, typeof(ResRewardResultMessage));
        RegistLockMsg(typeof(ReqRestartSoulTrialMessage), LOCK_TIME, typeof(ResSoulTrialInfoMessage));
        RegistLockMsg(typeof(ReqMopSoulTrialMessage), LOCK_TIME, typeof(ResMopSoulTrialMessage));
        RegistLockMsg(typeof(ReqGetSoulTrialOppenentMessage), LOCK_TIME, typeof(ResSoulTrialOppenentMessage));

        //宿命对决
        RegistLockMsg(typeof(ReqDestinyFightMessage), LOCK_TIME, typeof(ResDestinyFightMessage));
        RegistLockMsg(typeof(ReqDestinyRefreshMessage), LOCK_TIME, typeof(ResDestinyInfoMessage));
        RegistLockMsg(typeof(ReqMopDestinyMessage), LOCK_TIME, typeof(ResMopDestinyMessage));

        //邮件
        RegistLockMsg(typeof(ReqGetMailAttachMessage), LOCK_TIME, typeof(ResGetMailAttachMessage));
        RegistLockMsg(typeof(ReqGetAllMailAttachMessage), LOCK_TIME, typeof(ResGetAllMailAttachMessage));

        //探索
        RegistLockMsg(typeof(ReqBeginDiscoveryMessage), LOCK_TIME, typeof(ResBeginDiscoveryMessage));
        RegistLockMsg(typeof(ReqReceiveDiscoveryRewardMessage), LOCK_TIME, typeof(ResReceiveDiscoveryRewardMessage));

        //竞技场
        RegistLockMsg(typeof(ReqStartArenaMessage), LOCK_TIME, typeof(ResStartArenaMessage));
        RegistLockMsg(typeof(ReqAddArenaCountMessage), LOCK_TIME, typeof(ResPlayerArenaInfoMessage));
        RegistLockMsg(typeof(ReqFightNowMessage), LOCK_TIME, typeof(ResPlayerArenaInfoMessage));
        RegistLockMsg(typeof(ReqTotalWinRewardMessage), LOCK_TIME, typeof(ResArenaTotalWinCountMessage));

        //地狱蝶
        RegistLockMsg(typeof(ReqStartButterflyMessage), LOCK_TIME, typeof(ResStartButterflyMessage));
        RegistLockMsg(typeof(ReqButterflyFightNowMessage), LOCK_TIME, typeof(ResButterflyFightNowMessage));
        RegistLockMsg(typeof(ReqChangeButterflyOpponentMessage), LOCK_TIME, typeof(ResButterflyOpponentInfoMessage));

        //兑换
        RegistLockMsg(typeof(ReqSoulExchangeMessage), LOCK_TIME, typeof(ResSoulExchangeMessage));

        //剧情关卡
        RegistLockMsg(typeof(ReqEnterLevelMessage), LOCK_TIME, typeof(ResEnterLevelMessage));
        RegistLockMsg(typeof(ReqMopMessage), LOCK_TIME, typeof(ResMopInfoMessage));

        //道具
        RegistLockMsg(typeof(ReqSellMessage), LOCK_TIME, typeof(ResSingleItemInfoMessage));

        //料理
        //RegistLockMsg(typeof(ReqFoodCookMessage), LOCK_TIME, typeof(ResFoodCookMessage));

        //魂之力
        RegistLockMsg(typeof(ReqStrengthenDeathpowerMessage), LOCK_TIME, typeof(ResStrengthenDeathpowerMessage));
        RegistLockMsg(typeof(ReqFastStrengthenDeathpowerMessage), LOCK_TIME, typeof(ResFastStrengthenDeathpowerMessage));

        //番队副本
        RegistLockMsg(typeof(ReqGangInstanceActiveMessage), LOCK_TIME, typeof(ResGangOptMessage));
        RegistLockMsg(typeof(ReqGangInstanceEnterMessage), LOCK_TIME, typeof(ResEnterGangInstanceMessage));

        //番队系统
        RegistLockMsg(typeof(ReqGangExitMessage), LOCK_TIME, typeof(ResGangOptMessage));
        RegistLockMsg(typeof(ReqGangRemoveMemberMessage), LOCK_TIME, typeof(ResGangMemberExitMessage));
        RegistLockMsg(typeof(ReqGangSupportStartMessage), LOCK_TIME, typeof(ResGangSupportCharacterInfoUpdateMessage));
        RegistLockMsg(typeof(ReqGangSupportEndMessage), LOCK_TIME, typeof(ResGangSupportCharacterInfoUpdateMessage));
        RegistLockMsg(typeof(ReqGangWorshipMessage), LOCK_TIME, typeof(ResGangWorshipMessage));
        RegistLockMsg(typeof(ReqGangSetMessage), LOCK_TIME, typeof(ResGangSetMessage));
        RegistLockMsg(typeof(ReqGangWorshipPrizeMessage), LOCK_TIME, typeof(ResGangWorshipPrizeMessage));
        RegistLockMsg(typeof(ReqGangMemberCharactersInfoMessage), LOCK_TIME, typeof(ResGangMemberCharactersInfoMessage));
        RegistLockMsg(typeof(ReqGangInfoByIndexMessage), LOCK_TIME, typeof(ResGangInfoByIndexMessage));
        RegistLockMsg(typeof(ReqGangInfoByQueryIdMessage), LOCK_TIME, typeof(ResGangInfoByGangIdMessage));
        RegistLockMsg(typeof(ReqGivePrayItemMessage), LOCK_TIME, typeof(ResGivePrayItemMessage));
        RegistLockMsg(typeof(ReqPublishGangPrayMessage), LOCK_TIME, typeof(ResPublishGangPrayMessage));

        // 10连抽
        RegistLockMsg(typeof(ReqStartLotteryMessage), LOCK_TIME, typeof(ResLotteryRewardMessage));

        // 签到
        RegistLockMsg(typeof(ReqSigninMessage), LOCK_TIME, typeof(ResSigninMessage));

        // 登陆
        RegistLockMsg(typeof(ReqLoginMessage), LOCK_TIME, typeof(ResLoginResultMessage));
        RegistLockMsg(typeof(ReqCreatePlayerMessage), LOCK_TIME, typeof(ResCreatePlayerResultMessage));

        // 特训
        RegistLockMsg(typeof(ReqBeginSpecialTrainingMessage), LOCK_TIME, typeof(ResBeginSpecialTrainingMessage));
        RegistLockMsg(typeof(ReqOpenSpecialTrainingBoxMessage), LOCK_TIME, typeof(ResOpenSpecialTrainingBoxMessage));
        RegistLockMsg(typeof(ReqUseSubstituteMessage), LOCK_TIME, typeof(ResUseSubstituteMessage));
        RegistLockMsg(typeof(ReqFinishSpecialTrainingMessage), LOCK_TIME, typeof(ResFinishSpecialTrainingMessage));
        RegistLockMsg(typeof(ReqOneKeySpecialTrainingMessage), LOCK_TIME, typeof(ResOneKeySpecialTrainingMessage));

        // 无间之战
        RegistLockMsg(typeof(ReqLimitArenaOpponentMessage), LOCK_TIME, typeof(ResLimitArenaOpponentMessage));
        RegistLockMsg(typeof(ReqLimitArenaRewardMessage), LOCK_TIME, typeof(ResPlayerLimitArenaInfoMessage));
        RegistLockMsg(typeof(ReqStartLimitArenaBattleMessage), LOCK_TIME, typeof(ResStartLimitArenaBattleMessage));
        RegistLockMsg(typeof(ReqMopLimitArenaMessage), LOCK_TIME, typeof(ResMopLimitArenaMessage));

        // 礼包
        RegistLockMsg(typeof(ReqExchangeCodeRewardMessage), LOCK_TIME, typeof(ResExchangeCodeRewardMessage));

        // 碎片转换
        RegistLockMsg(typeof(ReqNuclearFusionMessage), LOCK_TIME, typeof(ResNuclearFusionMessage));

        // 灵魂共鸣
        RegistLockMsg(typeof(ReqSoulResonanceSelectMessage), LOCK_TIME, typeof(ResSoulResonanceSelectMessage));
        RegistLockMsg(typeof(ReqSoulResonanceUpLevelMessage), LOCK_TIME, typeof(ResSoulResonanceUpLevelMessage));

        // 更改玩家名字
        RegistLockMsg(typeof(ReqChangePlayerNameMessage), LOCK_TIME, typeof(ResChangePlayerNameMessage));

        // 战斗
        RegistLockMsg(typeof(ReqEndBattleMessage), LOCK_TIME, typeof(ResEndBattleMessage));

        // 极限挑战
        RegistLockMsg(typeof(ReqStartUnlimitFightBattleMessage), LOCK_TIME, typeof(ResStartUnlimitFightBattleMessage));
        RegistLockMsg(typeof(ReqMopUnlimitFightBattleMessage), LOCK_TIME, typeof(ResMopUnlimitFightBattleMessage));
        RegistLockMsg(typeof(ReqFastMopUnlimitFightBattleMessage), LOCK_TIME, typeof(ResFastMopUnlimitFightBattleMessage));

        // VIP福利
        RegistLockMsg(typeof(ReqGetVipWelfareRewardMessage), LOCK_TIME, typeof(ResGetVipWelfareRewardMessage));

        // 百万招财
        RegistLockMsg(typeof(ReqMillionLotteryMessage), LOCK_TIME, typeof(ResMillionLotteryMessage));
        RegistLockMsg(typeof(ReqExchangeMillionItemMessage), LOCK_TIME, typeof(ResExchangeMillionItemMessage));

        // 番队战
        RegistLockMsg(typeof(ReqGangBattleApplyMessage), LOCK_TIME, typeof(ResGangBattleApplyMessage));
        RegistLockMsg(typeof(ReqStartGangBattleMessage), LOCK_TIME, typeof(ResStartGangBattleMessage));

        // 巅峰竞技场
        RegistLockMsg(typeof(ReqStartTopArenaBattleMessage), LOCK_TIME, typeof(ResStartTopArenaBattleMessage));
        RegistLockMsg(typeof(ReqTopArenaOpponentMessage), LOCK_TIME, typeof(ResTopArenaOpponentMessage));
        RegistLockMsg(typeof(ReqTopArenaWinRewardMessage), LOCK_TIME, typeof(ResPlayerTopArenaInfoMessage));
        RegistLockMsg(typeof(ReqTopArenaGiveUpMessage), LOCK_TIME, typeof(ResTopArenaGiveUpMessage));

        // 好友
        RegistLockMsg(typeof(ReqAddRelationshipPlayerMessage), LOCK_TIME, typeof(ResAddRelationshipPlayerMessage));
        RegistLockMsg(typeof(ReqRemoveRelationshipPlayerMessage), LOCK_TIME, typeof(ResRemoveRelationshipPlayerMessage));
        RegistLockMsg(typeof(ReqViewPlayerInfoMessage), LOCK_TIME, typeof(ResViewPlayerInfoMessage));

        // 充值
        RegistLockMsg(typeof(ReqRechargeSoulBingoMessage), LOCK_TIME, typeof(ResRechargeSoulBingoMessage));

        // 灵力试炼
        RegistLockMsg(typeof(ReqStartAdvanceTrialBattleMessage), LOCK_TIME, typeof(ResStartAdvanceTrialBattleMessage));
        RegistLockMsg(typeof(ReqBuyAdvanceTrialTimesMessage), LOCK_TIME, typeof(ResAdvanceTrialTimesMessage));

        // 特殊商店
        RegistLockMsg(typeof(ReqBuySpecialShopItemMessage), LOCK_TIME, typeof(ResBuySpecialShopItemMessage));
        RegistLockMsg(typeof(ReqRefreshSpecialShopMessage), LOCK_TIME, typeof(ResSpecialShopInfoMessage));

        // 排行榜
        RegistLockMsg(typeof(ReqRankPlayerInfoMessage), LOCK_TIME, typeof(ResRankPlayerInfoMessage));

        // 答题
        RegistLockMsg(typeof(ReqSeletcSujectMessage), LOCK_TIME, typeof(ResAnswerChoseStateMessage));

        // 断界
        RegistLockMsg(typeof(ReqEscortRecordMessage), LOCK_TIME, typeof(ResEscortRecordMessage));
        RegistLockMsg(typeof(ReqClearChageTimeMessage), LOCK_TIME, typeof(ResClearChageTimeMessage));
        RegistLockMsg(typeof(ReqStartTransportMessage), LOCK_TIME, typeof(ResStartTransportMessage));
        RegistLockMsg(typeof(ReqCragoDetailMessage), LOCK_TIME, typeof(ResPlayerCargoInfoMessage));

        // 灵压
        RegistLockMsg(typeof(ReqSoulPressUpgradeMessage), LOCK_TIME, typeof(ResSoulPressUpgradeMessage));

        //世界boss   
        RegistLockMsg(typeof(ReqWorldBossBuyBuffMessage), LOCK_TIME, typeof(ResWorldBossBuyBuffMessage));
        RegistLockMsg(typeof(ReqEnterWorldBossMapMessage), LOCK_TIME, typeof(ResEnterWorldBossMapMessage));
        RegistLockMsg(typeof(ReqWorldBossPlayerSyncMessage), LOCK_TIME, typeof(ResWorldBossPlayerSyncMessage));
        RegistLockMsg(typeof(ReqWorldBossFightDataMessage), LOCK_TIME, typeof(ResWorldBossFightDataMessage));

        //消消乐
        RegistLockMsg(typeof(ReqPopExchangeMessage), LOCK_TIME, typeof(ResPopExchangeMessage));
        // 静血装
        RegistLockMsg(typeof(ReqStaticBloodLevelUpMessage), LOCK_TIME, typeof(ResStaticBloodUpResultMessage));

        //副本群
        RegistLockMsg(typeof(ReqExecuteEventMessage), LOCK_TIME, typeof(ResEventEeffectTipsInfoMessage));
        RegistLockMsg(typeof(ReqStartExploreFightMessage), LOCK_TIME, typeof(ResStartExploreFightMessage));
        RegistLockMsg(typeof(ReqExploreChangeActorMessage), LOCK_TIME, typeof(ResExplorePlayerInfoMessage));
    }

    void RegistLockMsg(System.Type msgType, float lockTime, System.Type resMsgType)
    {
        if (_lockMsgDic.ContainsKey(msgType))
        {
            Debug.LogWarningFormat("Lock msg {0} already exist!", msgType);
            return;
        }

        var info = new LockMsgInfo(msgType, lockTime, resMsgType);
        _lockMsgDic.Add(info.MsgType, info);
    }

    LockMsgInfo GetLockMsgInfo(System.Type msgType)
    {
        LockMsgInfo info = null;
        if (_lockMsgDic.TryGetValue(msgType, out info))
            return info;
        else
            return null;
    }

    /// <summary>
    /// 设置消息独占
    /// </summary>
    /// <param name="msg"></param>
    void SetLockStatus(LockMsgInfo msgInfo)
    {
        _curLockMsgInfo = msgInfo;
        _lockMsgOverTime = Time.unscaledTime + msgInfo.LockTime;
        LockStatus = LockMsgStatus.Lock;
    }

    /// <summary>
    /// 收到消息解除独占
    /// </summary>
    /// <param name="resMsgType"></param>
    void OnReceiveMsg(Message msg)
    {
        // Keep alive
        IsNewMsgReceived = true;

        // Keep alive 心跳消息不计入接收消息数
        // TODO: 聊天，公告等消息不计入
        if (!_protocol.IsInsignificantProtocol(msg.GetId()))
        {
            _receivedMsgCount++;
        }
        //else if (Global.LOG)
        //{
        //    Debug.Log("Receive keep alive msg (MT): " + Time.unscaledTime);
        //}

        // Update lock state
        if (LockStatus == LockMsgStatus.Lock && _curLockMsgInfo.ResMsgType == msg.GetType())
        {
            LockStatus = LockMsgStatus.Unlock;
            _curLockMsgInfo = null;
        }
    }

    /// <summary>
    /// 超时解除独占
    /// </summary>
    void CheckLockMsgTimeout()
    {
        if (LockStatus == LockMsgStatus.Lock && Time.unscaledTime >= _lockMsgOverTime)
        {
            if (OnLockMsgTimeOutEvent != null)
            {
                OnLockMsgTimeOutEvent(_curLockMsgInfo);
            }

            Debug.LogWarning(string.Format("Send msg {0}<-->{1} timeout!", _curLockMsgInfo.MsgType, _curLockMsgInfo.ResMsgType));

            LockStatus = LockMsgStatus.TimeOut;
            _curLockMsgInfo = null;
        }
    }

}

