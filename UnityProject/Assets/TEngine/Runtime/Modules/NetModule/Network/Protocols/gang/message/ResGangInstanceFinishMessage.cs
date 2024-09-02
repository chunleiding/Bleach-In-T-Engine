using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 副本结束 message
 */
public class ResGangInstanceFinishMessage : Message 
{
	//已经通关的副本中ID最大的
	int _maxInstanceId;	
	//结束的副本id
	int _instanceId;	
	//0:失败 1:成功
	byte _suc;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//已经通关的副本中ID最大的
		SerializeUtils.WriteInt(stream, _maxInstanceId);
		//结束的副本id
		SerializeUtils.WriteInt(stream, _instanceId);
		//0:失败 1:成功
		SerializeUtils.WriteByte(stream, _suc);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//已经通关的副本中ID最大的
		_maxInstanceId = SerializeUtils.ReadInt(stream);
		//结束的副本id
		_instanceId = SerializeUtils.ReadInt(stream);
		//0:失败 1:成功
		_suc = SerializeUtils.ReadByte(stream);
	}
	
	/**
	 * 已经通关的副本中ID最大的
	 */
	public int MaxInstanceId
	{
		set { _maxInstanceId = value; }
	    get { return _maxInstanceId; }
	}
	
	/**
	 * 结束的副本id
	 */
	public int InstanceId
	{
		set { _instanceId = value; }
	    get { return _instanceId; }
	}
	
	/**
	 * 0:失败 1:成功
	 */
	public byte Suc
	{
		set { _suc = value; }
	    get { return _suc; }
	}
	
	
	public override int GetId() 
	{
		return 109116;
	}
}