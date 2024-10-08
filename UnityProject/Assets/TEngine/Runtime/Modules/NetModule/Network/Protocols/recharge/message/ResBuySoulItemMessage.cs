using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 使用魂玉购买商品 message
 */
public class ResBuySoulItemMessage : Message 
{
	//0-成功 1-魂玉不够 2-其他原因
	int _result;	
	//商品Id
	int _commodityId;	
	//购买次数
	int _buyTime;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0-成功 1-魂玉不够 2-其他原因
		SerializeUtils.WriteInt(stream, _result);
		//商品Id
		SerializeUtils.WriteInt(stream, _commodityId);
		//购买次数
		SerializeUtils.WriteInt(stream, _buyTime);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0-成功 1-魂玉不够 2-其他原因
		_result = SerializeUtils.ReadInt(stream);
		//商品Id
		_commodityId = SerializeUtils.ReadInt(stream);
		//购买次数
		_buyTime = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0-成功 1-魂玉不够 2-其他原因
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * 商品Id
	 */
	public int CommodityId
	{
		set { _commodityId = value; }
	    get { return _commodityId; }
	}
	
	/**
	 * 购买次数
	 */
	public int BuyTime
	{
		set { _buyTime = value; }
	    get { return _buyTime; }
	}
	
	
	public override int GetId() 
	{
		return 312106;
	}
}