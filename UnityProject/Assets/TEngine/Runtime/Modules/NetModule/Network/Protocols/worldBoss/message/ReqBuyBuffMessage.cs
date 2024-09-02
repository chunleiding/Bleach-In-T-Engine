using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 购买buff message
 */
public class ReqBuyBuffMessage : Message 
{
	//0:魂玉 1：灵子
	int _type;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0:魂玉 1：灵子
		SerializeUtils.WriteInt(stream, _type);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0:魂玉 1：灵子
		_type = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0:魂玉 1：灵子
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	
	public override int GetId() 
	{
		return 807106;
	}
}