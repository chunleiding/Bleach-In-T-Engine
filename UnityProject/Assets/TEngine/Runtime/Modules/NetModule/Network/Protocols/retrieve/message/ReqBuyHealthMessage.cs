using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求找回资源 message
 */
public class ReqBuyHealthMessage : Message 
{
	//0：找回体力；1：找回经验
	int _type;	
	//找回经验万分比
	int _ExpPercent;	
	//日期
	string _date;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0：找回体力；1：找回经验
		SerializeUtils.WriteInt(stream, _type);
		//找回经验万分比
		SerializeUtils.WriteInt(stream, _ExpPercent);
		//日期
		SerializeUtils.WriteString(stream, _date);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0：找回体力；1：找回经验
		_type = SerializeUtils.ReadInt(stream);
		//找回经验万分比
		_ExpPercent = SerializeUtils.ReadInt(stream);
		//日期
		_date = SerializeUtils.ReadString(stream);
	}
	
	/**
	 * 0：找回体力；1：找回经验
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	/**
	 * 找回经验万分比
	 */
	public int ExpPercent
	{
		set { _ExpPercent = value; }
	    get { return _ExpPercent; }
	}
	
	/**
	 * 日期
	 */
	public string Date
	{
		set { _date = value; }
	    get { return _date; }
	}
	
	
	public override int GetId() 
	{
		return 813101;
	}
}