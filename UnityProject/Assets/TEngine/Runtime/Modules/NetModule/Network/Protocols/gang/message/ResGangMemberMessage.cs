using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 单个队员改变 message
 */
public class ResGangMemberMessage : Message 
{
	//队员信息
	GangMemberInfo _member;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//队员信息
		SerializeUtils.WriteBean(stream, _member);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//队员信息
		_member = SerializeUtils.ReadBean<GangMemberInfo>(stream);
	}
	
	/**
	 * 队员信息
	 */
	public GangMemberInfo Member
	{
		set { _member = value; }
	    get { return _member; }
	}
	
	
	public override int GetId() 
	{
		return 109111;
	}
}