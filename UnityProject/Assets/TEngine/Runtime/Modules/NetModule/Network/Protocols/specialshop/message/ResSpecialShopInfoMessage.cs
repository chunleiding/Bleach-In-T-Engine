using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 商店开放时信息同步 message
 */
public class ResSpecialShopInfoMessage : Message 
{
	//商品列表
	List<ShopItemInfo> _shopItemList = new List<ShopItemInfo>();
	//结束时间剩余秒数
	int _closeTime;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//商品列表
		SerializeUtils.WriteShort(stream, (short)_shopItemList.Count);

		foreach (var element in _shopItemList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//结束时间剩余秒数
		SerializeUtils.WriteInt(stream, _closeTime);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//商品列表
		int _shopItemList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _shopItemList_length; ++i) 
		{
			_shopItemList.Add(SerializeUtils.ReadBean<ShopItemInfo>(stream));
		}
		//结束时间剩余秒数
		_closeTime = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * get 商品列表
	 * @return 
	 */
	public List<ShopItemInfo> GetShopItemList()
	{
		return _shopItemList;
	}
	
	/**
	 * set 商品列表
	 */
	public void SetShopItemList(List<ShopItemInfo> shopItemList)
	{
		_shopItemList = shopItemList;
	}
	
	/**
	 * 结束时间剩余秒数
	 */
	public int CloseTime
	{
		set { _closeTime = value; }
	    get { return _closeTime; }
	}
	
	
	public override int GetId() 
	{
		return 225101;
	}
}