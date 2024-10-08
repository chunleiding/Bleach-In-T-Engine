using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求立即结束cd时间 message
 */
public class ResButterflyFightNowMessage : Message 
{
	//0：成功，1：魂玉不足
	int _result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0：成功，1：魂玉不足
		SerializeUtils.WriteInt(stream, _result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0：成功，1：魂玉不足
		_result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0：成功，1：魂玉不足
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	
	public override int GetId() 
	{
		return 211206;
	}
}