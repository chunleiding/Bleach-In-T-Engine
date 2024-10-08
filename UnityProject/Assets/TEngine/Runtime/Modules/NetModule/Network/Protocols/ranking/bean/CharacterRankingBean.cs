using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 角色排行榜
 */
public class CharacterRankingBean : IMessageSerialize 
{
	//角色id
	int _characterId;	
	//出场次数
	int _fightTime;	
	//出场率
	int _fightTimeRatio;	
	//胜率
	int _winRatio;	
	//与上次排行的名次差
	int _deltaRank;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//角色id
		SerializeUtils.WriteInt(stream, _characterId);
		//出场次数
		SerializeUtils.WriteInt(stream, _fightTime);
		//出场率
		SerializeUtils.WriteInt(stream, _fightTimeRatio);
		//胜率
		SerializeUtils.WriteInt(stream, _winRatio);
		//与上次排行的名次差
		SerializeUtils.WriteInt(stream, _deltaRank);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//角色id
		_characterId = SerializeUtils.ReadInt(stream);
		//出场次数
		_fightTime = SerializeUtils.ReadInt(stream);
		//出场率
		_fightTimeRatio = SerializeUtils.ReadInt(stream);
		//胜率
		_winRatio = SerializeUtils.ReadInt(stream);
		//与上次排行的名次差
		_deltaRank = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 角色id
	 */
	public int CharacterId
	{
		set { _characterId = value; }
	    get { return _characterId; }
	}
	
	/**
	 * 出场次数
	 */
	public int FightTime
	{
		set { _fightTime = value; }
	    get { return _fightTime; }
	}
	
	/**
	 * 出场率
	 */
	public int FightTimeRatio
	{
		set { _fightTimeRatio = value; }
	    get { return _fightTimeRatio; }
	}
	
	/**
	 * 胜率
	 */
	public int WinRatio
	{
		set { _winRatio = value; }
	    get { return _winRatio; }
	}
	
	/**
	 * 与上次排行的名次差
	 */
	public int DeltaRank
	{
		set { _deltaRank = value; }
	    get { return _deltaRank; }
	}
	
}