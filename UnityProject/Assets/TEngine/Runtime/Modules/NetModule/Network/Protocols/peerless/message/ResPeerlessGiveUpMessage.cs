using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 回复放弃挑战消息 message
 */
public class ResPeerlessGiveUpMessage : Message 
{
	//0:成功 1：失败
	int _result;	
	//0:未参加 1：参加
	int _state;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0:成功 1：失败
		SerializeUtils.WriteInt(stream, _result);
		//0:未参加 1：参加
		SerializeUtils.WriteInt(stream, _state);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0:成功 1：失败
		_result = SerializeUtils.ReadInt(stream);
		//0:未参加 1：参加
		_state = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0:成功 1：失败
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * 0:未参加 1：参加
	 */
	public int State
	{
		set { _state = value; }
	    get { return _state; }
	}
	
	
	public override int GetId() 
	{
		return 817106;
	}
}