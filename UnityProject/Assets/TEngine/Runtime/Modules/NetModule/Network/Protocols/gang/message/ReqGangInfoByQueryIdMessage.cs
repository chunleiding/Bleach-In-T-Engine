using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求查看番队信息[通过查询编号] message
 */
public class ReqGangInfoByQueryIdMessage : Message 
{
	//查询编号
	long _queryId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//查询编号
		SerializeUtils.WriteLong(stream, _queryId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//查询编号
		_queryId = SerializeUtils.ReadLong(stream);
	}
	
	/**
	 * 查询编号
	 */
	public long QueryId
	{
		set { _queryId = value; }
	    get { return _queryId; }
	}
	
	
	public override int GetId() 
	{
		return 109229;
	}
}