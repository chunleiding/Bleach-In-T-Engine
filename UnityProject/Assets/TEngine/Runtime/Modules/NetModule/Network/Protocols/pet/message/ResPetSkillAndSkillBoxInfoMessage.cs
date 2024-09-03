using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 玩家当前技能格和技能数据 message
 */
public class ResPetSkillAndSkillBoxInfoMessage : Message 
{
	//技能格数据列表
	List<SkiiBoxInfo> _skillBox = new List<SkiiBoxInfo>();
	//技能数据列表
	List<PetSkillInfo> _skillInfo = new List<PetSkillInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//技能格数据列表
		SerializeUtils.WriteShort(stream, (short)_skillBox.Count);

		foreach (var element in _skillBox)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//技能数据列表
		SerializeUtils.WriteShort(stream, (short)_skillInfo.Count);

		foreach (var element in _skillInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//技能格数据列表
		int _skillBox_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _skillBox_length; ++i) 
		{
			_skillBox.Add(SerializeUtils.ReadBean<SkiiBoxInfo>(stream));
		}
		//技能数据列表
		int _skillInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _skillInfo_length; ++i) 
		{
			_skillInfo.Add(SerializeUtils.ReadBean<PetSkillInfo>(stream));
		}
	}
	
	/**
	 * get 技能格数据列表
	 * @return 
	 */
	public List<SkiiBoxInfo> GetSkillBox()
	{
		return _skillBox;
	}
	
	/**
	 * set 技能格数据列表
	 */
	public void SetSkillBox(List<SkiiBoxInfo> skillBox)
	{
		_skillBox = skillBox;
	}
	
	/**
	 * get 技能数据列表
	 * @return 
	 */
	public List<PetSkillInfo> GetSkillInfo()
	{
		return _skillInfo;
	}
	
	/**
	 * set 技能数据列表
	 */
	public void SetSkillInfo(List<PetSkillInfo> skillInfo)
	{
		_skillInfo = skillInfo;
	}
	
	
	public override int GetId() 
	{
		return 822101;
	}
}