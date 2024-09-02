using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求领取番队福袋体力结果 message
 */
public class ResReceiveGangBagHealthMessage : Message 
{
	//造成本次领取的体力的其他成员人数
	int _memberNum;	
	//领取的体力
	int _health;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//造成本次领取的体力的其他成员人数
		SerializeUtils.WriteInt(stream, _memberNum);
		//领取的体力
		SerializeUtils.WriteInt(stream, _health);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//造成本次领取的体力的其他成员人数
		_memberNum = SerializeUtils.ReadInt(stream);
		//领取的体力
		_health = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 造成本次领取的体力的其他成员人数
	 */
	public int MemberNum
	{
		set { _memberNum = value; }
	    get { return _memberNum; }
	}
	
	/**
	 * 领取的体力
	 */
	public int Health
	{
		set { _health = value; }
	    get { return _health; }
	}
	
	
	public override int GetId() 
	{
		return 109139;
	}
}