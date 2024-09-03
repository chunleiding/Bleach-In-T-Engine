using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 被膜拜的奖励信息 message
 */
public class ResGangWorshipPrizeMessage : Message 
{
	//奖励的合计被膜拜次数(不是当前领取的膜拜奖励的次数，且小于等于配置的最大值)
	int _worshipedNum;	
	//奖励的贡献度奖励值
	int _contribution;	
	//奖励的体力奖励值
	int _health;	
	//膜拜系统还可以增加的体力
	int _worshipSysCanAddMaxHealth;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//奖励的合计被膜拜次数(不是当前领取的膜拜奖励的次数，且小于等于配置的最大值)
		SerializeUtils.WriteInt(stream, _worshipedNum);
		//奖励的贡献度奖励值
		SerializeUtils.WriteInt(stream, _contribution);
		//奖励的体力奖励值
		SerializeUtils.WriteInt(stream, _health);
		//膜拜系统还可以增加的体力
		SerializeUtils.WriteInt(stream, _worshipSysCanAddMaxHealth);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//奖励的合计被膜拜次数(不是当前领取的膜拜奖励的次数，且小于等于配置的最大值)
		_worshipedNum = SerializeUtils.ReadInt(stream);
		//奖励的贡献度奖励值
		_contribution = SerializeUtils.ReadInt(stream);
		//奖励的体力奖励值
		_health = SerializeUtils.ReadInt(stream);
		//膜拜系统还可以增加的体力
		_worshipSysCanAddMaxHealth = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 奖励的合计被膜拜次数(不是当前领取的膜拜奖励的次数，且小于等于配置的最大值)
	 */
	public int WorshipedNum
	{
		set { _worshipedNum = value; }
	    get { return _worshipedNum; }
	}
	
	/**
	 * 奖励的贡献度奖励值
	 */
	public int Contribution
	{
		set { _contribution = value; }
	    get { return _contribution; }
	}
	
	/**
	 * 奖励的体力奖励值
	 */
	public int Health
	{
		set { _health = value; }
	    get { return _health; }
	}
	
	/**
	 * 膜拜系统还可以增加的体力
	 */
	public int WorshipSysCanAddMaxHealth
	{
		set { _worshipSysCanAddMaxHealth = value; }
	    get { return _worshipSysCanAddMaxHealth; }
	}
	
	
	public override int GetId() 
	{
		return 109121;
	}
}