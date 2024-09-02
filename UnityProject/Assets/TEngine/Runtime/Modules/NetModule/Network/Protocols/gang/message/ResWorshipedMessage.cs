using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 通知玩家被膜拜的结果消息 message
 */
public class ResWorshipedMessage : Message 
{
	//1:被膜拜 ,0:取消被膜拜
	byte _worshiped;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//1:被膜拜 ,0:取消被膜拜
		SerializeUtils.WriteByte(stream, _worshiped);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//1:被膜拜 ,0:取消被膜拜
		_worshiped = SerializeUtils.ReadByte(stream);
	}
	
	/**
	 * 1:被膜拜 ,0:取消被膜拜
	 */
	public byte Worshiped
	{
		set { _worshiped = value; }
	    get { return _worshiped; }
	}
	
	
	public override int GetId() 
	{
		return 109122;
	}
}