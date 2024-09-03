using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 申请番队 message
 */
public class ReqGangApplyMessage : Message 
{
	//番队id
	long _gangId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//番队id
		SerializeUtils.WriteLong(stream, _gangId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//番队id
		_gangId = SerializeUtils.ReadLong(stream);
	}
	
	/**
	 * 番队id
	 */
	public long GangId
	{
		set { _gangId = value; }
	    get { return _gangId; }
	}
	
	
	public override int GetId() 
	{
		return 109202;
	}
}