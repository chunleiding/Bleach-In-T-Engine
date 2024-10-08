using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 同步转盘列表消息 message
 */
public class ResMillionListMessage : Message 
{
	//转盘列表
	List<int> _idList = new List<int>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//转盘列表
		SerializeUtils.WriteShort(stream, (short)_idList.Count);

		foreach (var element in _idList)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//转盘列表
		int _idList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _idList_length; ++i) 
		{
			_idList.Add(SerializeUtils.ReadInt(stream));
		}
	}
	
	/**
	 * get 转盘列表
	 * @return 
	 */
	public List<int> GetIdList()
	{
		return _idList;
	}
	
	/**
	 * set 转盘列表
	 */
	public void SetIdList(List<int> idList)
	{
		_idList = idList;
	}
	
	
	public override int GetId() 
	{
		return 316106;
	}
}