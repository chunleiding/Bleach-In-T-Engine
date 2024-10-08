using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 探索信息 message
 */
public class ResDiscoveryInfoMessage : Message 
{
	//探索信息
	DiscoveryInfo _discoveryInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//探索信息
		SerializeUtils.WriteBean(stream, _discoveryInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//探索信息
		_discoveryInfo = SerializeUtils.ReadBean<DiscoveryInfo>(stream);
	}
	
	/**
	 * 探索信息
	 */
	public DiscoveryInfo DiscoveryInfo
	{
		set { _discoveryInfo = value; }
	    get { return _discoveryInfo; }
	}
	
	
	public override int GetId() 
	{
		return 303300;
	}
}