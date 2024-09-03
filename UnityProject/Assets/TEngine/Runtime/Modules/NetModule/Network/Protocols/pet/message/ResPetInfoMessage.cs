using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 宠物等级 经验 饱食度 数据 message
 */
public class ResPetInfoMessage : Message 
{
	//宠物经验 饱食度 等级数据
	PetDataInfo _petData;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//宠物经验 饱食度 等级数据
		SerializeUtils.WriteBean(stream, _petData);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//宠物经验 饱食度 等级数据
		_petData = SerializeUtils.ReadBean<PetDataInfo>(stream);
	}
	
	/**
	 * 宠物经验 饱食度 等级数据
	 */
	public PetDataInfo PetData
	{
		set { _petData = value; }
	    get { return _petData; }
	}
	
	
	public override int GetId() 
	{
		return 822102;
	}
}