using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 十次一键特训结果 message
 */
public class ResTenTimesSpecialTrainingMessage : Message
{
    //特训角色
    int _characterId;
    //特训buffId
    int _buffId;
    //不超过10轮特训每次信息
    List<OnceSpecialTrainingInfo> _trainingInfoList = new List<OnceSpecialTrainingInfo>();
    //////0:成功,1:VIP特权不足,2:无特权卡，3:灵子不足,4:魂玉不足,5:已经进行了手动特训, 6:已经有角色开始特训
    int _result;

    /**
     * 序列化
     */
    public override void Serialize(Stream stream)
    {
        //特训角色
        SerializeUtils.WriteInt(stream, _characterId);
        //特训buffId
        SerializeUtils.WriteInt(stream, _buffId);
        //不超过10轮特训每次信息
        SerializeUtils.WriteShort(stream, (short)_trainingInfoList.Count);

        foreach (var element in _trainingInfoList)
        {
            SerializeUtils.WriteBean(stream, element);
        }
        //////0:成功,1:VIP特权不足,2:无特权卡，3:灵子不足,4:魂玉不足,5:已经进行了手动特训, 6:已经有角色开始特训
        SerializeUtils.WriteInt(stream, _result);
    }

    /**
     * 反序列化
     */
    public override void Deserialize(Stream stream)
    {
        //特训角色
        _characterId = SerializeUtils.ReadInt(stream);
        //特训buffId
        _buffId = SerializeUtils.ReadInt(stream);
        //不超过10轮特训每次信息
        int _trainingInfoList_length = SerializeUtils.ReadShort(stream);
        for (int i = 0; i < _trainingInfoList_length; ++i)
        {
            _trainingInfoList.Add(SerializeUtils.ReadBean<OnceSpecialTrainingInfo>(stream));
        }
        //////0:成功,1:VIP特权不足,2:无特权卡，3:灵子不足,4:魂玉不足,5:已经进行了手动特训, 6:已经有角色开始特训
        _result = SerializeUtils.ReadInt(stream);
    }

    /**
     * 特训角色
     */
    public int CharacterId
    {
        set { _characterId = value; }
        get { return _characterId; }
    }

    /**
     * 特训buffId
     */
    public int BuffId
    {
        set { _buffId = value; }
        get { return _buffId; }
    }

    /**
     * get 不超过10轮特训每次信息
     * @return 
     */
    public List<OnceSpecialTrainingInfo> GetTrainingInfoList()
    {
        return _trainingInfoList;
    }

    /**
     * set 不超过10轮特训每次信息
     */
    public void SetTrainingInfoList(List<OnceSpecialTrainingInfo> trainingInfoList)
    {
        _trainingInfoList = trainingInfoList;
    }

    /**
     * ////0:成功,1:VIP特权不足,2:无特权卡，3:灵子不足,4:魂玉不足,5:已经进行了手动特训, 6:已经有角色开始特训
     */
    public int Result
    {
        set { _result = value; }
        get { return _result; }
    }


    public override int GetId()
    {
        return 310207;
    }
}