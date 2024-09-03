using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队成员改名消息 message
 */
public class ResGangMemberChangeNameMessage : Message 
{
	//成员id
	long _memberId;	
	//成员名字
	string _memberName;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//成员id
		SerializeUtils.WriteLong(stream, _memberId);
		//成员名字
		SerializeUtils.WriteString(stream, _memberName);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//成员id
		_memberId = SerializeUtils.ReadLong(stream);
		//成员名字
		_memberName = SerializeUtils.ReadString(stream);
	}
	
	/**
	 * 成员id
	 */
	public long MemberId
	{
		set { _memberId = value; }
	    get { return _memberId; }
	}
	
	/**
	 * 成员名字
	 */
	public string MemberName
	{
		set { _memberName = value; }
	    get { return _memberName; }
	}
	
	
	public override int GetId() 
	{
		return 109159;
	}
}