using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 妹子每日刷新 message
 */
public class ResGirlDayRefreshMessage : Message 
{
	//妹子信息
	List<GirlDayRefreshInfo> _infos = new List<GirlDayRefreshInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//妹子信息
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
		//妹子信息
		int _infos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _infos_length; ++i) 
		{
			_infos.Add(SerializeUtils.ReadBean<GirlDayRefreshInfo>(stream));
		}
	}
	
	/**
	 * get 妹子信息
	 * @return 
	 */
	public List<GirlDayRefreshInfo> GetInfos()
	{
		return _infos;
	}
	
	/**
	 * set 妹子信息
	 */
	public void SetInfos(List<GirlDayRefreshInfo> infos)
	{
		_infos = infos;
	}
	
	
	public override int GetId() 
	{
		return 108106;
	}
}