using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 获取玩家极限对决特殊奖励信息列表的回复 message
 */
public class ResDownSpecialRewardInfoMessage : Message 
{
	//特殊奖励信息列表
	List<DownSpecialRewardInfo> _specialRewardInfo = new List<DownSpecialRewardInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//特殊奖励信息列表
		SerializeUtils.WriteShort(stream, (short)_specialRewardInfo.Count);

		foreach (var element in _specialRewardInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//特殊奖励信息列表
		int _specialRewardInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _specialRewardInfo_length; ++i) 
		{
			_specialRewardInfo.Add(SerializeUtils.ReadBean<DownSpecialRewardInfo>(stream));
		}
	}
	
	/**
	 * get 特殊奖励信息列表
	 * @return 
	 */
	public List<DownSpecialRewardInfo> GetSpecialRewardInfo()
	{
		return _specialRewardInfo;
	}
	
	/**
	 * set 特殊奖励信息列表
	 */
	public void SetSpecialRewardInfo(List<DownSpecialRewardInfo> specialRewardInfo)
	{
		_specialRewardInfo = specialRewardInfo;
	}
	
	
	public override int GetId() 
	{
		return 221106;
	}
}