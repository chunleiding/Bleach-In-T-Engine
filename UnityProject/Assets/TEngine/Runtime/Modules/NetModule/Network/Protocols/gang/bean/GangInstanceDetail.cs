using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 副本详细信息
 */
public class GangInstanceDetail : IMessageSerialize 
{
	//已经通关的副本中ID最大的
	int _instanceId;	
	//副本信息列表
	List<GangInstanceInfo> _instanceInfos = new List<GangInstanceInfo>();
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//已经通关的副本中ID最大的
		SerializeUtils.WriteInt(stream, _instanceId);
		//副本信息列表
		SerializeUtils.WriteShort(stream, (short)_instanceInfos.Count);

		foreach (var element in _instanceInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//已经通关的副本中ID最大的
		_instanceId = SerializeUtils.ReadInt(stream);
		//副本信息列表
		int _instanceInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _instanceInfos_length; ++i) 
		{
			_instanceInfos.Add(SerializeUtils.ReadBean<GangInstanceInfo>(stream));
		}
	}
	
	/**
	 * 已经通关的副本中ID最大的
	 */
	public int InstanceId
	{
		set { _instanceId = value; }
	    get { return _instanceId; }
	}
	
	/**
	 * get 副本信息列表
	 * @return 
	 */
	public List<GangInstanceInfo> GetInstanceInfos()
	{
		return _instanceInfos;
	}
	
	/**
	 * set 副本信息列表
	 */
	public void SetInstanceInfos(List<GangInstanceInfo> instanceInfos)
	{
		_instanceInfos = instanceInfos;
	}
	
}