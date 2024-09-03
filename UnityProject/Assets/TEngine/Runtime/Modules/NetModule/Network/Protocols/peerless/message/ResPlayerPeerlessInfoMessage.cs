using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 回复玩家无双死神信息 message
 */
public class ResPlayerPeerlessInfoMessage : Message 
{
	//玩家无双死神信息
	TopArenaInfo _peerlessInfo;	
	//每日参与战斗次数
	int _dailyCount;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//玩家无双死神信息
		SerializeUtils.WriteBean(stream, _peerlessInfo);
		//每日参与战斗次数
		SerializeUtils.WriteInt(stream, _dailyCount);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//玩家无双死神信息
		_peerlessInfo = SerializeUtils.ReadBean<TopArenaInfo>(stream);
		//每日参与战斗次数
		_dailyCount = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 玩家无双死神信息
	 */
	public TopArenaInfo PeerlessInfo
	{
		set { _peerlessInfo = value; }
	    get { return _peerlessInfo; }
	}
	
	/**
	 * 每日参与战斗次数
	 */
	public int DailyCount
	{
		set { _dailyCount = value; }
	    get { return _dailyCount; }
	}
	
	
	public override int GetId() 
	{
		return 817108;
	}
}