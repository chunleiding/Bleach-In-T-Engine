using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 一护试炼请求兑换商品 message
 */
public class ReqIchigoTrialExchangeMessage : Message 
{
	//商品id
	int _commodityId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//商品id
		SerializeUtils.WriteInt(stream, _commodityId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//商品id
		_commodityId = SerializeUtils.ReadInt(stream);
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
		return 825107;
	}
}