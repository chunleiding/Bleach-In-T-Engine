using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 一护试炼兑换商品结果 message
 */
public class ResExchangeResultMessage : Message 
{
	//结果 0：成功；大于0：其他原因
	int _result;	
	//商品id
	int _commodityId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//结果 0：成功；大于0：其他原因
		SerializeUtils.WriteInt(stream, _result);
		//商品id
		SerializeUtils.WriteInt(stream, _commodityId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//结果 0：成功；大于0：其他原因
		_result = SerializeUtils.ReadInt(stream);
		//商品id
		_commodityId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 结果 0：成功；大于0：其他原因
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * 商品id
	 */
	public int CommodityId
	{
		set { _commodityId = value; }
	    get { return _commodityId; }
	}
	
	
	public override int GetId() 
	{
		return 825108;
	}
}