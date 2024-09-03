using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 道具过期请求后端 message
 */
public class ReqItemValidityOverMessage : Message 
{
	//道具id
	int _itemId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//道具id
		SerializeUtils.WriteInt(stream, _itemId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//道具id
		_itemId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 道具id
	 */
	public int ItemId
	{
		set { _itemId = value; }
	    get { return _itemId; }
	}
	
	
	public override int GetId() 
	{
		return 101103;
	}
}