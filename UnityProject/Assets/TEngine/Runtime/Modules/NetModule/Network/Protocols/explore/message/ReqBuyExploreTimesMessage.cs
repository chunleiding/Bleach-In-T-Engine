using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求兑换挑战次数 message
 */
public class ReqBuyExploreTimesMessage : Message 
{
	//购买挑战次数对应魂玉
	int _price;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//购买挑战次数对应魂玉
		SerializeUtils.WriteInt(stream, _price);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//购买挑战次数对应魂玉
		_price = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 购买挑战次数对应魂玉
	 */
	public int Price
	{
		set { _price = value; }
	    get { return _price; }
	}
	
	
	public override int GetId() 
	{
		return 831107;
	}
}