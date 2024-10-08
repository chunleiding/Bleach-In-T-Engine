using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 后端返回进入关卡的结果（体力等条条件不满足不允许进入） message
 */
public class ResEnterLevelMessage : Message 
{
	//进入关卡结果消息Id(0：成功,非0：失败的消息Id)
	int _msg;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//进入关卡结果消息Id(0：成功,非0：失败的消息Id)
		SerializeUtils.WriteInt(stream, _msg);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//进入关卡结果消息Id(0：成功,非0：失败的消息Id)
		_msg = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 进入关卡结果消息Id(0：成功,非0：失败的消息Id)
	 */
	public int Msg
	{
		set { _msg = value; }
	    get { return _msg; }
	}
	
	
	public override int GetId() 
	{
		return 102103;
	}
}