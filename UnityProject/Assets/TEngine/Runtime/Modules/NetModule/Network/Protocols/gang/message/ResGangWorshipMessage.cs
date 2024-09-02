using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 膜拜信息 message
 */
public class ResGangWorshipMessage : Message 
{
	//膜拜玩家的id
	long _worshipPlayerId;	
	//膜拜增加的金钱
	int _money;	
	//膜拜增加的体力
	int _health;	
	//膜拜系统还可以增加的体力
	int _worshipSysCanAddMaxHealth;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//膜拜玩家的id
		SerializeUtils.WriteLong(stream, _worshipPlayerId);
		//膜拜增加的金钱
		SerializeUtils.WriteInt(stream, _money);
		//膜拜增加的体力
		SerializeUtils.WriteInt(stream, _health);
		//膜拜系统还可以增加的体力
		SerializeUtils.WriteInt(stream, _worshipSysCanAddMaxHealth);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//膜拜玩家的id
		_worshipPlayerId = SerializeUtils.ReadLong(stream);
		//膜拜增加的金钱
		_money = SerializeUtils.ReadInt(stream);
		//膜拜增加的体力
		_health = SerializeUtils.ReadInt(stream);
		//膜拜系统还可以增加的体力
		_worshipSysCanAddMaxHealth = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 膜拜玩家的id
	 */
	public long WorshipPlayerId
	{
		set { _worshipPlayerId = value; }
	    get { return _worshipPlayerId; }
	}
	
	/**
	 * 膜拜增加的金钱
	 */
	public int Money
	{
		set { _money = value; }
	    get { return _money; }
	}
	
	/**
	 * 膜拜增加的体力
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
		return 109110;
	}
}