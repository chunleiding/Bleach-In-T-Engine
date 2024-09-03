using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 世界boss战斗详情回馈 message
 */
public class ResWorldBossFightDataMessage : Message 
{
	//角色伤害list
	List<WorldBossFightData> _charactorDamages = new List<WorldBossFightData>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//角色伤害list
		SerializeUtils.WriteShort(stream, (short)_charactorDamages.Count);

		foreach (var element in _charactorDamages)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//角色伤害list
		int _charactorDamages_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _charactorDamages_length; ++i) 
		{
			_charactorDamages.Add(SerializeUtils.ReadBean<WorldBossFightData>(stream));
		}
	}
	
	/**
	 * get 角色伤害list
	 * @return 
	 */
	public List<WorldBossFightData> GetCharactorDamages()
	{
		return _charactorDamages;
	}
	
	/**
	 * set 角色伤害list
	 */
	public void SetCharactorDamages(List<WorldBossFightData> charactorDamages)
	{
		_charactorDamages = charactorDamages;
	}
	
	
	public override int GetId() 
	{
		return 807123;
	}
}