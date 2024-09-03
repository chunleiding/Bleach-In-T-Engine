using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 单个副本信息 message
 */
public class ResGangSingleInstanceMessage : Message 
{
	//副本信息
	GangInstanceInfo _info;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//副本信息
		SerializeUtils.WriteBean(stream, _info);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//副本信息
		_info = SerializeUtils.ReadBean<GangInstanceInfo>(stream);
	}
	
	/**
	 * 副本信息
	 */
	public GangInstanceInfo Info
	{
		set { _info = value; }
	    get { return _info; }
	}
	
	
	public override int GetId() 
	{
		return 109109;
	}
}