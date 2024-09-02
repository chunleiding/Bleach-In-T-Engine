using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 玩家答题状态 message
 */
public class ResAnswerChoseStateMessage : Message 
{
	//选择状态(0:未选，1：选了)
	int _state;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//选择状态(0:未选，1：选了)
		SerializeUtils.WriteInt(stream, _state);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//选择状态(0:未选，1：选了)
		_state = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 选择状态(0:未选，1：选了)
	 */
	public int State
	{
		set { _state = value; }
	    get { return _state; }
	}
	
	
	public override int GetId() 
	{
		return 808107;
	}
}