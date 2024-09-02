using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 称号等级对应已激活的数量
 */
public class TitleLevelInfo : IMessageSerialize 
{
	//称号等级:1文字称号;2图片称号;3:动图称号;4:特效称号
	int _level;	
	//对应的已激活数量
	int _activateNum;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//称号等级:1文字称号;2图片称号;3:动图称号;4:特效称号
		SerializeUtils.WriteInt(stream, _level);
		//对应的已激活数量
		SerializeUtils.WriteInt(stream, _activateNum);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//称号等级:1文字称号;2图片称号;3:动图称号;4:特效称号
		_level = SerializeUtils.ReadInt(stream);
		//对应的已激活数量
		_activateNum = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 称号等级:1文字称号;2图片称号;3:动图称号;4:特效称号
	 */
	public int Level
	{
		set { _level = value; }
	    get { return _level; }
	}
	
	/**
	 * 对应的已激活数量
	 */
	public int ActivateNum
	{
		set { _activateNum = value; }
	    get { return _activateNum; }
	}
	
}