using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 服务器禁止玩家发言 message
 */
public class ResSilenceMessage : Message 
{
	//禁言时长(-1:永久禁言,0:没有禁言或禁言时间已过或者取消禁言,大于0:禁言的时长(毫秒))
	long _silenceDuration;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//禁言时长(-1:永久禁言,0:没有禁言或禁言时间已过或者取消禁言,大于0:禁言的时长(毫秒))
		SerializeUtils.WriteLong(stream, _silenceDuration);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//禁言时长(-1:永久禁言,0:没有禁言或禁言时间已过或者取消禁言,大于0:禁言的时长(毫秒))
		_silenceDuration = SerializeUtils.ReadLong(stream);
	}
	
	/**
	 * 禁言时长(-1:永久禁言,0:没有禁言或禁言时间已过或者取消禁言,大于0:禁言的时长(毫秒))
	 */
	public long SilenceDuration
	{
		set { _silenceDuration = value; }
	    get { return _silenceDuration; }
	}
	
	
	public override int GetId() 
	{
		return 307105;
	}
}