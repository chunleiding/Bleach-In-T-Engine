using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求获取番队成员的角色信息(角色变更太频繁，尤其是全局buff变动，客户端又只是做展示，客户端来取) message
 */
public class ReqGangMemberCharactersInfoMessage : Message 
{
	//番队成员的玩家id
	long _memberId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//番队成员的玩家id
		SerializeUtils.WriteLong(stream, _memberId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//番队成员的玩家id
		_memberId = SerializeUtils.ReadLong(stream);
	}
	
	/**
	 * 番队成员的玩家id
	 */
	public long MemberId
	{
		set { _memberId = value; }
	    get { return _memberId; }
	}
	
	
	public override int GetId() 
	{
		return 109222;
	}
}