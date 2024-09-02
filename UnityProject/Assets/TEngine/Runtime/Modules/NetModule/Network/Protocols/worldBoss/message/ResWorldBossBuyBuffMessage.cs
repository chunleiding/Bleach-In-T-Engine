using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 回复购买buff结果 message
 */
public class ResWorldBossBuyBuffMessage : Message 
{
	//0:成功 1：资源不足 2：鼓舞失败 3：达到上限 
	int _result;	
	//buff等级
	int _buffLevel;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0:成功 1：资源不足 2：鼓舞失败 3：达到上限 
		SerializeUtils.WriteInt(stream, _result);
		//buff等级
		SerializeUtils.WriteInt(stream, _buffLevel);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0:成功 1：资源不足 2：鼓舞失败 3：达到上限 
		_result = SerializeUtils.ReadInt(stream);
		//buff等级
		_buffLevel = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0:成功 1：资源不足 2：鼓舞失败 3：达到上限 
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * buff等级
	 */
	public int BuffLevel
	{
		set { _buffLevel = value; }
	    get { return _buffLevel; }
	}
	
	
	public override int GetId() 
	{
		return 807107;
	}
}