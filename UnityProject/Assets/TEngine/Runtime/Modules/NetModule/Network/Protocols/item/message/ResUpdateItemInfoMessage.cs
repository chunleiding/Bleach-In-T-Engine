using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 刷新玩家物品信息 message
 */
public class ResUpdateItemInfoMessage : Message 
{
	//刷新列表
	List<ItemInfo> _itemList = new List<ItemInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//刷新列表
		SerializeUtils.WriteShort(stream, (short)_itemList.Count);

		foreach (var element in _itemList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//刷新列表
		int _itemList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _itemList_length; ++i) 
		{
			_itemList.Add(SerializeUtils.ReadBean<ItemInfo>(stream));
		}
	}
	
	/**
	 * get 刷新列表
	 * @return 
	 */
	public List<ItemInfo> GetItemList()
	{
		return _itemList;
	}
	
	/**
	 * set 刷新列表
	 */
	public void SetItemList(List<ItemInfo> itemList)
	{
		_itemList = itemList;
	}
	
	
	public override int GetId() 
	{
		return 101102;
	}
}