using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 购买特殊商店商品 message
 */
public class ReqBuySpecialShopItemMessage : Message 
{
	//序号
	int _index;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//序号
		SerializeUtils.WriteInt(stream, _index);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//序号
		_index = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 序号
	 */
	public int Index
	{
		set { _index = value; }
	    get { return _index; }
	}
	
	
	public override int GetId() 
	{
		return 225202;
	}
}