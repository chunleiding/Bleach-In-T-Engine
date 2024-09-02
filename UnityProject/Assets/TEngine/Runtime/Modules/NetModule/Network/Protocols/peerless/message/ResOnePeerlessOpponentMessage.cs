using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 刷新对手信息中单个队伍 message
 */
public class ResOnePeerlessOpponentMessage : Message 
{
	//类型
	int _type;	
	//战斗结果
	int _result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//类型
		SerializeUtils.WriteInt(stream, _type);
		//战斗结果
		SerializeUtils.WriteInt(stream, _result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//类型
		_type = SerializeUtils.ReadInt(stream);
		//战斗结果
		_result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 类型
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	/**
	 * 战斗结果
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	
	public override int GetId() 
	{
		return 817114;
	}
}