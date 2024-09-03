using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求发放番队福袋 message
 */
public class ReqGiveGangBagMessage : Message 
{
	//福袋类型
	int _type;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//福袋类型
		SerializeUtils.WriteInt(stream, _type);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//福袋类型
		_type = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 福袋类型
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	
	public override int GetId() 
	{
		return 109224;
	}
}