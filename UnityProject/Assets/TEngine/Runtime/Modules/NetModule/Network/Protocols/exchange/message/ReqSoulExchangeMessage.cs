using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 魂玉兑换请求 message
 */
public class ReqSoulExchangeMessage : Message 
{
	//0：兑换环，1：兑换体力
	int _type;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0：兑换环，1：兑换体力
		SerializeUtils.WriteInt(stream, _type);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0：兑换环，1：兑换体力
		_type = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0：兑换环，1：兑换体力
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	
	public override int GetId() 
	{
		return 207201;
	}
}