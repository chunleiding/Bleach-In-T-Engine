using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队战挑战期间 message
 */
public class ResGangBattlePeriodInfoMessage : Message 
{
	//番队战状态
	int _period;	
	//该状态持续时间，毫秒
	long _lastTime;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//番队战状态
		SerializeUtils.WriteInt(stream, _period);
		//该状态持续时间，毫秒
		SerializeUtils.WriteLong(stream, _lastTime);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//番队战状态
		_period = SerializeUtils.ReadInt(stream);
		//该状态持续时间，毫秒
		_lastTime = SerializeUtils.ReadLong(stream);
	}
	
	/**
	 * 番队战状态
	 */
	public int Period
	{
		set { _period = value; }
	    get { return _period; }
	}
	
	/**
	 * 该状态持续时间，毫秒
	 */
	public long LastTime
	{
		set { _lastTime = value; }
	    get { return _lastTime; }
	}
	
	
	public override int GetId() 
	{
		return 112108;
	}
}