using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 资源找回信息 message
 */
public class ResRetrieveInfoMessage : Message 
{
	//资源找回信息
	List<HealthData> _RetrieveInfo = new List<HealthData>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//资源找回信息
		SerializeUtils.WriteShort(stream, (short)_RetrieveInfo.Count);

		foreach (var element in _RetrieveInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//资源找回信息
		int _RetrieveInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _RetrieveInfo_length; ++i) 
		{
			_RetrieveInfo.Add(SerializeUtils.ReadBean<HealthData>(stream));
		}
	}
	
	/**
	 * get 资源找回信息
	 * @return 
	 */
	public List<HealthData> GetRetrieveInfo()
	{
		return _RetrieveInfo;
	}
	
	/**
	 * set 资源找回信息
	 */
	public void SetRetrieveInfo(List<HealthData> RetrieveInfo)
	{
		_RetrieveInfo = RetrieveInfo;
	}
	
	
	public override int GetId() 
	{
		return 813100;
	}
}