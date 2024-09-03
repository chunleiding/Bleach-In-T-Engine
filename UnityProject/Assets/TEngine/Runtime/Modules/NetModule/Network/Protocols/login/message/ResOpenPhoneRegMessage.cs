using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 开启手机号注册活动 message
 */
public class ResOpenPhoneRegMessage : Message 
{
	//展示奖励
	List<ItemInfo> _reward = new List<ItemInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//展示奖励
		SerializeUtils.WriteShort(stream, (short)_reward.Count);

		foreach (var element in _reward)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//展示奖励
		int _reward_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _reward_length; ++i) 
		{
			_reward.Add(SerializeUtils.ReadBean<ItemInfo>(stream));
		}
	}
	
	/**
	 * get 展示奖励
	 * @return 
	 */
	public List<ItemInfo> GetReward()
	{
		return _reward;
	}
	
	/**
	 * set 展示奖励
	 */
	public void SetReward(List<ItemInfo> reward)
	{
		_reward = reward;
	}
	
	
	public override int GetId() 
	{
		return 100206;
	}
}