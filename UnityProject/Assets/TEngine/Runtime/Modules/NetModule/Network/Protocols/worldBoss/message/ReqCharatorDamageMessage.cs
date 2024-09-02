using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 每秒上报自身造成伤害以及自身血量剩余 message
 */
public class ReqCharatorDamageMessage : Message 
{
	//角色id
	int _charatorId;	
	//自身剩余血量
	int _hpLeft;	
	//对boss造成的伤害扣血量
	int _bossHurt;	
	//角色基础攻击
	int _atk;	
	//角色基础防御
	int _def;	
	//角色基础耐力
	int _sta;	
	//角色基础暴击
	int _crit;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//角色id
		SerializeUtils.WriteInt(stream, _charatorId);
		//自身剩余血量
		SerializeUtils.WriteInt(stream, _hpLeft);
		//对boss造成的伤害扣血量
		SerializeUtils.WriteInt(stream, _bossHurt);
		//角色基础攻击
		SerializeUtils.WriteInt(stream, _atk);
		//角色基础防御
		SerializeUtils.WriteInt(stream, _def);
		//角色基础耐力
		SerializeUtils.WriteInt(stream, _sta);
		//角色基础暴击
		SerializeUtils.WriteInt(stream, _crit);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//角色id
		_charatorId = SerializeUtils.ReadInt(stream);
		//自身剩余血量
		_hpLeft = SerializeUtils.ReadInt(stream);
		//对boss造成的伤害扣血量
		_bossHurt = SerializeUtils.ReadInt(stream);
		//角色基础攻击
		_atk = SerializeUtils.ReadInt(stream);
		//角色基础防御
		_def = SerializeUtils.ReadInt(stream);
		//角色基础耐力
		_sta = SerializeUtils.ReadInt(stream);
		//角色基础暴击
		_crit = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 角色id
	 */
	public int CharatorId
	{
		set { _charatorId = value; }
	    get { return _charatorId; }
	}
	
	/**
	 * 自身剩余血量
	 */
	public int HpLeft
	{
		set { _hpLeft = value; }
	    get { return _hpLeft; }
	}
	
	/**
	 * 对boss造成的伤害扣血量
	 */
	public int BossHurt
	{
		set { _bossHurt = value; }
	    get { return _bossHurt; }
	}
	
	/**
	 * 角色基础攻击
	 */
	public int Atk
	{
		set { _atk = value; }
	    get { return _atk; }
	}
	
	/**
	 * 角色基础防御
	 */
	public int Def
	{
		set { _def = value; }
	    get { return _def; }
	}
	
	/**
	 * 角色基础耐力
	 */
	public int Sta
	{
		set { _sta = value; }
	    get { return _sta; }
	}
	
	/**
	 * 角色基础暴击
	 */
	public int Crit
	{
		set { _crit = value; }
	    get { return _crit; }
	}
	
	
	public override int GetId() 
	{
		return 807119;
	}
}