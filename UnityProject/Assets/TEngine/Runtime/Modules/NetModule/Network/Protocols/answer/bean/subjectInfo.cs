using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 题目信息
 */
public class subjectInfo : IMessageSerialize 
{
	//题目标题
	string _title;	
	//答案A
	string _selectA;	
	//答案B
	string _selectB;	
	//答案C
	string _selectC;	
	//答案D
	string _selectD;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//题目标题
		SerializeUtils.WriteString(stream, _title);
		//答案A
		SerializeUtils.WriteString(stream, _selectA);
		//答案B
		SerializeUtils.WriteString(stream, _selectB);
		//答案C
		SerializeUtils.WriteString(stream, _selectC);
		//答案D
		SerializeUtils.WriteString(stream, _selectD);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//题目标题
		_title = SerializeUtils.ReadString(stream);
		//答案A
		_selectA = SerializeUtils.ReadString(stream);
		//答案B
		_selectB = SerializeUtils.ReadString(stream);
		//答案C
		_selectC = SerializeUtils.ReadString(stream);
		//答案D
		_selectD = SerializeUtils.ReadString(stream);
	}
	
	/**
	 * 题目标题
	 */
	public string Title
	{
		set { _title = value; }
	    get { return _title; }
	}
	
	/**
	 * 答案A
	 */
	public string SelectA
	{
		set { _selectA = value; }
	    get { return _selectA; }
	}
	
	/**
	 * 答案B
	 */
	public string SelectB
	{
		set { _selectB = value; }
	    get { return _selectB; }
	}
	
	/**
	 * 答案C
	 */
	public string SelectC
	{
		set { _selectC = value; }
	    get { return _selectC; }
	}
	
	/**
	 * 答案D
	 */
	public string SelectD
	{
		set { _selectD = value; }
	    get { return _selectD; }
	}
	
}