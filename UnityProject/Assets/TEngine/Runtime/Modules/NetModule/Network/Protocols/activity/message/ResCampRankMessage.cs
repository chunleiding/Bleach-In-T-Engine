using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 活动排行榜 message
 */
public class ResCampRankMessage : Message 
{
	//排行榜类型
	int _rankType;	
	//排行榜列表
	List<CampRankInfo> _rankInfo = new List<CampRankInfo>();
	//结果（0：成功）
	int _result;	
	//自己的排名
	int _selfRank;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//排行榜类型
		SerializeUtils.WriteInt(stream, _rankType);
		//排行榜列表
		SerializeUtils.WriteShort(stream, (short)_rankInfo.Count);

		foreach (var element in _rankInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//结果（0：成功）
		SerializeUtils.WriteInt(stream, _result);
		//自己的排名
		SerializeUtils.WriteInt(stream, _selfRank);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//排行榜类型
		_rankType = SerializeUtils.ReadInt(stream);
		//排行榜列表
		int _rankInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _rankInfo_length; ++i) 
		{
			_rankInfo.Add(SerializeUtils.ReadBean<CampRankInfo>(stream));
		}
		//结果（0：成功）
		_result = SerializeUtils.ReadInt(stream);
		//自己的排名
		_selfRank = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 排行榜类型
	 */
	public int RankType
	{
		set { _rankType = value; }
	    get { return _rankType; }
	}
	
	/**
	 * get 排行榜列表
	 * @return 
	 */
	public List<CampRankInfo> GetRankInfo()
	{
		return _rankInfo;
	}
	
	/**
	 * set 排行榜列表
	 */
	public void SetRankInfo(List<CampRankInfo> rankInfo)
	{
		_rankInfo = rankInfo;
	}
	
	/**
	 * 结果（0：成功）
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * 自己的排名
	 */
	public int SelfRank
	{
		set { _selfRank = value; }
	    get { return _selfRank; }
	}
	
	
	public override int GetId() 
	{
		return 311211;
	}
}