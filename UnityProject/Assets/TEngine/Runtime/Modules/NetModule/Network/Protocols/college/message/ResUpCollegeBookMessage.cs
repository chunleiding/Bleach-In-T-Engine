using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 回复升级学院技能书 message
 */
public class ResUpCollegeBookMessage : Message 
{
	//0:成功 其他：失败
	int _success;	
	//升级后的技能书
	CollegeBook _bookInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0:成功 其他：失败
		SerializeUtils.WriteInt(stream, _success);
		//升级后的技能书
		SerializeUtils.WriteBean(stream, _bookInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0:成功 其他：失败
		_success = SerializeUtils.ReadInt(stream);
		//升级后的技能书
		_bookInfo = SerializeUtils.ReadBean<CollegeBook>(stream);
	}
	
	/**
	 * 0:成功 其他：失败
	 */
	public int Success
	{
		set { _success = value; }
	    get { return _success; }
	}
	
	/**
	 * 升级后的技能书
	 */
	public CollegeBook BookInfo
	{
		set { _bookInfo = value; }
	    get { return _bookInfo; }
	}
	
	
	public override int GetId() 
	{
		return 828103;
	}
}