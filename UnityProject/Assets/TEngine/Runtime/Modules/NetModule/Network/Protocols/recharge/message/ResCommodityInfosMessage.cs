using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 充值商品信息 message
 */
public class ResCommodityInfosMessage : Message 
{
	//商品Id
	List<NormalCommodityInfo> _normalInfos = new List<NormalCommodityInfo>();
	//商品Id
	List<MonthCardInfo> _monthCardInfos = new List<MonthCardInfo>();
	//商品Id
	List<GrowthCardInfo> _growthCardInfos = new List<GrowthCardInfo>();
	//新服首充返利
	List<FirstChargeCommodityInfo> _fistChargeInfos = new List<FirstChargeCommodityInfo>();
	//多倍充值商品列表
	List<MultiRechargeInfo> _multiRechargeInfos = new List<MultiRechargeInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//商品Id
		SerializeUtils.WriteShort(stream, (short)_normalInfos.Count);

		foreach (var element in _normalInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//商品Id
		SerializeUtils.WriteShort(stream, (short)_monthCardInfos.Count);

		foreach (var element in _monthCardInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//商品Id
		SerializeUtils.WriteShort(stream, (short)_growthCardInfos.Count);

		foreach (var element in _growthCardInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//新服首充返利
		SerializeUtils.WriteShort(stream, (short)_fistChargeInfos.Count);

		foreach (var element in _fistChargeInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//多倍充值商品列表
		SerializeUtils.WriteShort(stream, (short)_multiRechargeInfos.Count);

		foreach (var element in _multiRechargeInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//商品Id
		int _normalInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _normalInfos_length; ++i) 
		{
			_normalInfos.Add(SerializeUtils.ReadBean<NormalCommodityInfo>(stream));
		}
		//商品Id
		int _monthCardInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _monthCardInfos_length; ++i) 
		{
			_monthCardInfos.Add(SerializeUtils.ReadBean<MonthCardInfo>(stream));
		}
		//商品Id
		int _growthCardInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _growthCardInfos_length; ++i) 
		{
			_growthCardInfos.Add(SerializeUtils.ReadBean<GrowthCardInfo>(stream));
		}
		//新服首充返利
		int _fistChargeInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _fistChargeInfos_length; ++i) 
		{
			_fistChargeInfos.Add(SerializeUtils.ReadBean<FirstChargeCommodityInfo>(stream));
		}
		//多倍充值商品列表
		int _multiRechargeInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _multiRechargeInfos_length; ++i) 
		{
			_multiRechargeInfos.Add(SerializeUtils.ReadBean<MultiRechargeInfo>(stream));
		}
	}
	
	/**
	 * get 商品Id
	 * @return 
	 */
	public List<NormalCommodityInfo> GetNormalInfos()
	{
		return _normalInfos;
	}
	
	/**
	 * set 商品Id
	 */
	public void SetNormalInfos(List<NormalCommodityInfo> normalInfos)
	{
		_normalInfos = normalInfos;
	}
	
	/**
	 * get 商品Id
	 * @return 
	 */
	public List<MonthCardInfo> GetMonthCardInfos()
	{
		return _monthCardInfos;
	}
	
	/**
	 * set 商品Id
	 */
	public void SetMonthCardInfos(List<MonthCardInfo> monthCardInfos)
	{
		_monthCardInfos = monthCardInfos;
	}
	
	/**
	 * get 商品Id
	 * @return 
	 */
	public List<GrowthCardInfo> GetGrowthCardInfos()
	{
		return _growthCardInfos;
	}
	
	/**
	 * set 商品Id
	 */
	public void SetGrowthCardInfos(List<GrowthCardInfo> growthCardInfos)
	{
		_growthCardInfos = growthCardInfos;
	}
	
	/**
	 * get 新服首充返利
	 * @return 
	 */
	public List<FirstChargeCommodityInfo> GetFistChargeInfos()
	{
		return _fistChargeInfos;
	}
	
	/**
	 * set 新服首充返利
	 */
	public void SetFistChargeInfos(List<FirstChargeCommodityInfo> fistChargeInfos)
	{
		_fistChargeInfos = fistChargeInfos;
	}
	
	/**
	 * get 多倍充值商品列表
	 * @return 
	 */
	public List<MultiRechargeInfo> GetMultiRechargeInfos()
	{
		return _multiRechargeInfos;
	}
	
	/**
	 * set 多倍充值商品列表
	 */
	public void SetMultiRechargeInfos(List<MultiRechargeInfo> multiRechargeInfos)
	{
		_multiRechargeInfos = multiRechargeInfos;
	}
	
	
	public override int GetId() 
	{
		return 312101;
	}
}