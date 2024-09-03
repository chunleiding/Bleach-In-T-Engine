using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 改变称号返回 message
 */
public class ResChangeTitleStateMessage : Message 
{
	//结果 0：成功；大于0：失败
	int _result;	
	//称号id
	int _titleId;	
	//最新称号状态
	int _state;	
	//上一个佩戴时的id，若没佩戴为0
	int _lastId;	
	//改变前的状态
	int _oldState;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//结果 0：成功；大于0：失败
		SerializeUtils.WriteInt(stream, _result);
		//称号id
		SerializeUtils.WriteInt(stream, _titleId);
		//最新称号状态
		SerializeUtils.WriteInt(stream, _state);
		//上一个佩戴时的id，若没佩戴为0
		SerializeUtils.WriteInt(stream, _lastId);
		//改变前的状态
		SerializeUtils.WriteInt(stream, _oldState);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//结果 0：成功；大于0：失败
		_result = SerializeUtils.ReadInt(stream);
		//称号id
		_titleId = SerializeUtils.ReadInt(stream);
		//最新称号状态
		_state = SerializeUtils.ReadInt(stream);
		//上一个佩戴时的id，若没佩戴为0
		_lastId = SerializeUtils.ReadInt(stream);
		//改变前的状态
		_oldState = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 结果 0：成功；大于0：失败
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
	 * 最新称号状态
	 */
	public int State
	{
		set { _state = value; }
	    get { return _state; }
	}
	
	/**
	 * 上一个佩戴时的id，若没佩戴为0
	 */
	public int LastId
	{
		set { _lastId = value; }
	    get { return _lastId; }
	}
	
	/**
	 * 改变前的状态
	 */
	public int OldState
	{
		set { _oldState = value; }
	    get { return _oldState; }
	}
	
	
	public override int GetId() 
	{
		return 827103;
	}
}