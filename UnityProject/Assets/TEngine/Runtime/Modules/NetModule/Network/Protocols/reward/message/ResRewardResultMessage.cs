using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 *  message
 */
public class ResRewardResultMessage : Message 
{
	//奖励系统类型
	int _systemType;	
	//奖励信息
	List<ItemInfo> _rewardInfo = new List<ItemInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//奖励系统类型
		SerializeUtils.WriteInt(stream, _systemType);
		//奖励信息
		SerializeUtils.WriteShort(stream, (short)_rewardInfo.Count);

		foreach (var element in _rewardInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//奖励系统类型
		_systemType = SerializeUtils.ReadInt(stream);
		//奖励信息
		int _rewardInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _rewardInfo_length; ++i) 
		{
			_rewardInfo.Add(SerializeUtils.ReadBean<ItemInfo>(stream));
		}
	}
	
	/**
	 * 奖励系统类型
	 */
	public int SystemType
	{
		set { _systemType = value; }
	    get { return _systemType; }
	}
	
	/**
	 * get 奖励信息
	 * @return 
	 */
	public List<ItemInfo> GetRewardInfo()
	{
		return _rewardInfo;
	}
	
	/**
	 * set 奖励信息
	 */
	public void SetRewardInfo(List<ItemInfo> rewardInfo)
	{
		_rewardInfo = rewardInfo;
	}
	
	
	public override int GetId() 
	{
		return 205101;
	}
}