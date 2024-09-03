using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求多个活动领奖 message
 */
public class ReqMultiCampRewardExtendMessage : Message 
{
	//活动ID列表
	List<int> _campIdList = new List<int>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//活动ID列表
		SerializeUtils.WriteShort(stream, (short)_campIdList.Count);

		foreach (var element in _campIdList)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//活动ID列表
		int _campIdList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _campIdList_length; ++i) 
		{
			_campIdList.Add(SerializeUtils.ReadInt(stream));
		}
	}
	
	/**
	 * get 活动ID列表
	 * @return 
	 */
	public List<int> GetCampIdList()
	{
		return _campIdList;
	}
	
	/**
	 * set 活动ID列表
	 */
	public void SetCampIdList(List<int> campIdList)
	{
		_campIdList = campIdList;
	}
	
	
	public override int GetId() 
	{
		return 823111;
	}
}