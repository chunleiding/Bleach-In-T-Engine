using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求番队成员信息 message
 */
public class ReqGangMemberDetailInfoUpdateMessage : Message 
{
	//成员id
	long _memberId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//成员id
		SerializeUtils.WriteLong(stream, _memberId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//成员id
		_memberId = SerializeUtils.ReadLong(stream);
	}
	
	/**
	 * 成员id
	 */
	public long MemberId
	{
		set { _memberId = value; }
	    get { return _memberId; }
	}
	
	
	public override int GetId() 
	{
		return 109232;
	}
}