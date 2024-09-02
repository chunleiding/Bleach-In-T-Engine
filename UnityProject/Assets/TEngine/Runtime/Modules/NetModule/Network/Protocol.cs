using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using TEngine;

public class Protocol
{
    const int PROCESS_NUM_PERFRAME = 20;

    // 网络线程
    List<Message> _protocolList = new List<Message>();

    // 主线程
    List<Message> _tempProtocolList = new List<Message>();
    // 可忽略的协议（不计入断线重连接收协议数匹配）
    List<int> _insignificantProtocolList = new List<int>();

    readonly object _locker = new object();



    public event Action<Message> OnReceiveMsgEvent;

    private Dictionary<int, Message> _protocolMessageDictionary = new Dictionary<int, Message>();


    public Protocol()
    {
        _insignificantProtocolList.Add(100108); // ResKeepAliveMessage
        _insignificantProtocolList.Add(307101); // ResAnnouncementIMMessage
        _insignificantProtocolList.Add(307106); // ResGMAnnouncementIMMessage
        _insignificantProtocolList.Add(307102); // ResSendPrivateChatMessage
        _insignificantProtocolList.Add(307103); // ResSendGangMessage
        _insignificantProtocolList.Add(307104); // ResSendWorldMessage
        _insignificantProtocolList.Add(316105); // ResMillionAccumulateSoulMessage
    }

    //解析协议
    public void ProcessProtocol(bool processAll = false)
    {
        if (_protocolList.Count == 0)
            return;
        lock (_protocolList)
        {
            var count = _protocolList.Count;
            if (count > 0)
            {
                for (var i = 0; i < count; ++i)
                {
                    _tempProtocolList.Add(_protocolList[i]);
                }
                _protocolList.Clear();
            }
        }

        int leftCount;
        if (processAll)
        {
            leftCount = _tempProtocolList.Count;
        }
        else
        {
            leftCount = Mathf.Min(PROCESS_NUM_PERFRAME, _tempProtocolList.Count);
        }

        while (leftCount > 0)
        {
            if (_tempProtocolList.Count > 0)
            {
                var message = _tempProtocolList[0];
                ProcessProtocol(message);
                _tempProtocolList.RemoveAt(0);
                --leftCount;
            }
        }

    }

    public void Clear()
    {
        ProcessProtocol(true);
    }

    void ProcessProtocol(Message message)
    {
        if (OnReceiveMsgEvent != null)
            OnReceiveMsgEvent(message);

        if (message != null)
        {
            GameEvent.Send(message.GetId(), message);
        }
    }

    #region Network thread

    //网络线程接收协议
    public void ReceiveProtocol(Stream msgStream)
    {
        var msgId = SerializeUtils.ReadInt(msgStream);

        var message = GetMessage(msgId);
        if (message == null)
        {
            return;
        }

        try
        {
            message.Deserialize(msgStream);
        }
        catch (Exception)
        {
            Debug.LogError(string.Format("@@Message mismatch (network thread) {0}:{1}.", msgId, message.ToString()));
            return;
        }

        lock (_protocolList)
        {
            _protocolList.Add(message);
        }
    }

    #endregion Network thread


    public void SetMessage(int id, Message mes)
    {
        var isSuccess = _protocolMessageDictionary.TryAdd(id, mes);
        if (!isSuccess)
        {
            Log.Error("消息未注册");
        }
    }

    Message GetMessage(int id)
    {
        var message = GetMessageHandler(id);
        return message; // TODO:
    }

    private Message GetMessageHandler(int id)
    {
        //这里查看服务器发送过来的消息号是否注册;
        if (!_protocolMessageDictionary.TryGetValue(id, out var mes))
        {
            Log.Error($"消息未注册,id is{id}");   
        }
        return mes;
    }

    public bool IsInsignificantProtocol(int id)
    {
        return _insignificantProtocolList.Contains(id);
    }
}
