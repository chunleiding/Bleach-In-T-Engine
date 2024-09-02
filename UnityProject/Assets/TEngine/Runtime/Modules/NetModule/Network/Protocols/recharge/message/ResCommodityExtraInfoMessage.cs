using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 在售商品列表额外消息 message
 */
public class ResCommodityExtraInfoMessage : Message 
{
	//在售商品列表
	List<RechargeExtraInfo> _onsellExtraList = new List<RechargeExtraInfo>();
	//新服vip保送礼包
	List<NormalCommodityInfo> _vipGiftInfos = new List<NormalCommodityInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//在售商品列表
		SerializeUtils.WriteShort(stream, (short)_onsellExtraList.Count);

		foreach (var element in _onsellExtraList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//新服vip保送礼包
		SerializeUtils.WriteShort(stream, (short)_vipGiftInfos.Count);

		foreach (var element in _vipGiftInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//在售商品列表
		int _onsellExtraList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _onsellExtraList_length; ++i) 
		{
			_onsellExtraList.Add(SerializeUtils.ReadBean<RechargeExtraInfo>(stream));
		}
		//新服vip保送礼包
		int _vipGiftInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _vipGiftInfos_length; ++i) 
		{
			_vipGiftInfos.Add(SerializeUtils.ReadBean<NormalCommodityInfo>(stream));
		}
	}
	
	/**
	 * get 在售商品列表
	 * @return 
	 */
	public List<RechargeExtraInfo> GetOnsellExtraList()
	{
		return _onsellExtraList;
	}
	
	/**
	 * set 在售商品列表
	 */
	public void SetOnsellExtraList(List<RechargeExtraInfo> onsellExtraList)
	{
		_onsellExtraList = onsellExtraList;
	}
	
	/**
	 * get 新服vip保送礼包
	 * @return 
	 */
	public List<NormalCommodityInfo> GetVipGiftInfos()
	{
		return _vipGiftInfos;
	}
	
	/**
	 * set 新服vip保送礼包
	 */
	public void SetVipGiftInfos(List<NormalCommodityInfo> vipGiftInfos)
	{
		_vipGiftInfos = vipGiftInfos;
	}
	
	
	public override int GetId() 
	{
		return 312211;
	}
}