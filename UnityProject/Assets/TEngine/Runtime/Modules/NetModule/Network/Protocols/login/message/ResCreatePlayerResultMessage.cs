using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 创建玩家失败 message
 */
public class ResCreatePlayerResultMessage : Message 
{
	//0-成功  1-已有该玩家名 
	int _errId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0-成功  1-已有该玩家名 
		SerializeUtils.WriteInt(stream, _errId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0-成功  1-已有该玩家名 
		_errId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0-成功  1-已有该玩家名 
	 */
	public int ErrId
	{
		set { _errId = value; }
	    get { return _errId; }
	}
	
	
	public override int GetId() 
	{
		return 100102;
	}
}