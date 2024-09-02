using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 免费特权卡状态 message
 */
public class ResFreePrivilegeStateMessage : Message 
{
	//是否用过免费特权卡（0：没用过1：用过）
	int _used;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//是否用过免费特权卡（0：没用过1：用过）
		SerializeUtils.WriteInt(stream, _used);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//是否用过免费特权卡（0：没用过1：用过）
		_used = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 是否用过免费特权卡（0：没用过1：用过）
	 */
	public int Used
	{
		set { _used = value; }
	    get { return _used; }
	}
	
	
	public override int GetId() 
	{
		return 312209;
	}
}