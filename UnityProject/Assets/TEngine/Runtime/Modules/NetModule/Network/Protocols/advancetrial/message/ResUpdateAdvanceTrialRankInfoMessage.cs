using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 灵力修炼最高纪录排名信息刷新 message
 */
public class ResUpdateAdvanceTrialRankInfoMessage : Message 
{
	//灵力修炼最高纪录排名信息
	AdvanceTrialRankInfo _rankInfos;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//灵力修炼最高纪录排名信息
		SerializeUtils.WriteBean(stream, _rankInfos);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//灵力修炼最高纪录排名信息
		_rankInfos = SerializeUtils.ReadBean<AdvanceTrialRankInfo>(stream);
	}
	
	/**
	 * 灵力修炼最高纪录排名信息
	 */
	public AdvanceTrialRankInfo RankInfos
	{
		set { _rankInfos = value; }
	    get { return _rankInfos; }
	}
	
	
	public override int GetId() 
	{
		return 224106;
	}
}