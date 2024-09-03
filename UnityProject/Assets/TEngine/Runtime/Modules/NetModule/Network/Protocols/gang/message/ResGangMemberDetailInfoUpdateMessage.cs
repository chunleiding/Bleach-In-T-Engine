using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 响应番队成员信息请求 message
 */
public class ResGangMemberDetailInfoUpdateMessage : Message 
{
	//成员id
	long _memberId;	
	//vip等级
	int _vipLevel;	
	//个人累计活跃度
	int _totalActive;	
	//活动次数
	int _activityTimes;	
	//番队经验
	int _gangExp;	
	//番队建设点数
	int _gangBuildPoint;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//成员id
		SerializeUtils.WriteLong(stream, _memberId);
		//vip等级
		SerializeUtils.WriteInt(stream, _vipLevel);
		//个人累计活跃度
		SerializeUtils.WriteInt(stream, _totalActive);
		//活动次数
		SerializeUtils.WriteInt(stream, _activityTimes);
		//番队经验
		SerializeUtils.WriteInt(stream, _gangExp);
		//番队建设点数
		SerializeUtils.WriteInt(stream, _gangBuildPoint);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//成员id
		_memberId = SerializeUtils.ReadLong(stream);
		//vip等级
		_vipLevel = SerializeUtils.ReadInt(stream);
		//个人累计活跃度
		_totalActive = SerializeUtils.ReadInt(stream);
		//活动次数
		_activityTimes = SerializeUtils.ReadInt(stream);
		//番队经验
		_gangExp = SerializeUtils.ReadInt(stream);
		//番队建设点数
		_gangBuildPoint = SerializeUtils.ReadInt(stream);
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
	 * vip等级
	 */
	public int VipLevel
	{
		set { _vipLevel = value; }
	    get { return _vipLevel; }
	}
	
	/**
	 * 个人累计活跃度
	 */
	public int TotalActive
	{
		set { _totalActive = value; }
	    get { return _totalActive; }
	}
	
	/**
	 * 活动次数
	 */
	public int ActivityTimes
	{
		set { _activityTimes = value; }
	    get { return _activityTimes; }
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
	
	
	public override int GetId() 
	{
		return 109158;
	}
}