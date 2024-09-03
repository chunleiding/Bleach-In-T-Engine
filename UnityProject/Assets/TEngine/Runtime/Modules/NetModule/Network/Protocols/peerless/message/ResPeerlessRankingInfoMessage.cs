using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 回复无双死神排行榜信息 message
 */
public class ResPeerlessRankingInfoMessage : Message 
{
	//排行榜信息
	List<TopArenaRankingInfo> _rankingInfo = new List<TopArenaRankingInfo>();
	//自己的排名
	int _myselfRank;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//排行榜信息
		SerializeUtils.WriteShort(stream, (short)_rankingInfo.Count);

		foreach (var element in _rankingInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//自己的排名
		SerializeUtils.WriteInt(stream, _myselfRank);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//排行榜信息
		int _rankingInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _rankingInfo_length; ++i) 
		{
			_rankingInfo.Add(SerializeUtils.ReadBean<TopArenaRankingInfo>(stream));
		}
		//自己的排名
		_myselfRank = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * get 排行榜信息
	 * @return 
	 */
	public List<TopArenaRankingInfo> GetRankingInfo()
	{
		return _rankingInfo;
	}
	
	/**
	 * set 排行榜信息
	 */
	public void SetRankingInfo(List<TopArenaRankingInfo> rankingInfo)
	{
		_rankingInfo = rankingInfo;
	}
	
	/**
	 * 自己的排名
	 */
	public int MyselfRank
	{
		set { _myselfRank = value; }
	    get { return _myselfRank; }
	}
	
	
	public override int GetId() 
	{
		return 817110;
	}
}