using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 回复无双死神的基本信息 message
 */
public class ResPeerlessBaseInfoMessage : Message 
{
	//基本信息
	PeerlessBaseInfo _baseInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//基本信息
		SerializeUtils.WriteBean(stream, _baseInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//基本信息
		_baseInfo = SerializeUtils.ReadBean<PeerlessBaseInfo>(stream);
	}
	
	/**
	 * 基本信息
	 */
	public PeerlessBaseInfo BaseInfo
	{
		set { _baseInfo = value; }
	    get { return _baseInfo; }
	}
	
	
	public override int GetId() 
	{
		return 817118;
	}
}