using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队助战角色信息
 */
public class GangSupportCharacterInfo : IMessageSerialize 
{
	//玩家id
	long _playerId;	
	//基础信息
	CharacterSyncInfo _baseInfo;	
	//属性
	AttributeInfo _attribute;	
	//灵魂能力
	SoulAbilityInfo _soulAbilityInfo;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//玩家id
		SerializeUtils.WriteLong(stream, _playerId);
		//基础信息
		SerializeUtils.WriteBean(stream, _baseInfo);
		//属性
		SerializeUtils.WriteBean(stream, _attribute);
		//灵魂能力
		SerializeUtils.WriteBean(stream, _soulAbilityInfo);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//玩家id
		_playerId = SerializeUtils.ReadLong(stream);
		//基础信息
		_baseInfo = SerializeUtils.ReadBean<CharacterSyncInfo>(stream);
		//属性
		_attribute = SerializeUtils.ReadBean<AttributeInfo>(stream);
		//灵魂能力
		_soulAbilityInfo = SerializeUtils.ReadBean<SoulAbilityInfo>(stream);
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
	 * 基础信息
	 */
	public CharacterSyncInfo BaseInfo
	{
		set { _baseInfo = value; }
	    get { return _baseInfo; }
	}
	
	/**
	 * 属性
	 */
	public AttributeInfo Attribute
	{
		set { _attribute = value; }
	    get { return _attribute; }
	}
	
	/**
	 * 灵魂能力
	 */
	public SoulAbilityInfo SoulAbilityInfo
	{
		set { _soulAbilityInfo = value; }
	    get { return _soulAbilityInfo; }
	}
	
}