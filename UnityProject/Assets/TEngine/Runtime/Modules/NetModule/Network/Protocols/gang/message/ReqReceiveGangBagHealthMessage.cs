using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求领取番队福袋体力 message
 */
public class ReqReceiveGangBagHealthMessage : Message 
{
	//福袋id
	long _bagId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//福袋id
		SerializeUtils.WriteLong(stream, _bagId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//福袋id
		_bagId = SerializeUtils.ReadLong(stream);
	}
	
	/**
	 * 福袋id
	 */
	public long BagId
	{
		set { _bagId = value; }
	    get { return _bagId; }
	}
	
	
	public override int GetId() 
	{
		return 109226;
	}
}