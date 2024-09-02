using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 开启副本 message
 */
public class ReqGangInstanceActiveMessage : Message 
{
	//副本id
	int _instanceId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//副本id
		SerializeUtils.WriteInt(stream, _instanceId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//副本id
		_instanceId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 副本id
	 */
	public int InstanceId
	{
		set { _instanceId = value; }
	    get { return _instanceId; }
	}
	
	
	public override int GetId() 
	{
		return 109216;
	}
}