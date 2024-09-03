using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 回复穿越断界气力值恢复消息 message
 */
public class ResEscortHealthRecoverMessage : Message 
{
	//距离下次恢复的秒数
	int _cdTime;	
	//当前气力值数
	int _health;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//距离下次恢复的秒数
		SerializeUtils.WriteInt(stream, _cdTime);
		//当前气力值数
		SerializeUtils.WriteInt(stream, _health);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//距离下次恢复的秒数
		_cdTime = SerializeUtils.ReadInt(stream);
		//当前气力值数
		_health = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 距离下次恢复的秒数
	 */
	public int CdTime
	{
		set { _cdTime = value; }
	    get { return _cdTime; }
	}
	
	/**
	 * 当前气力值数
	 */
	public int Health
	{
		set { _health = value; }
	    get { return _health; }
	}
	
	
	public override int GetId() 
	{
		return 810114;
	}
}