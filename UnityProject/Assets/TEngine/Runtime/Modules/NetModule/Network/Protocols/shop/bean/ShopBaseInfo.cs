using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 商店商品配置表基础信息
 */
public class ShopBaseInfo : IMessageSerialize 
{
	//商品对应的物品ID与数量
	ItemInfo _shopItemDetail;	
	//商品名称
	int _commodityName;	
	//商品对应图标ID
	int _commodityIcon;	
	//价格
	int _price;	
	//可购买次数
	int _times;	
	//商品描述文本
	int _commodityDesc;	
	//溢价类型
	int _premiumType;	
	//商品ID
	int _commodityID;	
	//货币类型（1经验;2环;3灵子;4魂玉;5竞技点;6星星;7体力;8贡献值;9试炼币;12排行榜点数;13百万招财积分）
	int _priceType;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//商品对应的物品ID与数量
		SerializeUtils.WriteBean(stream, _shopItemDetail);
		//商品名称
		SerializeUtils.WriteInt(stream, _commodityName);
		//商品对应图标ID
		SerializeUtils.WriteInt(stream, _commodityIcon);
		//价格
		SerializeUtils.WriteInt(stream, _price);
		//可购买次数
		SerializeUtils.WriteInt(stream, _times);
		//商品描述文本
		SerializeUtils.WriteInt(stream, _commodityDesc);
		//溢价类型
		SerializeUtils.WriteInt(stream, _premiumType);
		//商品ID
		SerializeUtils.WriteInt(stream, _commodityID);
		//货币类型（1经验;2环;3灵子;4魂玉;5竞技点;6星星;7体力;8贡献值;9试炼币;12排行榜点数;13百万招财积分）
		SerializeUtils.WriteInt(stream, _priceType);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//商品对应的物品ID与数量
		_shopItemDetail = SerializeUtils.ReadBean<ItemInfo>(stream);
		//商品名称
		_commodityName = SerializeUtils.ReadInt(stream);
		//商品对应图标ID
		_commodityIcon = SerializeUtils.ReadInt(stream);
		//价格
		_price = SerializeUtils.ReadInt(stream);
		//可购买次数
		_times = SerializeUtils.ReadInt(stream);
		//商品描述文本
		_commodityDesc = SerializeUtils.ReadInt(stream);
		//溢价类型
		_premiumType = SerializeUtils.ReadInt(stream);
		//商品ID
		_commodityID = SerializeUtils.ReadInt(stream);
		//货币类型（1经验;2环;3灵子;4魂玉;5竞技点;6星星;7体力;8贡献值;9试炼币;12排行榜点数;13百万招财积分）
		_priceType = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 商品对应的物品ID与数量
	 */
	public ItemInfo ShopItemDetail
	{
		set { _shopItemDetail = value; }
	    get { return _shopItemDetail; }
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
	 * 商品对应图标ID
	 */
	public int CommodityIcon
	{
		set { _commodityIcon = value; }
	    get { return _commodityIcon; }
	}
	
	/**
	 * 价格
	 */
	public int Price
	{
		set { _price = value; }
	    get { return _price; }
	}
	
	/**
	 * 可购买次数
	 */
	public int Times
	{
		set { _times = value; }
	    get { return _times; }
	}
	
	/**
	 * 商品描述文本
	 */
	public int CommodityDesc
	{
		set { _commodityDesc = value; }
	    get { return _commodityDesc; }
	}
	
	/**
	 * 溢价类型
	 */
	public int PremiumType
	{
		set { _premiumType = value; }
	    get { return _premiumType; }
	}
	
	/**
	 * 商品ID
	 */
	public int CommodityID
	{
		set { _commodityID = value; }
	    get { return _commodityID; }
	}
	
	/**
	 * 货币类型（1经验;2环;3灵子;4魂玉;5竞技点;6星星;7体力;8贡献值;9试炼币;12排行榜点数;13百万招财积分）
	 */
	public int PriceType
	{
		set { _priceType = value; }
	    get { return _priceType; }
	}
	
}