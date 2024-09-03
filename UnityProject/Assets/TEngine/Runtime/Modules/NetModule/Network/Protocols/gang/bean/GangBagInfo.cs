using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队福袋消息
 */
public class GangBagInfo : IMessageSerialize 
{
	//福袋id
	long _bagId;	
	//福袋类型
	int _type;	
	//福袋所有者成员id
	long _owner;	
	//福袋所有者成员名称
	string _ownerName;	
	//福袋发放时间
	long _giveTime;	
	//福袋所有者可以领取体力的份数
	int _ownerCanReceiveHealthCopy;	
	//已经领取的福袋份数
	int _receivedCopy;	
	//剩余可以领取福袋的时间(秒)
	long _surplusTime;	
	//是否已经领取(0:当前玩家未领取,非0:当前玩家领取过)
	byte _received;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//福袋id
		SerializeUtils.WriteLong(stream, _bagId);
		//福袋类型
		SerializeUtils.WriteInt(stream, _type);
		//福袋所有者成员id
		SerializeUtils.WriteLong(stream, _owner);
		//福袋所有者成员名称
		SerializeUtils.WriteString(stream, _ownerName);
		//福袋发放时间
		SerializeUtils.WriteLong(stream, _giveTime);
		//福袋所有者可以领取体力的份数
		SerializeUtils.WriteInt(stream, _ownerCanReceiveHealthCopy);
		//已经领取的福袋份数
		SerializeUtils.WriteInt(stream, _receivedCopy);
		//剩余可以领取福袋的时间(秒)
		SerializeUtils.WriteLong(stream, _surplusTime);
		//是否已经领取(0:当前玩家未领取,非0:当前玩家领取过)
		SerializeUtils.WriteByte(stream, _received);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//福袋id
		_bagId = SerializeUtils.ReadLong(stream);
		//福袋类型
		_type = SerializeUtils.ReadInt(stream);
		//福袋所有者成员id
		_owner = SerializeUtils.ReadLong(stream);
		//福袋所有者成员名称
		_ownerName = SerializeUtils.ReadString(stream);
		//福袋发放时间
		_giveTime = SerializeUtils.ReadLong(stream);
		//福袋所有者可以领取体力的份数
		_ownerCanReceiveHealthCopy = SerializeUtils.ReadInt(stream);
		//已经领取的福袋份数
		_receivedCopy = SerializeUtils.ReadInt(stream);
		//剩余可以领取福袋的时间(秒)
		_surplusTime = SerializeUtils.ReadLong(stream);
		//是否已经领取(0:当前玩家未领取,非0:当前玩家领取过)
		_received = SerializeUtils.ReadByte(stream);
	}
	
	/**
	 * 福袋id
	 */
	public long BagId
	{
		set { _bagId = value; }
	    get { return _bagId; }
	}
	
	/**
	 * 福袋类型
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	/**
	 * 福袋所有者成员id
	 */
	public long Owner
	{
		set { _owner = value; }
	    get { return _owner; }
	}
	
	/**
	 * 福袋所有者成员名称
	 */
	public string OwnerName
	{
		set { _ownerName = value; }
	    get { return _ownerName; }
	}
	
	/**
	 * 福袋发放时间
	 */
	public long GiveTime
	{
		set { _giveTime = value; }
	    get { return _giveTime; }
	}
	
	/**
	 * 福袋所有者可以领取体力的份数
	 */
	public int OwnerCanReceiveHealthCopy
	{
		set { _ownerCanReceiveHealthCopy = value; }
	    get { return _ownerCanReceiveHealthCopy; }
	}
	
	/**
	 * 已经领取的福袋份数
	 */
	public int ReceivedCopy
	{
		set { _receivedCopy = value; }
	    get { return _receivedCopy; }
	}
	
	/**
	 * 剩余可以领取福袋的时间(秒)
	 */
	public long SurplusTime
	{
		set { _surplusTime = value; }
	    get { return _surplusTime; }
	}
	
	/**
	 * 是否已经领取(0:当前玩家未领取,非0:当前玩家领取过)
	 */
	public byte Received
	{
		set { _received = value; }
	    get { return _received; }
	}
	
}