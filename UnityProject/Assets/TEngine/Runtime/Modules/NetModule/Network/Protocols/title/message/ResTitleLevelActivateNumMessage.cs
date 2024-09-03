using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 发送玩家称号等级对应的激活数量 message
 */
public class ResTitleLevelActivateNumMessage : Message 
{
	//已激活的称号列表
	List<TitleLevelInfo> _activateTitleList = new List<TitleLevelInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//已激活的称号列表
		SerializeUtils.WriteShort(stream, (short)_activateTitleList.Count);

		foreach (var element in _activateTitleList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//已激活的称号列表
		int _activateTitleList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _activateTitleList_length; ++i) 
		{
			_activateTitleList.Add(SerializeUtils.ReadBean<TitleLevelInfo>(stream));
		}
	}
	
	/**
	 * get 已激活的称号列表
	 * @return 
	 */
	public List<TitleLevelInfo> GetActivateTitleList()
	{
		return _activateTitleList;
	}
	
	/**
	 * set 已激活的称号列表
	 */
	public void SetActivateTitleList(List<TitleLevelInfo> activateTitleList)
	{
		_activateTitleList = activateTitleList;
	}
	
	
	public override int GetId() 
	{
		return 827112;
	}
}