using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 单条称号刷新 message
 */
public class ResTitleInfoMessage : Message 
{
	//单条称号信息
	TitleInfo _titleInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//单条称号信息
		SerializeUtils.WriteBean(stream, _titleInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//单条称号信息
		_titleInfo = SerializeUtils.ReadBean<TitleInfo>(stream);
	}
	
	/**
	 * 单条称号信息
	 */
	public TitleInfo TitleInfo
	{
		set { _titleInfo = value; }
	    get { return _titleInfo; }
	}
	
	
	public override int GetId() 
	{
		return 827106;
	}
}