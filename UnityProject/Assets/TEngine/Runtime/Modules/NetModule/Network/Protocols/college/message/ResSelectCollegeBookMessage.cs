using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 回复选择书院技能书 message
 */
public class ResSelectCollegeBookMessage : Message 
{
	//选择的技能书
	List<int> _bookList = new List<int>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//选择的技能书
		SerializeUtils.WriteShort(stream, (short)_bookList.Count);

		foreach (var element in _bookList)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//选择的技能书
		int _bookList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _bookList_length; ++i) 
		{
			_bookList.Add(SerializeUtils.ReadInt(stream));
		}
	}
	
	/**
	 * get 选择的技能书
	 * @return 
	 */
	public List<int> GetBookList()
	{
		return _bookList;
	}
	
	/**
	 * set 选择的技能书
	 */
	public void SetBookList(List<int> bookList)
	{
		_bookList = bookList;
	}
	
	
	public override int GetId() 
	{
		return 828106;
	}
}