using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 手动刷新商店 message
 */
public class ReqShopRefreshMessage : Message 
{
	//商店类型(1:浦原商店, 2:竞技商店)
	int _type;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//商店类型(1:浦原商店, 2:竞技商店)
		SerializeUtils.WriteInt(stream, _type);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//商店类型(1:浦原商店, 2:竞技商店)
		_type = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 商店类型(1:浦原商店, 2:竞技商店)
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	
	public override int GetId() 
	{
		return 104203;
	}
}