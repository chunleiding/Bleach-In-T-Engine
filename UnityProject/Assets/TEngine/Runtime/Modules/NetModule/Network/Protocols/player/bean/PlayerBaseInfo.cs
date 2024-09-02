using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 角色基础数据
 */
public class PlayerBaseInfo : IMessageSerialize 
{
	//账号id
	long _accountId;	
	//玩家id
	long _playerId;	
	//服务器id
	int _serverId;	
	//玩家名字
	string _playerName;	
	//玩家等级
	int _playerLevel;	
	//充值的总魂玉数
	int _charge;	
	//vip等级
	int _vipLevel;	
	//经验
	int _exp;	
	//游戏币
	int _gold;	
	//魂玉
	int _soul;	
	//体力
	int _health;	
	//竞技场点数
	int _arenaPoint;	
	//试炼点数
	int _trialPoint;	
	//番队贡献值
	int _gangContribution;	
	//地狱蝶数量
	int _butterflyCount;	
	//技能点
	int _skillPoint;	
	//星星数量
	int _star;	
	//排行榜点数
	int _rankPoint;	
	//百万招财积分
	int _millionScore;	
	//世界boss积分
	int _worldBossScore;	
	//一护试炼积分
	int _ichigoCurrency;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//账号id
		SerializeUtils.WriteLong(stream, _accountId);
		//玩家id
		SerializeUtils.WriteLong(stream, _playerId);
		//服务器id
		SerializeUtils.WriteInt(stream, _serverId);
		//玩家名字
		SerializeUtils.WriteString(stream, _playerName);
		//玩家等级
		SerializeUtils.WriteInt(stream, _playerLevel);
		//充值的总魂玉数
		SerializeUtils.WriteInt(stream, _charge);
		//vip等级
		SerializeUtils.WriteInt(stream, _vipLevel);
		//经验
		SerializeUtils.WriteInt(stream, _exp);
		//游戏币
		SerializeUtils.WriteInt(stream, _gold);
		//魂玉
		SerializeUtils.WriteInt(stream, _soul);
		//体力
		SerializeUtils.WriteInt(stream, _health);
		//竞技场点数
		SerializeUtils.WriteInt(stream, _arenaPoint);
		//试炼点数
		SerializeUtils.WriteInt(stream, _trialPoint);
		//番队贡献值
		SerializeUtils.WriteInt(stream, _gangContribution);
		//地狱蝶数量
		SerializeUtils.WriteInt(stream, _butterflyCount);
		//技能点
		SerializeUtils.WriteInt(stream, _skillPoint);
		//星星数量
		SerializeUtils.WriteInt(stream, _star);
		//排行榜点数
		SerializeUtils.WriteInt(stream, _rankPoint);
		//百万招财积分
		SerializeUtils.WriteInt(stream, _millionScore);
		//世界boss积分
		SerializeUtils.WriteInt(stream, _worldBossScore);
		//一护试炼积分
		SerializeUtils.WriteInt(stream, _ichigoCurrency);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//账号id
		_accountId = SerializeUtils.ReadLong(stream);
		//玩家id
		_playerId = SerializeUtils.ReadLong(stream);
		//服务器id
		_serverId = SerializeUtils.ReadInt(stream);
		//玩家名字
		_playerName = SerializeUtils.ReadString(stream);
		//玩家等级
		_playerLevel = SerializeUtils.ReadInt(stream);
		//充值的总魂玉数
		_charge = SerializeUtils.ReadInt(stream);
		//vip等级
		_vipLevel = SerializeUtils.ReadInt(stream);
		//经验
		_exp = SerializeUtils.ReadInt(stream);
		//游戏币
		_gold = SerializeUtils.ReadInt(stream);
		//魂玉
		_soul = SerializeUtils.ReadInt(stream);
		//体力
		_health = SerializeUtils.ReadInt(stream);
		//竞技场点数
		_arenaPoint = SerializeUtils.ReadInt(stream);
		//试炼点数
		_trialPoint = SerializeUtils.ReadInt(stream);
		//番队贡献值
		_gangContribution = SerializeUtils.ReadInt(stream);
		//地狱蝶数量
		_butterflyCount = SerializeUtils.ReadInt(stream);
		//技能点
		_skillPoint = SerializeUtils.ReadInt(stream);
		//星星数量
		_star = SerializeUtils.ReadInt(stream);
		//排行榜点数
		_rankPoint = SerializeUtils.ReadInt(stream);
		//百万招财积分
		_millionScore = SerializeUtils.ReadInt(stream);
		//世界boss积分
		_worldBossScore = SerializeUtils.ReadInt(stream);
		//一护试炼积分
		_ichigoCurrency = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 账号id
	 */
	public long AccountId
	{
		set { _accountId = value; }
	    get { return _accountId; }
	}
	
