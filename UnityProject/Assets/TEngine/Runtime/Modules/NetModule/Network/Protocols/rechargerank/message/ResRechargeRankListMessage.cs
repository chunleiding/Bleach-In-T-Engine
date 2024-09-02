using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 排名相关信息 message
 */
public class ResRechargeRankListMessage : Message 
{
	//充值消耗排名信息
	List<RechargeRankBean> _rankInfo = new List<RechargeRankBean>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//充值消耗排名信息
		SerializeUtils.WriteShort(stream, (short)_rankInfo.Count);

		foreach (var element in _rankInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//充值消耗排名信息
		int _rankInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _rankInfo_length; ++i) 
		{
			_rankInfo.Add(SerializeUtils.ReadBean<RechargeRankBean>(stream));
		}
	}
	
	/**
	 * get 充值消耗排名信息
	 * @return 
	 */
	public List<RechargeRankBean> GetRankInfo()
	{
		return _rankInfo;
	}
	
	/**
	 * set 充值消耗排名信息
	 */
	public void SetRankInfo(List<RechargeRankBean> rankInfo)
	{
		_rankInfo = rankInfo;
	}
	
	
	public override int GetId() 
	{
		return 819102;
	}
}