using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 一护试炼商品信息
 */
public class IchigoTrialCommodity : IMessageSerialize 
{
	//商品id
	int _commodityId;	
	//商品列表
	List<ItemInfo> _itemList = new List<ItemInfo>();
	//商品价格：需要多少货币才能兑换
	int _price;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//商品id
		SerializeUtils.WriteInt(stream, _commodityId);
		//商品列表
		SerializeUtils.WriteShort(stream, (short)_itemList.Count);

		foreach (var element in _itemList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//商品价格：需要多少货币才能兑换
		SerializeUtils.WriteInt(stream, _price);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//商品id
		_commodityId = SerializeUtils.ReadInt(stream);
		//商品列表
		int _itemList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _itemList_length; ++i) 
		{
			_itemList.Add(SerializeUtils.ReadBean<ItemInfo>(stream));
		}
		//商品价格：需要多少货币才能兑换
		_price = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 商品id
	 */
	public int CommodityId
	{
		set { _commodityId = value; }
	    get { return _commodityId; }
	}
	
	/**
	 * get 商品列表
	 * @return 
	 */
	public List<ItemInfo> GetItemList()
	{
		return _itemList;
	}
	
	/**
	 * set 商品列表
	 */
	public void SetItemList(List<ItemInfo> itemList)
	{
		_itemList = itemList;
	}
	
	/**
	 * 商品价格：需要多少货币才能兑换
	 */
	public int Price
	{
		set { _price = value; }
	    get { return _price; }
	}
	
}