using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 回复单个玩家的货物信息 message
 */
public class ResPlayerCargoInfoMessage : Message 
{
	//1,体力不足 2安全时间 3正在战斗 0可以打劫
	int _isSuccess;	
	//最新配打击次数
	int _robNumber;	
	//玩家id
	long _playerId;	
	//打劫获得的数量
	int _itemCount;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//1,体力不足 2安全时间 3正在战斗 0可以打劫
		SerializeUtils.WriteInt(stream, _isSuccess);
		//最新配打击次数
		SerializeUtils.WriteInt(stream, _robNumber);
		//玩家id
		SerializeUtils.WriteLong(stream, _playerId);
		//打劫获得的数量
		SerializeUtils.WriteInt(stream, _itemCount);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//1,体力不足 2安全时间 3正在战斗 0可以打劫
		_isSuccess = SerializeUtils.ReadInt(stream);
		//最新配打击次数
		_robNumber = SerializeUtils.ReadInt(stream);
		//玩家id
		_playerId = SerializeUtils.ReadLong(stream);
		//打劫获得的数量
		_itemCount = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 1,体力不足 2安全时间 3正在战斗 0可以打劫
	 */
	public int IsSuccess
	{
		set { _isSuccess = value; }
	    get { return _isSuccess; }
	}
	
	/**
	 * 最新配打击次数
	 */
	public int RobNumber
	{
		set { _robNumber = value; }
	    get { return _robNumber; }
	}
	
	/**
	 * 玩家id
	 */
	public long PlayerId
	{
		set { _playerId = value; }
	    get { return _playerId; }
	}
	
	/**
	 * 打劫获得的数量
	 */
	public int ItemCount
	{
		set { _itemCount = value; }
	    get { return _itemCount; }
	}
	
	
	public override int GetId() 
	{
		return 810116;
	}
}