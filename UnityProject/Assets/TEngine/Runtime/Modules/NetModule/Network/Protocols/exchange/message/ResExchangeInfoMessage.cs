using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 兑换信息 message
 */
public class ResExchangeInfoMessage : Message 
{
	//魂玉兑换信息
	ExchangeInfo _exchangeInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//魂玉兑换信息
		SerializeUtils.WriteBean(stream, _exchangeInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//魂玉兑换信息
		_exchangeInfo = SerializeUtils.ReadBean<ExchangeInfo>(stream);
	}
	
	/**
	 * 魂玉兑换信息
	 */
	public ExchangeInfo ExchangeInfo
	{
		set { _exchangeInfo = value; }
	    get { return _exchangeInfo; }
	}
	
	
	public override int GetId() 
	{
		return 207101;
	}
}