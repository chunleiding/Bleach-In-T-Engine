using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 称号列表 message
 */
public class ResTitleInfosMessage : Message 
{
	//称号列表
	List<TitleInfo> _infos = new List<TitleInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//称号列表
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
		//称号列表
		int _infos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _infos_length; ++i) 
		{
			_infos.Add(SerializeUtils.ReadBean<TitleInfo>(stream));
		}
	}
	
	/**
	 * get 称号列表
	 * @return 
	 */
	public List<TitleInfo> GetInfos()
	{
		return _infos;
	}
	
	/**
	 * set 称号列表
	 */
	public void SetInfos(List<TitleInfo> infos)
	{
		_infos = infos;
	}
	
	
	public override int GetId() 
	{
		return 827101;
	}
}