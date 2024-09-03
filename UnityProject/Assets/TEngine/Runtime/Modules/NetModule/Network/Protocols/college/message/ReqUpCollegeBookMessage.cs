using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求升级书院技能书 message
 */
public class ReqUpCollegeBookMessage : Message 
{
	//技能书编号
	int _bookId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//技能书编号
		SerializeUtils.WriteInt(stream, _bookId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//技能书编号
		_bookId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 技能书编号
	 */
	public int BookId
	{
		set { _bookId = value; }
	    get { return _bookId; }
	}
	
	
	public override int GetId() 
	{
		return 828102;
	}
}