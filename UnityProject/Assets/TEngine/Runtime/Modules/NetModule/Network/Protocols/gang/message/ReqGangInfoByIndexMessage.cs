using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求查看番队信息[通过起止索引] message
 */
public class ReqGangInfoByIndexMessage : Message 
{
	//开始索引[可以从0开始]
	int _begin;	
	//结束索引
	int _end;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//开始索引[可以从0开始]
		SerializeUtils.WriteInt(stream, _begin);
		//结束索引
		SerializeUtils.WriteInt(stream, _end);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//开始索引[可以从0开始]
		_begin = SerializeUtils.ReadInt(stream);
		//结束索引
		_end = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 开始索引[可以从0开始]
	 */
	public int Begin
	{
		set { _begin = value; }
	    get { return _begin; }
	}
	
	/**
	 * 结束索引
	 */
	public int End
	{
		set { _end = value; }
	    get { return _end; }
	}
	
	
	public override int GetId() 
	{
		return 109230;
	}
}