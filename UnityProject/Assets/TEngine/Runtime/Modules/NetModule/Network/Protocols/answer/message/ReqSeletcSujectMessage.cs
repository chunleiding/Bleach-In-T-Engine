using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 发送玩家选择的答案 message
 */
public class ReqSeletcSujectMessage : Message 
{
	//题号
	int _titleID;	
	//答案的选项
	string _selectNum;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//题号
		SerializeUtils.WriteInt(stream, _titleID);
		//答案的选项
		SerializeUtils.WriteString(stream, _selectNum);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//题号
		_titleID = SerializeUtils.ReadInt(stream);
		//答案的选项
		_selectNum = SerializeUtils.ReadString(stream);
	}
	
	/**
	 * 题号
	 */
	public int TitleID
	{
		set { _titleID = value; }
	    get { return _titleID; }
	}
	
	/**
	 * 答案的选项
	 */
	public string SelectNum
	{
		set { _selectNum = value; }
	    get { return _selectNum; }
	}
	
	
	public override int GetId() 
	{
		return 808102;
	}
}