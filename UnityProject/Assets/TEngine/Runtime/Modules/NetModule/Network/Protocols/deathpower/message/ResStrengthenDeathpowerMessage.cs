using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 返回前端请求强化死神之力结果 message
 */
public class ResStrengthenDeathpowerMessage : Message 
{
	//扫荡结果消息Id(0：成功,非0：失败的消息Id)
	int _msg;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//扫荡结果消息Id(0：成功,非0：失败的消息Id)
		SerializeUtils.WriteInt(stream, _msg);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//扫荡结果消息Id(0：成功,非0：失败的消息Id)
		_msg = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 扫荡结果消息Id(0：成功,非0：失败的消息Id)
	 */
	public int Msg
	{
		set { _msg = value; }
	    get { return _msg; }
	}
	
	
	public override int GetId() 
	{
		return 309101;
	}
}