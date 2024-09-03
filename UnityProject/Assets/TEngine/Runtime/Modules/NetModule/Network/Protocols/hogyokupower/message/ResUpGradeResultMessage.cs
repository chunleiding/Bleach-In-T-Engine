using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 升级或者升阶回复 message
 */
public class ResUpGradeResultMessage : Message 
{
	//0成功1失败
	int _result;	
	//当前英雄崩玉id
	int _hogykuPowerId;	
	//当前英雄id
	int _chracterId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0成功1失败
		SerializeUtils.WriteInt(stream, _result);
		//当前英雄崩玉id
		SerializeUtils.WriteInt(stream, _hogykuPowerId);
		//当前英雄id
		SerializeUtils.WriteInt(stream, _chracterId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0成功1失败
		_result = SerializeUtils.ReadInt(stream);
		//当前英雄崩玉id
		_hogykuPowerId = SerializeUtils.ReadInt(stream);
		//当前英雄id
		_chracterId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0成功1失败
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * 当前英雄崩玉id
	 */
	public int HogykuPowerId
	{
		set { _hogykuPowerId = value; }
	    get { return _hogykuPowerId; }
	}
	
	/**
	 * 当前英雄id
	 */
	public int ChracterId
	{
		set { _chracterId = value; }
	    get { return _chracterId; }
	}
	
	
	public override int GetId() 
	{
		return 824103;
	}
}