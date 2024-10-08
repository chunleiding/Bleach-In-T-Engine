using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 竞技场被挑战纪录
 */
public class ArenaDefendInfo : IMessageSerialize 
{
	//防守纪录id
	long _defendId;	
	//0：负，1：胜
	int _isWin;	
	//对手名字
	string _playerName;	
	//对手角色列表
	List<ArenaFightCharacterInfo> _oppoCharacterInfos = new List<ArenaFightCharacterInfo>();
	//原来的排名
	int _oldRank;	
	//现在的排名
	int _newRank;	
	//发生时间，0：一分钟内，其他：几分钟前
	int _fightTime;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//防守纪录id
		SerializeUtils.WriteLong(stream, _defendId);
		//0：负，1：胜
		SerializeUtils.WriteInt(stream, _isWin);
		//对手名字
		SerializeUtils.WriteString(stream, _playerName);
		//对手角色列表
		SerializeUtils.WriteShort(stream, (short)_oppoCharacterInfos.Count);

		foreach (var element in _oppoCharacterInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//原来的排名
		SerializeUtils.WriteInt(stream, _oldRank);
		//现在的排名
		SerializeUtils.WriteInt(stream, _newRank);
		//发生时间，0：一分钟内，其他：几分钟前
		SerializeUtils.WriteInt(stream, _fightTime);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//防守纪录id
		_defendId = SerializeUtils.ReadLong(stream);
		//0：负，1：胜
		_isWin = SerializeUtils.ReadInt(stream);
		//对手名字
		_playerName = SerializeUtils.ReadString(stream);
		//对手角色列表
		int _oppoCharacterInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _oppoCharacterInfos_length; ++i) 
		{
			_oppoCharacterInfos.Add(SerializeUtils.ReadBean<ArenaFightCharacterInfo>(stream));
		}
		//原来的排名
		_oldRank = SerializeUtils.ReadInt(stream);
		//现在的排名
		_newRank = SerializeUtils.ReadInt(stream);
		//发生时间，0：一分钟内，其他：几分钟前
		_fightTime = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 防守纪录id
	 */
	public long DefendId
	{
		set { _defendId = value; }
	    get { return _defendId; }
	}
	
	/**
	 * 0：负，1：胜
	 */
	public int IsWin
	{
		set { _isWin = value; }
	    get { return _isWin; }
	}
	
	/**
	 * 对手名字
	 */
	public string PlayerName
	{
		set { _playerName = value; }
	    get { return _playerName; }
	}
	
	/**
	 * get 对手角色列表
	 * @return 
	 */
	public List<ArenaFightCharacterInfo> GetOppoCharacterInfos()
	{
		return _oppoCharacterInfos;
	}
	
	/**
	 * set 对手角色列表
	 */
	public void SetOppoCharacterInfos(List<ArenaFightCharacterInfo> oppoCharacterInfos)
	{
		_oppoCharacterInfos = oppoCharacterInfos;
	}
	
	/**
	 * 原来的排名
	 */
	public int OldRank
	{
		set { _oldRank = value; }
	    get { return _oldRank; }
	}
	
	/**
	 * 现在的排名
	 */
	public int NewRank
	{
		set { _newRank = value; }
	    get { return _newRank; }
	}
	
	/**
	 * 发生时间，0：一分钟内，其他：几分钟前
	 */
	public int FightTime
	{
		set { _fightTime = value; }
	    get { return _fightTime; }
	}
	
}