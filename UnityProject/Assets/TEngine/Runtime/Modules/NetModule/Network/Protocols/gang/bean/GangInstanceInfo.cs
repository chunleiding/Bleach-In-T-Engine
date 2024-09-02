using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 副本信息
 */
public class GangInstanceInfo : IMessageSerialize 
{
	//副本id
	int _instanceId;	
	//当前boss剩余的血量
	int _hp;	
	//还有多少秒重置
	int _resetSec;	
	//伤害排名信息
	List<GangInstanceDamageInfo> _damageInfos = new List<GangInstanceDamageInfo>();
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//副本id
		SerializeUtils.WriteInt(stream, _instanceId);
		//当前boss剩余的血量
		SerializeUtils.WriteInt(stream, _hp);
		//还有多少秒重置
		SerializeUtils.WriteInt(stream, _resetSec);
		//伤害排名信息
		SerializeUtils.WriteShort(stream, (short)_damageInfos.Count);

		foreach (var element in _damageInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//副本id
		_instanceId = SerializeUtils.ReadInt(stream);
		//当前boss剩余的血量
		_hp = SerializeUtils.ReadInt(stream);
		//还有多少秒重置
		_resetSec = SerializeUtils.ReadInt(stream);
		//伤害排名信息
		int _damageInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _damageInfos_length; ++i) 
		{
			_damageInfos.Add(SerializeUtils.ReadBean<GangInstanceDamageInfo>(stream));
		}
	}
	
	/**
	 * 副本id
	 */
	public int InstanceId
	{
		set { _instanceId = value; }
	    get { return _instanceId; }
	}
	
	/**
	 * 当前boss剩余的血量
	 */
	public int Hp
	{
		set { _hp = value; }
	    get { return _hp; }
	}
	
	/**
	 * 还有多少秒重置
	 */
	public int ResetSec
	{
		set { _resetSec = value; }
	    get { return _resetSec; }
	}
	
	/**
	 * get 伤害排名信息
	 * @return 
	 */
	public List<GangInstanceDamageInfo> GetDamageInfos()
	{
		return _damageInfos;
	}
	
	/**
	 * set 伤害排名信息
	 */
	public void SetDamageInfos(List<GangInstanceDamageInfo> damageInfos)
	{
		_damageInfos = damageInfos;
	}
	
}