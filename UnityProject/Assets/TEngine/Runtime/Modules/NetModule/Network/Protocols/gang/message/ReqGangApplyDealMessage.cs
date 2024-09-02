using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 处理申请者信息 message
 */
public class ReqGangApplyDealMessage : Message 
{
	//操作类型
	byte _type;	
	//玩家id,-1表示所有
	long _playerId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//操作类型
		SerializeUtils.WriteByte(stream, _type);
		//玩家id,-1表示所有
		SerializeUtils.WriteLong(stream, _playerId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//操作类型
		_type = SerializeUtils.ReadByte(stream);
		//玩家id,-1表示所有
		_playerId = SerializeUtils.ReadLong(stream);
	}
	
	/**
	 * 操作类型
	 */
	public byte Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	/**
	 * 玩家id,-1表示所有
	 */
	public long PlayerId
	{
		set { _playerId = value; }
	    get { return _playerId; }
	}
	
	
	public override int GetId() 
	{
		return 109208;
	}
}