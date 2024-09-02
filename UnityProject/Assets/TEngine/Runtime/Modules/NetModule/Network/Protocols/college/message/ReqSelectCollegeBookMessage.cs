using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 选择书院技能书 message
 */
public class ReqSelectCollegeBookMessage : Message 
{
	//技能书编号
	List<int> _bookIdList = new List<int>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//技能书编号
		SerializeUtils.WriteShort(stream, (short)_bookIdList.Count);

		foreach (var element in _bookIdList)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//技能书编号
		int _bookIdList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _bookIdList_length; ++i) 
		{
			_bookIdList.Add(SerializeUtils.ReadInt(stream));
		}
	}
	
	/**
	 * get 技能书编号
	 * @return 
	 */
	public List<int> GetBookIdList()
	{
		return _bookIdList;
	}
	
	/**
	 * set 技能书编号
	 */
	public void SetBookIdList(List<int> bookIdList)
	{
		_bookIdList = bookIdList;
	}
	
	
	public override int GetId() 
	{
		return 828105;
	}
}