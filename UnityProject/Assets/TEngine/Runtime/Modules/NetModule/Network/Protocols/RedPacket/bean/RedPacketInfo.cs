using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 红包信息
 */
public class RedPacketInfo : IMessageSerialize 
{
	//红包编号
	int _id;	
	//发送者名称
	string _senderName;	
	//总共金额
	int _totalGold;	
	//剩余的金额
	int _leftGold;	
	//总共可领取次数
	int _totalReceiveCount;	
	//剩余可领取次数
	int _leftReceiveCount;	
	//发送者角色id
	int _senderCharacterId;	
	//发送者角色阶数
	int _senderStageLevel;	
	//发送者角色成长率等级
	int _senderGrowthLv;	
	//红包状态（0：还为领取完 1：领取完 ）
	int _state;	
	//发送红包时间
	int _sendTime;	
	//领取者集合
	List<CollectorInfo> _collectorList = new List<CollectorInfo>();
	//发送者id
	long _senderId;	
	//道具id
	int _itemId;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//红包编号
		SerializeUtils.WriteInt(stream, _id);
		//发送者名称
		SerializeUtils.WriteString(stream, _senderName);
		//总共金额
		SerializeUtils.WriteInt(stream, _totalGold);
		//剩余的金额
		SerializeUtils.WriteInt(stream, _leftGold);
		//总共可领取次数
		SerializeUtils.WriteInt(stream, _totalReceiveCount);
		//剩余可领取次数
		SerializeUtils.WriteInt(stream, _leftReceiveCount);
		//发送者角色id
		SerializeUtils.WriteInt(stream, _senderCharacterId);
		//发送者角色阶数
		SerializeUtils.WriteInt(stream, _senderStageLevel);
		//发送者角色成长率等级
		SerializeUtils.WriteInt(stream, _senderGrowthLv);
		//红包状态（0：还为领取完 1：领取完 ）
		SerializeUtils.WriteInt(stream, _state);
		//发送红包时间
		SerializeUtils.WriteInt(stream, _sendTime);
		//领取者集合
		SerializeUtils.WriteShort(stream, (short)_collectorList.Count);

		foreach (var element in _collectorList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//发送者id
		SerializeUtils.WriteLong(stream, _senderId);
		//道具id
		SerializeUtils.WriteInt(stream, _itemId);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//红包编号
		_id = SerializeUtils.ReadInt(stream);
		//发送者名称
		_senderName = SerializeUtils.ReadString(stream);
		//总共金额
		_totalGold = SerializeUtils.ReadInt(stream);
		//剩余的金额
		_leftGold = SerializeUtils.ReadInt(stream);
		//总共可领取次数
		_totalReceiveCount = SerializeUtils.ReadInt(stream);
		//剩余可领取次数
		_leftReceiveCount = SerializeUtils.ReadInt(stream);
		//发送者角色id
		_senderCharacterId = SerializeUtils.ReadInt(stream);
		//发送者角色阶数
		_senderStageLevel = SerializeUtils.ReadInt(stream);
		//发送者角色成长率等级
		_senderGrowthLv = SerializeUtils.ReadInt(stream);
		//红包状态（0：还为领取完 1：领取完 ）
		_state = SerializeUtils.ReadInt(stream);
		//发送红包时间
		_sendTime = SerializeUtils.ReadInt(stream);
		//领取者集合
		int _collectorList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _collectorList_length; ++i) 
		{
			_collectorList.Add(SerializeUtils.ReadBean<CollectorInfo>(stream));
		}
		//发送者id
		_senderId = SerializeUtils.ReadLong(stream);
		//道具id
		_itemId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 红包编号
	 */
	public int Id
	{
		set { _id = value; }
	    get { return _id; }
	}
	
	/**
	 * 发送者名称
	 */
	public string SenderName
	{
		set { _senderName = value; }
	    get { return _senderName; }
	}
	
	/**
	 * 总共金额
	 */
	public int TotalGold
	{
		set { _totalGold = value; }
	    get { return _totalGold; }
	}
	
	/**
	 * 剩余的金额
	 */
	public int LeftGold
	{
		set { _leftGold = value; }
	    get { return _leftGold; }
	}
	
	/**
	 * 总共可领取次数
	 */
	public int TotalReceiveCount
	{
		set { _totalReceiveCount = value; }
	    get { return _totalReceiveCount; }
	}
	
	/**
	 * 剩余可领取次数
	 */
	public int LeftReceiveCount
	{
		set { _leftReceiveCount = value; }
	    get { return _leftReceiveCount; }
	}
	
	/**
	 * 发送者角色id
	 */
	public int SenderCharacterId
	{
		set { _senderCharacterId = value; }
	    get { return _senderCharacterId; }
	}
	
	/**
	 * 发送者角色阶数
	 */
	public int SenderStageLevel
	{
		set { _senderStageLevel = value; }
	    get { return _senderStageLevel; }
	}
	
	/**
	 * 发送者角色成长率等级
	 */
	public int SenderGrowthLv
	{
		set { _senderGrowthLv = value; }
	    get { return _senderGrowthLv; }
	}
	
	/**
	 * 红包状态（0：还为领取完 1：领取完 ）
	 */
	public int State
	{
		set { _state = value; }
	    get { return _state; }
	}
	
	/**
	 * 发送红包时间
	 */
	public int SendTime
	{
		set { _sendTime = value; }
	    get { return _sendTime; }
	}
	
	/**
	 * get 领取者集合
	 * @return 
	 */
	public List<CollectorInfo> GetCollectorList()
	{
		return _collectorList;
	}
	
	/**
	 * set 领取者集合
	 */
	public void SetCollectorList(List<CollectorInfo> collectorList)
	{
		_collectorList = collectorList;
	}
	
	/**
	 * 发送者id
	 */
	public long SenderId
	{
		set { _senderId = value; }
	    get { return _senderId; }
	}
	
	/**
	 * 道具id
	 */
	public int ItemId
	{
		set { _itemId = value; }
	    get { return _itemId; }
	}
	
}