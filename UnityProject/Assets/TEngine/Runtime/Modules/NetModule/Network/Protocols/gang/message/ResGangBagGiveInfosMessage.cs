using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 福袋发放信息 message
 */
public class ResGangBagGiveInfosMessage : Message 
{
	//福袋发放信息
	List<GangBagGiveInfo> _gangBagGiveInfos = new List<GangBagGiveInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//福袋发放信息
		SerializeUtils.WriteShort(stream, (short)_gangBagGiveInfos.Count);

		foreach (var element in _gangBagGiveInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//福袋发放信息
		int _gangBagGiveInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _gangBagGiveInfos_length; ++i) 
		{
			_gangBagGiveInfos.Add(SerializeUtils.ReadBean<GangBagGiveInfo>(stream));
		}
	}
	
	/**
	 * get 福袋发放信息
	 * @return 
	 */
	public List<GangBagGiveInfo> GetGangBagGiveInfos()
	{
		return _gangBagGiveInfos;
	}
	
	/**
	 * set 福袋发放信息
	 */
	public void SetGangBagGiveInfos(List<GangBagGiveInfo> gangBagGiveInfos)
	{
		_gangBagGiveInfos = gangBagGiveInfos;
	}
	
	
	public override int GetId() 
	{
		return 109140;
	}
}