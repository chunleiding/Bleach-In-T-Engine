using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 活动列表 message
 */
public class ResCampInfosMessage : Message 
{
	//活动列表
	List<CampInfo> _infos = new List<CampInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//活动列表
		SerializeUtils.WriteShort(stream, (short)_infos.Count);

		foreach (var element in _infos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//活动列表
		int _infos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _infos_length; ++i) 
		{
			_infos.Add(SerializeUtils.ReadBean<CampInfo>(stream));
		}
	}
	
	/**
	 * get 活动列表
	 * @return 
	 */
	public List<CampInfo> GetInfos()
	{
		return _infos;
	}
	
	/**
	 * set 活动列表
	 */
	public void SetInfos(List<CampInfo> infos)
	{
		_infos = infos;
	}
	
	
	public override int GetId() 
	{
		return 311205;
	}
}