using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 战斗结束后发送结算面板消息 message
 */
public class ResFightResultMessage : Message 
{
	//榜单
	List<WorldBossRank> _rankList = new List<WorldBossRank>();
	//最后一击信息
	WorldBossRank _lastAtk;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//榜单
		SerializeUtils.WriteShort(stream, (short)_rankList.Count);

		foreach (var element in _rankList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//最后一击信息
		SerializeUtils.WriteBean(stream, _lastAtk);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//榜单
		int _rankList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _rankList_length; ++i) 
		{
			_rankList.Add(SerializeUtils.ReadBean<WorldBossRank>(stream));
		}
		//最后一击信息
		_lastAtk = SerializeUtils.ReadBean<WorldBossRank>(stream);
	}
	
	/**
	 * get 榜单
	 * @return 
	 */
	public List<WorldBossRank> GetRankList()
	{
		return _rankList;
	}
	
	/**
	 * set 榜单
	 */
	public void SetRankList(List<WorldBossRank> rankList)
	{
		_rankList = rankList;
	}
	
	/**
	 * 最后一击信息
	 */
	public WorldBossRank LastAtk
	{
		set { _lastAtk = value; }
	    get { return _lastAtk; }
	}
	
	
	public override int GetId() 
	{
		return 807121;
	}
}