using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 发送学院信息 message
 */
public class ResCollegeInfoMessage : Message 
{
	//学院等级
	int _collegeLevel;	
	//技能书
	List<CollegeBook> _bookList = new List<CollegeBook>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//学院等级
		SerializeUtils.WriteInt(stream, _collegeLevel);
		//技能书
		SerializeUtils.WriteShort(stream, (short)_bookList.Count);

		foreach (var element in _bookList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//学院等级
		_collegeLevel = SerializeUtils.ReadInt(stream);
		//技能书
		int _bookList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _bookList_length; ++i) 
		{
			_bookList.Add(SerializeUtils.ReadBean<CollegeBook>(stream));
		}
	}
	
	/**
	 * 学院等级
	 */
	public int CollegeLevel
	{
		set { _collegeLevel = value; }
	    get { return _collegeLevel; }
	}
	
	/**
	 * get 技能书
	 * @return 
	 */
	public List<CollegeBook> GetBookList()
	{
		return _bookList;
	}
	
	/**
	 * set 技能书
	 */
	public void SetBookList(List<CollegeBook> bookList)
	{
		_bookList = bookList;
	}
	
	
	public override int GetId() 
	{
		return 828104;
	}
}