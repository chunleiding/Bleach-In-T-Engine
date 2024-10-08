using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 巅峰竞技场信息
 */
public class TopArenaInfo : IMessageSerialize 
{
	//段位
	int _grade;	
	//上一个对手积分
	int _oldScore;	
	//积分
	int _score;	
	//战斗总次数
	int _fightTimes;	
	//胜利次数
	int _winTimes;	
	//当日胜利次数
	int _winTimesToday;	
	//当日胜利次数奖励是否领取，0未领 1已领
	int _rewardToday;	
	//使用过的角色Id
	List<int> _usedCharacterIds = new List<int>();
	//是否有对手，0:没有，1：有
	int _hasOpponent;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//段位
		SerializeUtils.WriteInt(stream, _grade);
		//上一个对手积分
		SerializeUtils.WriteInt(stream, _oldScore);
		//积分
		SerializeUtils.WriteInt(stream, _score);
		//战斗总次数
		SerializeUtils.WriteInt(stream, _fightTimes);
		//胜利次数
		SerializeUtils.WriteInt(stream, _winTimes);
		//当日胜利次数
		SerializeUtils.WriteInt(stream, _winTimesToday);
		//当日胜利次数奖励是否领取，0未领 1已领
		SerializeUtils.WriteInt(stream, _rewardToday);
		//使用过的角色Id
		SerializeUtils.WriteShort(stream, (short)_usedCharacterIds.Count);

		foreach (var element in _usedCharacterIds)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
		//是否有对手，0:没有，1：有
		SerializeUtils.WriteInt(stream, _hasOpponent);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//段位
		_grade = SerializeUtils.ReadInt(stream);
		//上一个对手积分
		_oldScore = SerializeUtils.ReadInt(stream);
		//积分
		_score = SerializeUtils.ReadInt(stream);
		//战斗总次数
		_fightTimes = SerializeUtils.ReadInt(stream);
		//胜利次数
		_winTimes = SerializeUtils.ReadInt(stream);
		//当日胜利次数
		_winTimesToday = SerializeUtils.ReadInt(stream);
		//当日胜利次数奖励是否领取，0未领 1已领
		_rewardToday = SerializeUtils.ReadInt(stream);
		//使用过的角色Id
		int _usedCharacterIds_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _usedCharacterIds_length; ++i) 
		{
			_usedCharacterIds.Add(SerializeUtils.ReadInt(stream));
		}
		//是否有对手，0:没有，1：有
		_hasOpponent = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 段位
	 */
	public int Grade
	{
		set { _grade = value; }
	    get { return _grade; }
	}
	
	/**
	 * 上一个对手积分
	 */
	public int OldScore
	{
		set { _oldScore = value; }
	    get { return _oldScore; }
	}
	
	/**
	 * 积分
	 */
	public int Score
	{
		set { _score = value; }
	    get { return _score; }
	}
	
	/**
	 * 战斗总次数
	 */
	public int FightTimes
	{
		set { _fightTimes = value; }
	    get { return _fightTimes; }
	}
	
	/**
	 * 胜利次数
	 */
	public int WinTimes
	{
		set { _winTimes = value; }
	    get { return _winTimes; }
	}
	
	/**
	 * 当日胜利次数
	 */
	public int WinTimesToday
	{
		set { _winTimesToday = value; }
	    get { return _winTimesToday; }
	}
	
	/**
	 * 当日胜利次数奖励是否领取，0未领 1已领
	 */
	public int RewardToday
	{
		set { _rewardToday = value; }
	    get { return _rewardToday; }
	}
	
	/**
	 * get 使用过的角色Id
	 * @return 
	 */
	public List<int> GetUsedCharacterIds()
	{
		return _usedCharacterIds;
	}
	
	/**
	 * set 使用过的角色Id
	 */
	public void SetUsedCharacterIds(List<int> usedCharacterIds)
	{
		_usedCharacterIds = usedCharacterIds;
	}
	
	/**
	 * 是否有对手，0:没有，1：有
	 */
	public int HasOpponent
	{
		set { _hasOpponent = value; }
	    get { return _hasOpponent; }
	}
	
}