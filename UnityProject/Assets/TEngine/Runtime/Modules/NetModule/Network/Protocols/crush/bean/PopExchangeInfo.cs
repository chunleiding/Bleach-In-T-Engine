using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 消消乐兑换数据
 */
public class PopExchangeInfo : IMessageSerialize 
{
	//id
	int _id;	
	//兑换的道具列表
	List<ItemInfo> _itemList = new List<ItemInfo>();
	//商品名称
	int _commodityName;	
	//商品描述
	int _commodityDesc;	
	//商品ICON
	int _commodityIcon;	
	//货币类型
	int _priceType;	
	//兑换价格
	int _price;	
	//当日可兑换次数
	int _conut;	
	//已经兑换的次数
	int _exchangedTimes;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//id
		SerializeUtils.WriteInt(stream, _id);
		//兑换的道具列表
		SerializeUtils.WriteShort(stream, (short)_itemList.Count);

		foreach (var element in _itemList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//商品名称
		SerializeUtils.WriteInt(stream, _commodityName);
		//商品描述
		SerializeUtils.WriteInt(stream, _commodityDesc);
		//商品ICON
		SerializeUtils.WriteInt(stream, _commodityIcon);
		//货币类型
		SerializeUtils.WriteInt(stream, _priceType);
		//兑换价格
		SerializeUtils.WriteInt(stream, _price);
		//当日可兑换次数
		SerializeUtils.WriteInt(stream, _conut);
		//已经兑换的次数
		SerializeUtils.WriteInt(stream, _exchangedTimes);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//id
		_id = SerializeUtils.ReadInt(stream);
		//兑换的道具列表
		int _itemList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _itemList_length; ++i) 
		{
			_itemList.Add(SerializeUtils.ReadBean<ItemInfo>(stream));
		}
		//商品名称
		_commodityName = SerializeUtils.ReadInt(stream);
		//商品描述
		_commodityDesc = SerializeUtils.ReadInt(stream);
		//商品ICON
		_commodityIcon = SerializeUtils.ReadInt(stream);
		//货币类型
		_priceType = SerializeUtils.ReadInt(stream);
		//兑换价格
		_price = SerializeUtils.ReadInt(stream);
		//当日可兑换次数
		_conut = SerializeUtils.ReadInt(stream);
		//已经兑换的次数
		_exchangedTimes = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * id
	 */
	public int Id
	{
		set { _id = value; }
	    get { return _id; }
	}
	
	/**
	 * get 兑换的道具列表
	 * @return 
	 */
	public List<ItemInfo> GetItemList()
	{
		return _itemList;
	}
	
	/**
	 * set 兑换的道具列表
	 */
	public void SetItemList(List<ItemInfo> itemList)
	{
		_itemList = itemList;
	}
	
	/**
	 * 商品名称
	 */
	public int CommodityName
	{
		set { _commodityName = value; }
	    get { return _commodityName; }
	}
	
	/**
	 * 商品描述
	 */
	public int CommodityDesc
	{
		set { _commodityDesc = value; }
	    get { return _commodityDesc; }
	}
	
	/**
	 * 商品ICON
	 */
	public int CommodityIcon
	{
		set { _commodityIcon = value; }
	    get { return _commodityIcon; }
	}
	
	/**
	 * 货币类型
	 */
	public int PriceType
	{
		set { _priceType = value; }
	    get { return _priceType; }
	}
	
	/**
	 * 兑换价格
	 */
	public int Price
	{
		set { _price = value; }
	    get { return _price; }
	}
	
	/**
	 * 当日可兑换次数
	 */
	public int Conut
	{
		set { _conut = value; }
	    get { return _conut; }
	}
	
	/**
	 * 已经兑换的次数
	 */
	public int ExchangedTimes
	{
		set { _exchangedTimes = value; }
	    get { return _exchangedTimes; }
	}
	
}