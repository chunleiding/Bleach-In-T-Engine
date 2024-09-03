using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 添加活动 message
 */
public class ResReceiveCampMessage : Message 
{
	//新增的活动列表
	List<CampInfo> _infoList = new List<CampInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//新增的活动列表
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
		//新增的活动列表
		int _infoList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _infoList_length; ++i) 
		{
			_infoList.Add(SerializeUtils.ReadBean<CampInfo>(stream));
		}
	}
	
	/**
	 * get 新增的活动列表
	 * @return 
	 */
	public List<CampInfo> GetInfoList()
	{
		return _infoList;
	}
	
	/**
	 * set 新增的活动列表
	 */
	public void SetInfoList(List<CampInfo> infoList)
	{
		_infoList = infoList;
	}
	
	
	public override int GetId() 
	{
		return 311209;
	}
}