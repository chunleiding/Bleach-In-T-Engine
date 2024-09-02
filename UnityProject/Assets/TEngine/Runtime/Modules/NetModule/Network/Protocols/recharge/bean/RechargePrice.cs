using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 商品价格信息
 */
public class RechargePrice : IMessageSerialize 
{
	//价格类型
	int _priceType;	
	//价格数值
	int _priceCount;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//价格类型
		SerializeUtils.WriteInt(stream, _priceType);
		//价格数值
		SerializeUtils.WriteInt(stream, _priceCount);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//价格类型
		_priceType = SerializeUtils.ReadInt(stream);
		//价格数值
		_priceCount = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 价格类型
	 */
	public int PriceType
	{
		set { _priceType = value; }
	    get { return _priceType; }
	}

    /**
     * 价格数值
     * 此接口不能直接使用 如果需要请使用RechargeMgr.GetPriceCount
     */
    public int PriceCount
	{
		set { _priceCount = value; }
	    get { return _priceCount; }
	}
	
}