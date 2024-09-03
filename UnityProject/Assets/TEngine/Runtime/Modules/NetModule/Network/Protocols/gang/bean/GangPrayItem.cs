using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队祈愿道具信息
 */
public class GangPrayItem : IMessageSerialize 
{
	//道具id
	int _itemId;	
	//道具数量
	int _itemCount;	
	//能发布的最大道具数量
	int _maxCount;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//道具id
		SerializeUtils.WriteInt(stream, _itemId);
		//道具数量
		SerializeUtils.WriteInt(stream, _itemCount);
		//能发布的最大道具数量
		SerializeUtils.WriteInt(stream, _maxCount);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//道具id
		_itemId = SerializeUtils.ReadInt(stream);
		//道具数量
		_itemCount = SerializeUtils.ReadInt(stream);
		//能发布的最大道具数量
		_maxCount = SerializeUtils.ReadInt(stream);
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
	
	/**
	 * 能发布的最大道具数量
	 */
	public int MaxCount
	{
		set { _maxCount = value; }
	    get { return _maxCount; }
	}
	
}