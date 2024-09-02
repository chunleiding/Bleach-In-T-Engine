using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 一护试炼历史积分排行榜 message
 */
public class ResIchigoTrialRankListMessage : Message 
{
	//一护试炼玩家积分排行榜
	List<TrialRankBean> _ichigoTrialRankList = new List<TrialRankBean>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//一护试炼玩家积分排行榜
		SerializeUtils.WriteShort(stream, (short)_ichigoTrialRankList.Count);

		foreach (var element in _ichigoTrialRankList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//一护试炼玩家积分排行榜
		int _ichigoTrialRankList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _ichigoTrialRankList_length; ++i) 
		{
			_ichigoTrialRankList.Add(SerializeUtils.ReadBean<TrialRankBean>(stream));
		}
	}
	
	/**
	 * get 一护试炼玩家积分排行榜
	 * @return 
	 */
	public List<TrialRankBean> GetIchigoTrialRankList()
	{
		return _ichigoTrialRankList;
	}
	
	/**
	 * set 一护试炼玩家积分排行榜
	 */
	public void SetIchigoTrialRankList(List<TrialRankBean> ichigoTrialRankList)
	{
		_ichigoTrialRankList = ichigoTrialRankList;
	}
	
	
	public override int GetId() 
	{
		return 825101;
	}
}