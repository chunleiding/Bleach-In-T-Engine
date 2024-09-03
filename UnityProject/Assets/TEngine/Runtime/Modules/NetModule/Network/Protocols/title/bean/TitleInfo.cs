using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 称号信息
 */
public class TitleInfo : IMessageSerialize 
{
	//称号id
	int _titleId;	
	//称号大类型
	int _titleType;	
	//称号状态0.未激活1.激活2卸下3.佩戴
	int _state;	
	//当前进度
	int _curTitle;	
	//总共需要的进度
	int _totalRequire;	
	//标签id
	int _tagID;	
	//美术资源id
	int _resourceID;	
	//面板展示id
	int _showID;	
	//称号级别1.文字2.图片3.gif4.特效
	int _titleLevel;	
	//称号描述
	int _titleDes;	
	//特殊条件如道具id
	int _specialCondition;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//称号id
		SerializeUtils.WriteInt(stream, _titleId);
		//称号大类型
		SerializeUtils.WriteInt(stream, _titleType);
		//称号状态0.未激活1.激活2卸下3.佩戴
		SerializeUtils.WriteInt(stream, _state);
		//当前进度
		SerializeUtils.WriteInt(stream, _curTitle);
		//总共需要的进度
		SerializeUtils.WriteInt(stream, _totalRequire);
		//标签id
		SerializeUtils.WriteInt(stream, _tagID);
		//美术资源id
		SerializeUtils.WriteInt(stream, _resourceID);
		//面板展示id
		SerializeUtils.WriteInt(stream, _showID);
		//称号级别1.文字2.图片3.gif4.特效
		SerializeUtils.WriteInt(stream, _titleLevel);
		//称号描述
		SerializeUtils.WriteInt(stream, _titleDes);
		//特殊条件如道具id
		SerializeUtils.WriteInt(stream, _specialCondition);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//称号id
		_titleId = SerializeUtils.ReadInt(stream);
		//称号大类型
		_titleType = SerializeUtils.ReadInt(stream);
		//称号状态0.未激活1.激活2卸下3.佩戴
		_state = SerializeUtils.ReadInt(stream);
		//当前进度
		_curTitle = SerializeUtils.ReadInt(stream);
		//总共需要的进度
		_totalRequire = SerializeUtils.ReadInt(stream);
		//标签id
		_tagID = SerializeUtils.ReadInt(stream);
		//美术资源id
		_resourceID = SerializeUtils.ReadInt(stream);
		//面板展示id
		_showID = SerializeUtils.ReadInt(stream);
		//称号级别1.文字2.图片3.gif4.特效
		_titleLevel = SerializeUtils.ReadInt(stream);
		//称号描述
		_titleDes = SerializeUtils.ReadInt(stream);
		//特殊条件如道具id
		_specialCondition = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 称号id
	 */
	public int TitleId
	{
		set { _titleId = value; }
	    get { return _titleId; }
	}
	
	/**
	 * 称号大类型
	 */
	public int TitleType
	{
		set { _titleType = value; }
	    get { return _titleType; }
	}
	
	/**
	 * 称号状态0.未激活1.激活2卸下3.佩戴
	 */
	public int State
	{
		set { _state = value; }
	    get { return _state; }
	}
	
	/**
	 * 当前进度
	 */
	public int CurTitle
	{
		set { _curTitle = value; }
	    get { return _curTitle; }
	}
	
	/**
	 * 总共需要的进度
	 */
	public int TotalRequire
	{
		set { _totalRequire = value; }
	    get { return _totalRequire; }
	}
	
	/**
	 * 标签id
	 */
	public int TagID
	{
		set { _tagID = value; }
	    get { return _tagID; }
	}
	
	/**
	 * 美术资源id
	 */
	public int ResourceID
	{
		set { _resourceID = value; }
	    get { return _resourceID; }
	}
	
	/**
	 * 面板展示id
	 */
	public int ShowID
	{
		set { _showID = value; }
	    get { return _showID; }
	}
	
	/**
	 * 称号级别1.文字2.图片3.gif4.特效
	 */
	public int TitleLevel
	{
		set { _titleLevel = value; }
	    get { return _titleLevel; }
	}
	
	/**
	 * 称号描述
	 */
	public int TitleDes
	{
		set { _titleDes = value; }
	    get { return _titleDes; }
	}
	
	/**
	 * 特殊条件如道具id
	 */
	public int SpecialCondition
	{
		set { _specialCondition = value; }
	    get { return _specialCondition; }
	}
	
}