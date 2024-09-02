using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 前端请求查看玩家消息 message
 */
public class ReqViewPlayerInfoMessage : Message 
{
	//玩家编号
	long _playerId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//玩家编号
		SerializeUtils.WriteLong(stream, _playerId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//玩家编号
		_playerId = SerializeUtils.ReadLong(stream);
	}
	
	/**
	 * 玩家编号
	 */
	public long PlayerId
	{
		set { _playerId = value; }
	    get { return _playerId; }
	}
	
	
	public override int GetId() 
	{
		return 223201;
	}
}