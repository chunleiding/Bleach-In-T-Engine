using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队详细信息
 */
public class GangDetailInfo : IMessageSerialize 
{
	//番队基本信息
	GangInfo _info;	
	//等级设置
	int _level;	
	//成员信息
	List<GangMemberInfo> _members = new List<GangMemberInfo>();
	//申请者信息
	List<GangApplyerInfo> _applyers = new List<GangApplyerInfo>();
	//番队事件
	List<GangEventInfo> _events = new List<GangEventInfo>();
	//副本详细信息
	GangInstanceDetail _instance;	
	//番队福袋信息
	List<GangBagInfo> _bags = new List<GangBagInfo>();
	//番队经验
	int _gangExp;	
	//番队建设点数
	int _gangBuildPoint;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//番队基本信息
		SerializeUtils.WriteBean(stream, _info);
		//等级设置
		SerializeUtils.WriteInt(stream, _level);
		//成员信息
		SerializeUtils.WriteShort(stream, (short)_members.Count);

		foreach (var element in _members)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//申请者信息
		SerializeUtils.WriteShort(stream, (short)_applyers.Count);

		foreach (var element in _applyers)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//番队事件
		SerializeUtils.WriteShort(stream, (short)_events.Count);

		foreach (var element in _events)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//副本详细信息
		SerializeUtils.WriteBean(stream, _instance);
		//番队福袋信息
		SerializeUtils.WriteShort(stream, (short)_bags.Count);

		foreach (var element in _bags)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//番队经验
		SerializeUtils.WriteInt(stream, _gangExp);
		//番队建设点数
		SerializeUtils.WriteInt(stream, _gangBuildPoint);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//番队基本信息
		_info = SerializeUtils.ReadBean<GangInfo>(stream);
		//等级设置
		_level = SerializeUtils.ReadInt(stream);
		//成员信息
		int _members_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _members_length; ++i) 
		{
			_members.Add(SerializeUtils.ReadBean<GangMemberInfo>(stream));
		}
		//申请者信息
		int _applyers_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _applyers_length; ++i) 
		{
			_applyers.Add(SerializeUtils.ReadBean<GangApplyerInfo>(stream));
		}
		//番队事件
		int _events_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _events_length; ++i) 
		{
			_events.Add(SerializeUtils.ReadBean<GangEventInfo>(stream));
		}
		//副本详细信息
		_instance = SerializeUtils.ReadBean<GangInstanceDetail>(stream);
		//番队福袋信息
		int _bags_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _bags_length; ++i) 
		{
			_bags.Add(SerializeUtils.ReadBean<GangBagInfo>(stream));
		}
		//番队经验
		_gangExp = SerializeUtils.ReadInt(stream);
		//番队建设点数
		_gangBuildPoint = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 番队基本信息
	 */
	public GangInfo Info
	{
		set { _info = value; }
	    get { return _info; }
	}
	
	/**
	 * 等级设置
	 */
	public int Level
	{
		set { _level = value; }
	    get { return _level; }
	}
	
	/**
	 * get 成员信息
	 * @return 
	 */
	public List<GangMemberInfo> GetMembers()
	{
		return _members;
	}
	
	/**
	 * set 成员信息
	 */
	public void SetMembers(List<GangMemberInfo> members)
	{
		_members = members;
	}
	
	/**
	 * get 申请者信息
	 * @return 
	 */
	public List<GangApplyerInfo> GetApplyers()
	{
		return _applyers;
	}
	
	/**
	 * set 申请者信息
	 */
	public void SetApplyers(List<GangApplyerInfo> applyers)
	{
		_applyers = applyers;
	}
	
	/**
	 * get 番队事件
	 * @return 
	 */
	public List<GangEventInfo> GetEvents()
	{
		return _events;
	}
	
	/**
	 * set 番队事件
	 */
	public void SetEvents(List<GangEventInfo> events)
	{
		_events = events;
	}
	
	/**
	 * 副本详细信息
	 */
	public GangInstanceDetail Instance
	{
		set { _instance = value; }
	    get { return _instance; }
	}
	
	/**
	 * get 番队福袋信息
	 * @return 
	 */
	public List<GangBagInfo> GetBags()
	{
		return _bags;
	}
	
	/**
	 * set 番队福袋信息
	 */
	public void SetBags(List<GangBagInfo> bags)
	{
		_bags = bags;
	}
	
	/**
	 * 番队经验
	 */
	public int GangExp
	{
		set { _gangExp = value; }
	    get { return _gangExp; }
	}
	
	/**
	 * 番队建设点数
	 */
	public int GangBuildPoint
	{
		set { _gangBuildPoint = value; }
	    get { return _gangBuildPoint; }
	}
	
}