	/**
	 * 玩家id
	 */
	public long PlayerId
	{
		set { _playerId = value; }
	    get { return _playerId; }
	}
	
	/**
	 * 服务器id
	 */
	public int ServerId
	{
		set { _serverId = value; }
	    get { return _serverId; }
	}
	
	/**
	 * 玩家名字
	 */
	public string PlayerName
	{
		set { _playerName = value; }
	    get { return _playerName; }
	}
	
	/**
	 * 玩家等级
	 */
	public int PlayerLevel
	{
		set { _playerLevel = value; }
	    get { return _playerLevel; }
	}
	
	/**
	 * 充值的总魂玉数
	 */
	public int Charge
	{
		set { _charge = value; }
	    get { return _charge; }
	}
	
	/**
	 * vip等级
	 */
	public int VipLevel
	{
		set { _vipLevel = value; }
	    get { return _vipLevel; }
	}
	
	/**
	 * 经验
	 */
	public int Exp
	{
		set { _exp = value; }
	    get { return _exp; }
	}
	
	/**
	 * 游戏币
	 */
	public int Gold
	{
		set { _gold = value; }
	    get { return _gold; }
	}
	
	/**
	 * 魂玉
	 */
	public int Soul
	{
		set { _soul = value; }
	    get { return _soul; }
	}
	
	/**
	 * 体力
	 */
	public int Health
	{
		set { _health = value; }
	    get { return _health; }
	}
	
	/**
	 * 竞技场点数
	 */
	public int ArenaPoint
	{
		set { _arenaPoint = value; }
	    get { return _arenaPoint; }
	}
	
	/**
	 * 试炼点数
	 */
	public int TrialPoint
	{
		set { _trialPoint = value; }
	    get { return _trialPoint; }
	}
	
	/**
	 * 番队贡献值
	 */
	public int GangContribution
	{
		set { _gangContribution = value; }
	    get { return _gangContribution; }
	}
	
	/**
	 * 地狱蝶数量
	 */
	public int ButterflyCount
	{
		set { _butterflyCount = value; }
	    get { return _butterflyCount; }
	}
	
	/**
	 * 技能点
	 */
	public int SkillPoint
	{
		set { _skillPoint = value; }
	    get { return _skillPoint; }
	}
	
	/**
	 * 星星数量
	 */
	public int Star
	{
		set { _star = value; }
	    get { return _star; }
	}
	
	/**
	 * 排行榜点数
	 */
	public int RankPoint
	{
		set { _rankPoint = value; }
	    get { return _rankPoint; }
	}
	
	/**
	 * 百万招财积分
	 */
	public int MillionScore
	{
		set { _millionScore = value; }
	    get { return _millionScore; }
	}
	
	/**
	 * 世界boss积分
	 */
	public int WorldBossScore
	{
		set { _worldBossScore = value; }
	    get { return _worldBossScore; }
	}
	
	/**
	 * 一护试炼积分
	 */
	public int IchigoCurrency
	{
		set { _ichigoCurrency = value; }
	    get { return _ichigoCurrency; }
	}
	
}