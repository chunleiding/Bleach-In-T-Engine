using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 通知玩家下线 message
 */
public class ResCloseGameServerMessage : Message 
{
	//类型，0-关闭服务器下线，1-顶号下线 2-封外挂下线
	int _type;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//类型，0-关闭服务器下线，1-顶号下线 2-封外挂下线
		SerializeUtils.WriteInt(stream, _type);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//类型，0-关闭服务器下线，1-顶号下线 2-封外挂下线
		_type = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 类型，0-关闭服务器下线，1-顶号下线 2-封外挂下线
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	
	public override int GetId() 
	{
		return 100109;
	}
}