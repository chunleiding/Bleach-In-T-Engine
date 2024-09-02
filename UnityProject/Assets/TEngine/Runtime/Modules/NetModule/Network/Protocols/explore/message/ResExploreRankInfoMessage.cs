using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 副本群排行榜信息 message
 */
public class ResExploreRankInfoMessage : Message 
{
	//玩家通关排行榜
	List<ExploreRankBean> _exploreRankList = new List<ExploreRankBean>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//玩家通关排行榜
		SerializeUtils.WriteShort(stream, (short)_exploreRankList.Count);

		foreach (var element in _exploreRankList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//玩家通关排行榜
		int _exploreRankList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _exploreRankList_length; ++i) 
		{
			_exploreRankList.Add(SerializeUtils.ReadBean<ExploreRankBean>(stream));
		}
	}
	
	/**
	 * get 玩家通关排行榜
	 * @return 
	 */
	public List<ExploreRankBean> GetExploreRankList()
	{
		return _exploreRankList;
	}
	
	/**
	 * set 玩家通关排行榜
	 */
	public void SetExploreRankList(List<ExploreRankBean> exploreRankList)
	{
		_exploreRankList = exploreRankList;
	}
	
	
	public override int GetId() 
	{
		return 831103;
	}
}