using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 响应领取番队建设奖励消息 message
 */
public class ResGangBuildRewardMessage : Message 
{
	//番队建设领奖结果[0:成功,1:番队建设等级不足,2:今日已经领取了所有番队建设的奖励]
	int _result;	
	//番队建设奖励列表
	List<ItemInfo> _rewardList = new List<ItemInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//番队建设领奖结果[0:成功,1:番队建设等级不足,2:今日已经领取了所有番队建设的奖励]
		SerializeUtils.WriteInt(stream, _result);
		//番队建设奖励列表
		SerializeUtils.WriteShort(stream, (short)_rewardList.Count);

		foreach (var element in _rewardList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//番队建设领奖结果[0:成功,1:番队建设等级不足,2:今日已经领取了所有番队建设的奖励]
		_result = SerializeUtils.ReadInt(stream);
		//番队建设奖励列表
		int _rewardList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _rewardList_length; ++i) 
		{
			_rewardList.Add(SerializeUtils.ReadBean<ItemInfo>(stream));
		}
	}
	
	/**
	 * 番队建设领奖结果[0:成功,1:番队建设等级不足,2:今日已经领取了所有番队建设的奖励]
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * get 番队建设奖励列表
	 * @return 
	 */
	public List<ItemInfo> GetRewardList()
	{
		return _rewardList;
	}
	
	/**
	 * set 番队建设奖励列表
	 */
	public void SetRewardList(List<ItemInfo> rewardList)
	{
		_rewardList = rewardList;
	}
	
	
	public override int GetId() 
	{
		return 109155;
	}
}