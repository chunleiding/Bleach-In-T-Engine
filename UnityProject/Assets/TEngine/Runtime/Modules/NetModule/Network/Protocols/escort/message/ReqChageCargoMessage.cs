using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求换一批货物 message
 */
public class ReqChageCargoMessage : Message 
{
	//1主动点0自动刷新
	int _type;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//1主动点0自动刷新
		SerializeUtils.WriteInt(stream, _type);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//1主动点0自动刷新
		_type = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 1主动点0自动刷新
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	
	public override int GetId() 
	{
		return 810102;
	}
}