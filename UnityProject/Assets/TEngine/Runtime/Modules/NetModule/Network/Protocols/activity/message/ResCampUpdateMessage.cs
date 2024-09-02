using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 活动刷新 message
 */
public class ResCampUpdateMessage : Message 
{
	//更新列表
	List<CampUpdateTrigger> _InfoList = new List<CampUpdateTrigger>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//更新列表
		SerializeUtils.WriteShort(stream, (short)_InfoList.Count);

		foreach (var element in _InfoList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//更新列表
		int _InfoList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _InfoList_length; ++i) 
		{
			_InfoList.Add(SerializeUtils.ReadBean<CampUpdateTrigger>(stream));
		}
	}
	
	/**
	 * get 更新列表
	 * @return 
	 */
	public List<CampUpdateTrigger> GetInfoList()
	{
		return _InfoList;
	}
	
	/**
	 * set 更新列表
	 */
	public void SetInfoList(List<CampUpdateTrigger> InfoList)
	{
		_InfoList = InfoList;
	}
	
	
	public override int GetId() 
	{
		return 311207;
	}
}