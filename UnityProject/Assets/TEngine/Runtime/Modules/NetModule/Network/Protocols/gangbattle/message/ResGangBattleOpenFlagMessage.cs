using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队战系统是否开启标志 message
 */
public class ResGangBattleOpenFlagMessage : Message 
{
	//0：关闭，1：开启
	int _flag;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0：关闭，1：开启
		SerializeUtils.WriteInt(stream, _flag);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0：关闭，1：开启
		_flag = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0：关闭，1：开启
	 */
	public int Flag
	{
		set { _flag = value; }
	    get { return _flag; }
	}
	
	
	public override int GetId() 
	{
		return 112109;
	}
}