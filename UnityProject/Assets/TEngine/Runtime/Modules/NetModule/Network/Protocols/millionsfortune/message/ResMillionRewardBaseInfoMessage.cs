using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 百万转盘基础配置信息 message
 */
public class ResMillionRewardBaseInfoMessage : Message 
{
	//转盘列表
	List<MillionBaseInfo> _infos = new List<MillionBaseInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//转盘列表
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
		//转盘列表
		int _infos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _infos_length; ++i) 
		{
			_infos.Add(SerializeUtils.ReadBean<MillionBaseInfo>(stream));
		}
	}
	
	/**
	 * get 转盘列表
	 * @return 
	 */
	public List<MillionBaseInfo> GetInfos()
	{
		return _infos;
	}
	
	/**
	 * set 转盘列表
	 */
	public void SetInfos(List<MillionBaseInfo> infos)
	{
		_infos = infos;
	}
	
	
	public override int GetId() 
	{
		return 316207;
	}
}