using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 清除换一批倒计时 message
 */
public class ReqClearChageTimeMessage : Message 
{
	//0 换一批，1护送时间
	int _type;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0 换一批，1护送时间
		SerializeUtils.WriteInt(stream, _type);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0 换一批，1护送时间
		_type = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0 换一批，1护送时间
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	
	public override int GetId() 
	{
		return 810104;
	}
}