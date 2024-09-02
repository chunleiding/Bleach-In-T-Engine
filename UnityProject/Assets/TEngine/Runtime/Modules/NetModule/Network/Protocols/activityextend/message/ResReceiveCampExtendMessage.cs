using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 添加活动 message
 */
public class ResReceiveCampExtendMessage : Message 
{
	//活动列表
	List<CampInfoExtend> _infoList = new List<CampInfoExtend>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//活动列表
		SerializeUtils.WriteShort(stream, (short)_infoList.Count);

		foreach (var element in _infoList)  
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
		int _infoList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _infoList_length; ++i) 
		{
			_infoList.Add(SerializeUtils.ReadBean<CampInfoExtend>(stream));
		}
	}
	
	/**
	 * get 活动列表
	 * @return 
	 */
	public List<CampInfoExtend> GetInfoList()
	{
		return _infoList;
	}
	
	/**
	 * set 活动列表
	 */
	public void SetInfoList(List<CampInfoExtend> infoList)
	{
		_infoList = infoList;
	}
	
	
	public override int GetId() 
	{
		return 823107;
	}
}