using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 回复购买buff结果 message
 */
public class ResBuyBuffMessage : Message 
{
	//0:成功 1：资源不足 2：鼓舞失败 3：达到上限 
	int _result;	
	//当前buff层数
	int _buffNum;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0:成功 1：资源不足 2：鼓舞失败 3：达到上限 
		SerializeUtils.WriteInt(stream, _result);
		//当前buff层数
		SerializeUtils.WriteInt(stream, _buffNum);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0:成功 1：资源不足 2：鼓舞失败 3：达到上限 
		_result = SerializeUtils.ReadInt(stream);
		//当前buff层数
		_buffNum = SerializeUtils.ReadInt(stream);
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
	 * 当前buff层数
	 */
	public int BuffNum
	{
		set { _buffNum = value; }
	    get { return _buffNum; }
	}
	
	
	public override int GetId() 
	{
		return 807107;
	}
}