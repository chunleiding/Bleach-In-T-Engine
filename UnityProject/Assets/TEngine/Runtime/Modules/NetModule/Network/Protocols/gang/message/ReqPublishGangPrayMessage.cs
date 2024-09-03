using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求发布祈愿 message
 */
public class ReqPublishGangPrayMessage : Message 
{
	//发布祈愿的道具id
	int _itemId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//发布祈愿的道具id
		SerializeUtils.WriteInt(stream, _itemId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//发布祈愿的道具id
		_itemId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 发布祈愿的道具id
	 */
	public int ItemId
	{
		set { _itemId = value; }
	    get { return _itemId; }
	}
	
	
	public override int GetId() 
	{
		return 109258;
	}
}