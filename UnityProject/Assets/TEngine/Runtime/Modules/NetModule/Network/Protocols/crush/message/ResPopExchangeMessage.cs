using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 回复兑换 message
 */
public class ResPopExchangeMessage : Message 
{
	//结果(0:成功,1:活动未开始,2:没有该兑换ID,3:积分不够,4:今日次数用尽)
	int _result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//结果(0:成功,1:活动未开始,2:没有该兑换ID,3:积分不够,4:今日次数用尽)
		SerializeUtils.WriteInt(stream, _result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//结果(0:成功,1:活动未开始,2:没有该兑换ID,3:积分不够,4:今日次数用尽)
		_result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 结果(0:成功,1:活动未开始,2:没有该兑换ID,3:积分不够,4:今日次数用尽)
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	
	public override int GetId() 
	{
		return 821105;
	}
}