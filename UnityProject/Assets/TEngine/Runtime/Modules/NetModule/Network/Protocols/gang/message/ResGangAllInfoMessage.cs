using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 所有番队信息 message
 */
public class ResGangAllInfoMessage : Message 
{
	//番队列表
	List<GangInfo> _infos = new List<GangInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//番队列表
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
		//番队列表
		int _infos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _infos_length; ++i) 
		{
			_infos.Add(SerializeUtils.ReadBean<GangInfo>(stream));
		}
	}
	
	/**
	 * get 番队列表
	 * @return 
	 */
	public List<GangInfo> GetInfos()
	{
		return _infos;
	}
	
	/**
	 * set 番队列表
	 */
	public void SetInfos(List<GangInfo> infos)
	{
		_infos = infos;
	}
	
	
	public override int GetId() 
	{
		return 109101;
	}
}