using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 返回当前全部记忆之路信息 message
 */
public class ResMemoryRoadInfosMessage : Message 
{
	//记忆之路基础信息
	MemoryRoadBaseInfo _memoryRoadBaseInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//记忆之路基础信息
		SerializeUtils.WriteBean(stream, _memoryRoadBaseInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//记忆之路基础信息
		_memoryRoadBaseInfo = SerializeUtils.ReadBean<MemoryRoadBaseInfo>(stream);
	}
	
	/**
	 * 记忆之路基础信息
	 */
	public MemoryRoadBaseInfo MemoryRoadBaseInfo
	{
		set { _memoryRoadBaseInfo = value; }
	    get { return _memoryRoadBaseInfo; }
	}
	
	
	public override int GetId() 
	{
		return 220103;
	}
}