using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求货物详细信息 message
 */
public class ReqCragoDetailMessage : Message 
{
	//玩家ID
	long _playerID;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//玩家ID
		SerializeUtils.WriteLong(stream, _playerID);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//玩家ID
		_playerID = SerializeUtils.ReadLong(stream);
	}
	
	/**
	 * 玩家ID
	 */
	public long PlayerID
	{
		set { _playerID = value; }
	    get { return _playerID; }
	}
	
	
	public override int GetId() 
	{
		return 810115;
	}
}