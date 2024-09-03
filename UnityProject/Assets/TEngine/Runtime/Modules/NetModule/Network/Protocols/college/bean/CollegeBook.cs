using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 学院技能书
 */
public class CollegeBook : IMessageSerialize 
{
	//技能书编号
	int _bookId;	
	//技能书等级
	int _bookLevel;	
	//0:未使用 1：使用
	int _isUsing;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//技能书编号
		SerializeUtils.WriteInt(stream, _bookId);
		//技能书等级
		SerializeUtils.WriteInt(stream, _bookLevel);
		//0:未使用 1：使用
		SerializeUtils.WriteInt(stream, _isUsing);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//技能书编号
		_bookId = SerializeUtils.ReadInt(stream);
		//技能书等级
		_bookLevel = SerializeUtils.ReadInt(stream);
		//0:未使用 1：使用
		_isUsing = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 技能书编号
	 */
	public int BookId
	{
		set { _bookId = value; }
	    get { return _bookId; }
	}
	
	/**
	 * 技能书等级
	 */
	public int BookLevel
	{
		set { _bookLevel = value; }
	    get { return _bookLevel; }
	}
	
	/**
	 * 0:未使用 1：使用
	 */
	public int IsUsing
	{
		set { _isUsing = value; }
	    get { return _isUsing; }
	}
	
}