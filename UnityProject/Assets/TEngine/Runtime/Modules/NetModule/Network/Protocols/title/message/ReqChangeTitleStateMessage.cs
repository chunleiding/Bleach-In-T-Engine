using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求改变称号状态 message
 */
public class ReqChangeTitleStateMessage : Message 
{
	//称号id
	int _titleId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//称号id
		SerializeUtils.WriteInt(stream, _titleId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//称号id
		_titleId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 称号id
	 */
	public int TitleId
	{
		set { _titleId = value; }
	    get { return _titleId; }
	}
	
	
	public override int GetId() 
	{
		return 827102;
	}
}