using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 宠物猪单个配置
 */
public class PetBoniInfo : IMessageSerialize 
{
	//宠物猪等级id
	int _petId;	
	//宠物猪资源id
	int _petTexture;	
	//升至下级所需经验
	int _petNeedExprience;	
	//升级触发效果bean
	List<PetUpgradeEffect> _upgradeEffect = new List<PetUpgradeEffect>();
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//宠物猪等级id
		SerializeUtils.WriteInt(stream, _petId);
		//宠物猪资源id
		SerializeUtils.WriteInt(stream, _petTexture);
		//升至下级所需经验
		SerializeUtils.WriteInt(stream, _petNeedExprience);
		//升级触发效果bean
		SerializeUtils.WriteShort(stream, (short)_upgradeEffect.Count);

		foreach (var element in _upgradeEffect)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//宠物猪等级id
		_petId = SerializeUtils.ReadInt(stream);
		//宠物猪资源id
		_petTexture = SerializeUtils.ReadInt(stream);
		//升至下级所需经验
		_petNeedExprience = SerializeUtils.ReadInt(stream);
		//升级触发效果bean
		int _upgradeEffect_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _upgradeEffect_length; ++i) 
		{
			_upgradeEffect.Add(SerializeUtils.ReadBean<PetUpgradeEffect>(stream));
		}
	}
	
	/**
	 * 宠物猪等级id
	 */
	public int PetId
	{
		set { _petId = value; }
	    get { return _petId; }
	}
	
	/**
	 * 宠物猪资源id
	 */
	public int PetTexture
	{
		set { _petTexture = value; }
	    get { return _petTexture; }
	}
	
	/**
	 * 升至下级所需经验
	 */
	public int PetNeedExprience
	{
		set { _petNeedExprience = value; }
	    get { return _petNeedExprience; }
	}
	
	/**
	 * get 升级触发效果bean
	 * @return 
	 */
	public List<PetUpgradeEffect> GetUpgradeEffect()
	{
		return _upgradeEffect;
	}
	
	/**
	 * set 升级触发效果bean
	 */
	public void SetUpgradeEffect(List<PetUpgradeEffect> upgradeEffect)
	{
		_upgradeEffect = upgradeEffect;
	}
	
}