using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 刷星回复 message
 */
public class ResRefreshStarMessage : Message
{
    //星星数
    int _startNum;
    //奖励比例(万分比分子)
    int _rewardRatio;
    //刷新次数
    int _count;

    /**
     * 序列化
     */
    public override void Serialize(Stream stream)
    {
        //星星数
        SerializeUtils.WriteInt(stream, _startNum);
        //奖励比例(万分比分子)
        SerializeUtils.WriteInt(stream, _rewardRatio);
        //刷新次数
        SerializeUtils.WriteInt(stream, _count);
    }

    /**
     * 反序列化
     */
    public override void Deserialize(Stream stream)
    {
        //星星数
        _startNum = SerializeUtils.ReadInt(stream);
        //奖励比例(万分比分子)
        _rewardRatio = SerializeUtils.ReadInt(stream);
        //刷新次数
        _count = SerializeUtils.ReadInt(stream);
    }

    /**
     * 星星数
     */
    public int StartNum
    {
        set { _startNum = value; }
        get { return _startNum; }
    }

    /**
     * 奖励比例(万分比分子)
     */
    public int RewardRatio
    {
        set { _rewardRatio = value; }
        get { return _rewardRatio; }
    }

    /**
     * 刷新次数
     */
    public int Count
    {
        set { _count = value; }
        get { return _count; }
    }


    public override int GetId()
    {
        return 810122;
    }
}