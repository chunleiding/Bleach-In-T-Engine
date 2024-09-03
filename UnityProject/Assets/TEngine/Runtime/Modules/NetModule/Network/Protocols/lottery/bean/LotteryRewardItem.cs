using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 抽奖道具奖励
 */
public class LotteryRewardItem : IMessageSerialize 
{
	//类型：(0，普通抽奖，1，必中的)
	int _type;	
	//道具id
	int _itemId;	
	//道具数量
	int _itemCount;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//类型：(0，普通抽奖，1，必中的)
		SerializeUtils.WriteInt(stream, _type);
		//道具id
		SerializeUtils.WriteInt(stream, _itemId);
		//道具数量
		SerializeUtils.WriteInt(stream, _itemCount);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//类型：(0，普通抽奖，1，必中的)
		_type = SerializeUtils.ReadInt(stream);
		//道具id
		_itemId = SerializeUtils.ReadInt(stream);
		//道具数量
		_itemCount = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 类型：(0，普通抽奖，1，必中的)
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	/**
	 * 道具id
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
	
}