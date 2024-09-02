using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 删除玩家番队申请(同步申请信息) message
 */
public class ResDelGangApplyMessage : Message 
{
	//番队申请的玩家id
	long _playerId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//番队申请的玩家id
		SerializeUtils.WriteLong(stream, _playerId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//番队申请的玩家id
		_playerId = SerializeUtils.ReadLong(stream);
	}
	
	/**
	 * 番队申请的玩家id
	 */
	public long PlayerId
	{
		set { _playerId = value; }
	    get { return _playerId; }
	}
	
	
	public override int GetId() 
	{
		return 109117;
	}
}