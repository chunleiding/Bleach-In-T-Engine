using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 新服首充商品返利
 */
public class FirstChargeCommodityInfo : IMessageSerialize 
{
	//商品id
	int _commodityId;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//商品id
		SerializeUtils.WriteInt(stream, _commodityId);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
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
	
}