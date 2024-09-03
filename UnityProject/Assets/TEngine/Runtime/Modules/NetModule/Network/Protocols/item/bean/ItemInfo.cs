using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 道具信息
 */
public class ItemInfo : IMessageSerialize 
{
	//道具model
	int _itemId;	
	//道具数量
	int _itemCount;	
	//过期时间点,（0，永久道具，非0，从1970.1.1开始的秒数）
	int _validity;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//道具model
		SerializeUtils.WriteInt(stream, _itemId);
		//道具数量
		SerializeUtils.WriteInt(stream, _itemCount);
		//过期时间点,（0，永久道具，非0，从1970.1.1开始的秒数）
		SerializeUtils.WriteInt(stream, _validity);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//道具model
		_itemId = SerializeUtils.ReadInt(stream);
		//道具数量
		_itemCount = SerializeUtils.ReadInt(stream);
		//过期时间点,（0，永久道具，非0，从1970.1.1开始的秒数）
		_validity = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 道具model
	 */
	public int ItemId
	{
		set { _itemId = value; }
	    get { return _itemId; }
	}
	
	/**
	 * 道具数量
	 */
	public int ItemCount
	{
		set { _itemCount = value; }
	    get { return _itemCount; }
	}
	
	/**
	 * 过期时间点,（0，永久道具，非0，从1970.1.1开始的秒数）
	 */
	public int Validity
	{
		set { _validity = value; }
	    get { return _validity; }
	}
	
}