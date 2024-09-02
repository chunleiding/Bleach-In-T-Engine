using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 购买称号返回 message
 */
public class ResBuyTitleMessage : Message 
{
	//购买结果 0：成功；大于0：失败
	int _result;	
	//称号id
	int _titleId;	
	//称号状态
	int _state;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//购买结果 0：成功；大于0：失败
		SerializeUtils.WriteInt(stream, _result);
		//称号id
		SerializeUtils.WriteInt(stream, _titleId);
		//称号状态
		SerializeUtils.WriteInt(stream, _state);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//购买结果 0：成功；大于0：失败
		_result = SerializeUtils.ReadInt(stream);
		//称号id
		_titleId = SerializeUtils.ReadInt(stream);
		//称号状态
		_state = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 购买结果 0：成功；大于0：失败
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
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
	 * 称号状态
	 */
	public int State
	{
		set { _state = value; }
	    get { return _state; }
	}
	
	
	public override int GetId() 
	{
		return 827105;
	}
}