using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求兑换 message
 */
public class ReqPopExchangeMessage : Message 
{
	//兑换ID
	int _commodityId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//兑换ID
		SerializeUtils.WriteInt(stream, _commodityId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//兑换ID
		_commodityId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 兑换ID
	 */
	public int CommodityId
	{
		set { _commodityId = value; }
	    get { return _commodityId; }
	}
	
	
	public override int GetId() 
	{
		return 821104;
	}
}