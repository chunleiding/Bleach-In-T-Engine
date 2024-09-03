using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 当前参与的人数 message
 */
public class ResJoinNumMessage : Message 
{
	//做题人数
	int _num;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//做题人数
		SerializeUtils.WriteInt(stream, _num);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//做题人数
		_num = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 做题人数
	 */
	public int Num
	{
		set { _num = value; }
	    get { return _num; }
	}
	
	
	public override int GetId() 
	{
		return 808104;
	}
}