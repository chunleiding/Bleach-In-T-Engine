using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 同步一户试炼游戏时间 message
 */
public class ResSynIchigoTimeMessage : Message 
{
	//战斗剩余时间
	int _leftTime;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//战斗剩余时间
		SerializeUtils.WriteInt(stream, _leftTime);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//战斗剩余时间
		_leftTime = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 战斗剩余时间
	 */
	public int LeftTime
	{
		set { _leftTime = value; }
	    get { return _leftTime; }
	}
	
	
	public override int GetId() 
	{
		return 825118;
	}
}