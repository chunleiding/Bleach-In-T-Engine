using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求赠送祈愿道具 message
 */
public class ReqGivePrayItemMessage : Message 
{
	//玩家id
	long _playerId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//玩家id
		SerializeUtils.WriteLong(stream, _playerId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//玩家id
		_playerId = SerializeUtils.ReadLong(stream);
	}
	
	/**
	 * 玩家id
	 */
	public long PlayerId
	{
		set { _playerId = value; }
	    get { return _playerId; }
	}
	
	
	public override int GetId() 
	{
		return 109260;
	}
}