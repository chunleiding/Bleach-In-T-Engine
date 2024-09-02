using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 一键激活图鉴结果 message
 */
public class ResOneKeyActivateArchiveMessage : Message 
{
	//结果 0:成功; 大于0:失败
	int _result;	
	//激活的图鉴列表
	List<ArchiveInfo> _archiveInfoList = new List<ArchiveInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//结果 0:成功; 大于0:失败
		SerializeUtils.WriteInt(stream, _result);
		//激活的图鉴列表
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
		//结果 0:成功; 大于0:失败
		_result = SerializeUtils.ReadInt(stream);
		//激活的图鉴列表
		int _archiveInfoList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _archiveInfoList_length; ++i) 
		{
			_archiveInfoList.Add(SerializeUtils.ReadBean<ArchiveInfo>(stream));
		}
	}
	
	/**
	 * 结果 0:成功; 大于0:失败
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * get 激活的图鉴列表
	 * @return 
	 */
	public List<ArchiveInfo> GetArchiveInfoList()
	{
		return _archiveInfoList;
	}
	
	/**
	 * set 激活的图鉴列表
	 */
	public void SetArchiveInfoList(List<ArchiveInfo> archiveInfoList)
	{
		_archiveInfoList = archiveInfoList;
	}
	
	
	public override int GetId() 
	{
		return 829105;
	}
}