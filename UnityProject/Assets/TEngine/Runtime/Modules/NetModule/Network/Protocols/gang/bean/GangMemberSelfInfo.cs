using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 仅仅自己关心的信息
 */
public class GangMemberSelfInfo : IMessageSerialize 
{
	//膜拜的玩家
	List<long> _worshipPlayers = new List<long>();
	//0:没有被膜拜的奖励，1:有被膜拜的奖励
	byte _hasWorshipedReward;	
	//我用过哪些玩家的助战角色了
	List<long> _supportPlayers = new List<long>();
	//已经助战的时间
	int _supportTime;	
	//已经助战的次数
	int _supportTimes;	
	//副本信息
	List<GangInstanceSelfInfo> _instanceInfo = new List<GangInstanceSelfInfo>();
	//福袋发放信息
	List<GangBagGiveInfo> _gangBagGiveInfos = new List<GangBagGiveInfo>();
	//退出番队后的时间是否足够可以领取福袋(0:否,非0:是)
	int _exitGangCanReceiveGangBag;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//膜拜的玩家
		SerializeUtils.WriteShort(stream, (short)_worshipPlayers.Count);

		foreach (var element in _worshipPlayers)  
		{
			SerializeUtils.WriteLong(stream, element);
		}
		//0:没有被膜拜的奖励，1:有被膜拜的奖励
		SerializeUtils.WriteByte(stream, _hasWorshipedReward);
		//我用过哪些玩家的助战角色了
		SerializeUtils.WriteShort(stream, (short)_supportPlayers.Count);

		foreach (var element in _supportPlayers)  
		{
			SerializeUtils.WriteLong(stream, element);
		}
		//已经助战的时间
		SerializeUtils.WriteInt(stream, _supportTime);
		//已经助战的次数
		SerializeUtils.WriteInt(stream, _supportTimes);
		//副本信息
		SerializeUtils.WriteShort(stream, (short)_instanceInfo.Count);

		foreach (var element in _instanceInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//福袋发放信息
		SerializeUtils.WriteShort(stream, (short)_gangBagGiveInfos.Count);

		foreach (var element in _gangBagGiveInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//退出番队后的时间是否足够可以领取福袋(0:否,非0:是)
		SerializeUtils.WriteInt(stream, _exitGangCanReceiveGangBag);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//膜拜的玩家
		int _worshipPlayers_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _worshipPlayers_length; ++i) 
		{
			_worshipPlayers.Add(SerializeUtils.ReadLong(stream));
		}
		//0:没有被膜拜的奖励，1:有被膜拜的奖励
		_hasWorshipedReward = SerializeUtils.ReadByte(stream);
		//我用过哪些玩家的助战角色了
		int _supportPlayers_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _supportPlayers_length; ++i) 
		{
			_supportPlayers.Add(SerializeUtils.ReadLong(stream));
		}
		//已经助战的时间
		_supportTime = SerializeUtils.ReadInt(stream);
		//已经助战的次数
		_supportTimes = SerializeUtils.ReadInt(stream);
		//副本信息
		int _instanceInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _instanceInfo_length; ++i) 
		{
			_instanceInfo.Add(SerializeUtils.ReadBean<GangInstanceSelfInfo>(stream));
		}
		//福袋发放信息
		int _gangBagGiveInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _gangBagGiveInfos_length; ++i) 
		{
			_gangBagGiveInfos.Add(SerializeUtils.ReadBean<GangBagGiveInfo>(stream));
		}
		//退出番队后的时间是否足够可以领取福袋(0:否,非0:是)
		_exitGangCanReceiveGangBag = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * get 膜拜的玩家
	 * @return 
	 */
	public List<long> GetWorshipPlayers()
	{
		return _worshipPlayers;
	}
	
	/**
	 * set 膜拜的玩家
	 */
	public void SetWorshipPlayers(List<long> worshipPlayers)
	{
		_worshipPlayers = worshipPlayers;
	}
	
	/**
	 * 0:没有被膜拜的奖励，1:有被膜拜的奖励
	 */
	public byte HasWorshipedReward
	{
		set { _hasWorshipedReward = value; }
	    get { return _hasWorshipedReward; }
	}
	
	/**
	 * get 我用过哪些玩家的助战角色了
	 * @return 
	 */
	public List<long> GetSupportPlayers()
	{
		return _supportPlayers;
	}
	
	/**
	 * set 我用过哪些玩家的助战角色了
	 */
	public void SetSupportPlayers(List<long> supportPlayers)
	{
		_supportPlayers = supportPlayers;
	}
	
	/**
	 * 已经助战的时间
	 */
	public int SupportTime
	{
		set { _supportTime = value; }
	    get { return _supportTime; }
	}
	
	/**
	 * 已经助战的次数
	 */
	public int SupportTimes
	{
		set { _supportTimes = value; }
	    get { return _supportTimes; }
	}
	
	/**
	 * get 副本信息
	 * @return 
	 */
	public List<GangInstanceSelfInfo> GetInstanceInfo()
	{
		return _instanceInfo;
	}
	
	/**
	 * set 副本信息
	 */
	public void SetInstanceInfo(List<GangInstanceSelfInfo> instanceInfo)
	{
		_instanceInfo = instanceInfo;
	}
	
	/**
	 * get 福袋发放信息
	 * @return 
	 */
	public List<GangBagGiveInfo> GetGangBagGiveInfos()
	{
		return _gangBagGiveInfos;
	}
	
	/**
	 * set 福袋发放信息
	 */
	public void SetGangBagGiveInfos(List<GangBagGiveInfo> gangBagGiveInfos)
	{
		_gangBagGiveInfos = gangBagGiveInfos;
	}
	
	/**
	 * 退出番队后的时间是否足够可以领取福袋(0:否,非0:是)
	 */
	public int ExitGangCanReceiveGangBag
	{
		set { _exitGangCanReceiveGangBag = value; }
	    get { return _exitGangCanReceiveGangBag; }
	}
	
}