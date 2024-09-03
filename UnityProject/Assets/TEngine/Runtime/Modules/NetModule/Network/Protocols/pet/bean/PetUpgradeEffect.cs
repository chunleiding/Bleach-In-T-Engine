using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 升级触发效果（1:技能格编号，2:激活技能id，3:升级技能i
 */
public class PetUpgradeEffect : IMessageSerialize 
{
	//1:技能格编号，2:激活技能id，3:升级技能id
	int _typeEffect;	
	//对应升级功能的id
	int _effectId;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//1:技能格编号，2:激活技能id，3:升级技能id
		SerializeUtils.WriteInt(stream, _typeEffect);
		//对应升级功能的id
		SerializeUtils.WriteInt(stream, _effectId);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//1:技能格编号，2:激活技能id，3:升级技能id
		_typeEffect = SerializeUtils.ReadInt(stream);
		//对应升级功能的id
		_effectId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 1:技能格编号，2:激活技能id，3:升级技能id
	 */
	public int TypeEffect
	{
		set { _typeEffect = value; }
	    get { return _typeEffect; }
	}
	
	/**
	 * 对应升级功能的id
	 */
	public int EffectId
	{
		set { _effectId = value; }
	    get { return _effectId; }
	}
	
}