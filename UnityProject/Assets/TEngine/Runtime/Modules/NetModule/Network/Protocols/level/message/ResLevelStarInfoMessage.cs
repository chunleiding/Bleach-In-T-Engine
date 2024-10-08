using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 返回通关星级信息 message
 */
public class ResLevelStarInfoMessage : Message 
{
	//通关星级信息
	LevelStarInfo _levelStarInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//通关星级信息
		SerializeUtils.WriteBean(stream, _levelStarInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//通关星级信息
		_levelStarInfo = SerializeUtils.ReadBean<LevelStarInfo>(stream);
	}
	
	/**
	 * 通关星级信息
	 */
	public LevelStarInfo LevelStarInfo
	{
		set { _levelStarInfo = value; }
	    get { return _levelStarInfo; }
	}
	
	
	public override int GetId() 
	{
		return 102104;
	}
}