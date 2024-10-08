using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 地狱蝶信息 message
 */
public class ResButterflyInfoMessage : Message 
{
	//地狱蝶消息
	ButterflyInfo _butterflyInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//地狱蝶消息
		SerializeUtils.WriteBean(stream, _butterflyInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//地狱蝶消息
		_butterflyInfo = SerializeUtils.ReadBean<ButterflyInfo>(stream);
	}
	
	/**
	 * 地狱蝶消息
	 */
	public ButterflyInfo ButterflyInfo
	{
		set { _butterflyInfo = value; }
	    get { return _butterflyInfo; }
	}
	
	
	public override int GetId() 
	{
		return 211300;
	}
}