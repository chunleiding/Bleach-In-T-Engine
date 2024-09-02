using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 排行榜请求单个玩家详细信息 message
 */
public class ResRankPlayerInfoMessage : Message
{
    PlayerSyncInfo _playerSyncInfo = new PlayerSyncInfo();

    /**
     * 序列化
     */
    public override void Serialize(Stream stream)
    {
        SerializeUtils.WriteBean(stream, _playerSyncInfo);
    }

    /**
     * 反序列化
     */
    public override void Deserialize(Stream stream)
    {
        _playerSyncInfo = SerializeUtils.ReadBean<PlayerSyncInfo>(stream);
    }

    /**
     * 玩家id
     */
    public PlayerSyncInfo PlayerSyncInfo
    {
        set { _playerSyncInfo = value; }
        get { return _playerSyncInfo; }
    }

    public override int GetId()
    {
        return 209110;
    }
}