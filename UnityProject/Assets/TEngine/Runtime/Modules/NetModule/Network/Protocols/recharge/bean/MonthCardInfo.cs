using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 月卡信息
 */
public class MonthCardInfo : IMessageSerialize 
{
	//商品Id
	int _cardId;	
	//剩余秒数
	int _lastTime;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//商品Id
		SerializeUtils.WriteInt(stream, _cardId);
		//剩余秒数
		SerializeUtils.WriteInt(stream, _lastTime);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//商品Id
		_cardId = SerializeUtils.ReadInt(stream);
		//剩余秒数
		_lastTime = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 商品Id
	 */
	public int CardId
	{
		set { _cardId = value; }
	    get { return _cardId; }
	}
	
	/**
	 * 剩余秒数
	 */
	public int LastTime
	{
		set { _lastTime = value; }
	    get { return _lastTime; }
	}
	
}