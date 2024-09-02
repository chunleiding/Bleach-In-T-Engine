using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 图鉴信息 message
 */
public class ResArchiveInfosMessage : Message 
{
	//图鉴列表
	List<ArchiveInfo> _archiveInfoList = new List<ArchiveInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//图鉴列表
		SerializeUtils.WriteShort(stream, (short)_archiveInfoList.Count);

		foreach (var element in _archiveInfoList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//图鉴列表
		int _archiveInfoList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _archiveInfoList_length; ++i) 
		{
			_archiveInfoList.Add(SerializeUtils.ReadBean<ArchiveInfo>(stream));
		}
	}
	
	/**
	 * get 图鉴列表
	 * @return 
	 */
	public List<ArchiveInfo> GetArchiveInfoList()
	{
		return _archiveInfoList;
	}
	
	/**
	 * set 图鉴列表
	 */
	public void SetArchiveInfoList(List<ArchiveInfo> archiveInfoList)
	{
		_archiveInfoList = archiveInfoList;
	}
	
	
	public override int GetId() 
	{
		return 829100;
	}
}