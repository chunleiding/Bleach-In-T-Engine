using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求排行榜单个玩家详细信息 message
 */
public class ReqRankPlayerInfoMessage : Message
{
    //成员的玩家id
    long _playerId;

    /**
     * 序列化
     */
    public override void Serialize(Stream stream)
    {
        //成员的玩家id
        SerializeUtils.WriteLong(stream, _playerId);
    }

    /**
     * 反序列化
     */
    public override void Deserialize(Stream stream)
    {
        //成员的玩家id
        _playerId = SerializeUtils.ReadLong(stream);
    }

    /**
     * 成员的玩家id
     */
    public long PlayerId
    {
        set { _playerId = value; }
        get { return _playerId; }
    }


    public override int GetId()
    {
        return 209203;
    }
}