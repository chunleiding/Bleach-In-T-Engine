using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 世界Boss实时排行榜 message
 */
public class ResWorldBossRankInfoMessage : Message 
{
	//排行榜列表
	List<WorldBossRank> _rankList = new List<WorldBossRank>();
	//自己的排行信息
	WorldBossRank _myRank;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//排行榜列表
		SerializeUtils.WriteShort(stream, (short)_rankList.Count);

		foreach (var element in _rankList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//自己的排行信息
		SerializeUtils.WriteBean(stream, _myRank);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//排行榜列表
		int _rankList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _rankList_length; ++i) 
		{
			_rankList.Add(SerializeUtils.ReadBean<WorldBossRank>(stream));
		}
		//自己的排行信息
		_myRank = SerializeUtils.ReadBean<WorldBossRank>(stream);
	}
	
	/**
	 * get 排行榜列表
	 * @return 
	 */
	public List<WorldBossRank> GetRankList()
	{
		return _rankList;
	}
	
	/**
	 * set 排行榜列表
	 */
	public void SetRankList(List<WorldBossRank> rankList)
	{
		_rankList = rankList;
	}
	
	/**
	 * 自己的排行信息
	 */
	public WorldBossRank MyRank
	{
		set { _myRank = value; }
	    get { return _myRank; }
	}
	
	
	public override int GetId() 
	{
		return 807117;
	}
}