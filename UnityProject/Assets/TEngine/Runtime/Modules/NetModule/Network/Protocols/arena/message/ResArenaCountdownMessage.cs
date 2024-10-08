using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 玩家竞技场下次开始时间 message
 */
public class ResArenaCountdownMessage : Message 
{
	//距离下次开始倒计时
	int _countdown;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//距离下次开始倒计时
		SerializeUtils.WriteInt(stream, _countdown);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//距离下次开始倒计时
		_countdown = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 距离下次开始倒计时
	 */
	public int Countdown
	{
		set { _countdown = value; }
	    get { return _countdown; }
	}
	
	
	public override int GetId() 
	{
		return 206112;
	}
}