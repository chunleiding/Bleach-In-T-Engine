using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 多倍充值信息
 */
public class MultiRechargeInfo : IMessageSerialize 
{
	//商品id
	int _productId;	
	//购买次数
	int _times;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//商品id
		SerializeUtils.WriteInt(stream, _productId);
		//购买次数
		SerializeUtils.WriteInt(stream, _times);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//商品id
		_productId = SerializeUtils.ReadInt(stream);
		//购买次数
		_times = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 商品id
	 */
	public int ProductId
	{
		set { _productId = value; }
	    get { return _productId; }
	}
	
	/**
	 * 购买次数
	 */
	public int Times
	{
		set { _times = value; }
	    get { return _times; }
	}
	
}