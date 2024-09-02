using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队福袋领取消息
 */
public class GangBagReceiveInfo : IMessageSerialize 
{
	//福袋成员名称
	string _memberName;	
	//领取的金钱(灵子)
	int _gold;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//福袋成员名称
		SerializeUtils.WriteString(stream, _memberName);
		//领取的金钱(灵子)
		SerializeUtils.WriteInt(stream, _gold);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//福袋成员名称
		_memberName = SerializeUtils.ReadString(stream);
		//领取的金钱(灵子)
		_gold = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 福袋成员名称
	 */
	public string MemberName
	{
		set { _memberName = value; }
	    get { return _memberName; }
	}
	
	/**
	 * 领取的金钱(灵子)
	 */
	public int Gold
	{
		set { _gold = value; }
	    get { return _gold; }
	}
	
}