using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求查看番队信息结果[通过番队编号],gangId为0表示查询的番队不存在 message
 */
public class ResGangInfoByGangIdMessage : Message 
{
	//番队信息
	GangInfo _gangInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//番队信息
		SerializeUtils.WriteBean(stream, _gangInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//番队信息
		_gangInfo = SerializeUtils.ReadBean<GangInfo>(stream);
	}
	
	/**
	 * 番队信息
	 */
	public GangInfo GangInfo
	{
		set { _gangInfo = value; }
	    get { return _gangInfo; }
	}
	
	
	public override int GetId() 
	{
		return 109141;
	}
}