using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 响应自己奖池奖励列表消息 message
 */
public class ResMillionPoolRewardSelfInfosMessage : Message 
{
	//自己累计的魂玉数量
	long _soul;	
	//自己的奖池奖励信息列表
	List<MillionPoolRewardInfo> _millionPoolRewardInfos = new List<MillionPoolRewardInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//自己累计的魂玉数量
		SerializeUtils.WriteLong(stream, _soul);
		//自己的奖池奖励信息列表
		SerializeUtils.WriteShort(stream, (short)_millionPoolRewardInfos.Count);

		foreach (var element in _millionPoolRewardInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//自己累计的魂玉数量
		_soul = SerializeUtils.ReadLong(stream);
		//自己的奖池奖励信息列表
		int _millionPoolRewardInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _millionPoolRewardInfos_length; ++i) 
		{
			_millionPoolRewardInfos.Add(SerializeUtils.ReadBean<MillionPoolRewardInfo>(stream));
		}
	}
	
	/**
	 * 自己累计的魂玉数量
	 */
	public long Soul
	{
		set { _soul = value; }
	    get { return _soul; }
	}
	
	/**
	 * get 自己的奖池奖励信息列表
	 * @return 
	 */
	public List<MillionPoolRewardInfo> GetMillionPoolRewardInfos()
	{
		return _millionPoolRewardInfos;
	}
	
	/**
	 * set 自己的奖池奖励信息列表
	 */
	public void SetMillionPoolRewardInfos(List<MillionPoolRewardInfo> millionPoolRewardInfos)
	{
		_millionPoolRewardInfos = millionPoolRewardInfos;
	}
	
	
	public override int GetId() 
	{
		return 316107;
	}
}