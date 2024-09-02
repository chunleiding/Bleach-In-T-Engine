using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 货币商店商品信息 message
 */
public class ResIchigoTrialCommodityMessage : Message 
{
	//一护试炼全部商品信息
	List<IchigoTrialCommodity> _ichigoCommodity = new List<IchigoTrialCommodity>();
	//货币剩余时间：多久过期
	int _currencyLeftTime;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//一护试炼全部商品信息
		SerializeUtils.WriteShort(stream, (short)_ichigoCommodity.Count);

		foreach (var element in _ichigoCommodity)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//货币剩余时间：多久过期
		SerializeUtils.WriteInt(stream, _currencyLeftTime);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//一护试炼全部商品信息
		int _ichigoCommodity_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _ichigoCommodity_length; ++i) 
		{
			_ichigoCommodity.Add(SerializeUtils.ReadBean<IchigoTrialCommodity>(stream));
		}
		//货币剩余时间：多久过期
		_currencyLeftTime = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * get 一护试炼全部商品信息
	 * @return 
	 */
	public List<IchigoTrialCommodity> GetIchigoCommodity()
	{
		return _ichigoCommodity;
	}
	
	/**
	 * set 一护试炼全部商品信息
	 */
	public void SetIchigoCommodity(List<IchigoTrialCommodity> ichigoCommodity)
	{
		_ichigoCommodity = ichigoCommodity;
	}
	
	/**
	 * 货币剩余时间：多久过期
	 */
	public int CurrencyLeftTime
	{
		set { _currencyLeftTime = value; }
	    get { return _currencyLeftTime; }
	}
	
	
	public override int GetId() 
	{
		return 825105;
	}
}