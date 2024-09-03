using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 活动数据
 */
public class CampInfo : IMessageSerialize 
{
	//活动id
	int _id;	
	//类型
	int _type;	
	//活动奖励
	List<CampRewardInfo> _rewardInfo = new List<CampRewardInfo>();
	//排行榜信息
	List<CampRankInfo> _rankInfo = new List<CampRankInfo>();
	//系统活动参数
	string _systenParam;	
	//排行榜类型
	int _rankType;	
	//活动名字
	string _name;	
	//主活动标签上面的图片
	string _tabImg;	
	//主活动标签
	string _mainTab;	
	//子活动标签
	string _subTab;	
	//活动描述
	string _describe;	
	//子面板类型
	int _subPanelType;	
	//活动概述
	int _generalize ;	
	//跳转的目标系统
	string _targetSystem;	
	//完成进度分子
	int _numerator;	
	//完成进度分母
	int _denominator;	
	//活动开始的时间点
	int _startTime;	
	//活动结束时间点
	int _overTime;	
	//子分组（子标签）
	int _subGroup;	
	//主分组（主标签）
	int _mainGroup;	
	//排行榜自己的排名
	int _selfRank;	
	//已领奖次数
	int _rewardedTimes;	
	//奖励状态(0:不可领奖，1：已达成未领奖，2已领奖)
	int _rewardState;	
	//剩余可领奖次数
	int _leftRewardTimes;	
	//总共领奖次数
	int _totalRewardTimes;	
	//活动特征:(1,新服活动,其他，老服活动)
	int _age;	
	//参与活动条件
	string _condition;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//活动id
		SerializeUtils.WriteInt(stream, _id);
		//类型
		SerializeUtils.WriteInt(stream, _type);
		//活动奖励
		SerializeUtils.WriteShort(stream, (short)_rewardInfo.Count);

		foreach (var element in _rewardInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//排行榜信息
		SerializeUtils.WriteShort(stream, (short)_rankInfo.Count);

		foreach (var element in _rankInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//系统活动参数
		SerializeUtils.WriteString(stream, _systenParam);
		//排行榜类型
		SerializeUtils.WriteInt(stream, _rankType);
		//活动名字
		SerializeUtils.WriteString(stream, _name);
		//主活动标签上面的图片
		SerializeUtils.WriteString(stream, _tabImg);
		//主活动标签
		SerializeUtils.WriteString(stream, _mainTab);
		//子活动标签
		SerializeUtils.WriteString(stream, _subTab);
		//活动描述
		SerializeUtils.WriteString(stream, _describe);
		//子面板类型
		SerializeUtils.WriteInt(stream, _subPanelType);
		//活动概述
		SerializeUtils.WriteInt(stream, _generalize );
		//跳转的目标系统
		SerializeUtils.WriteString(stream, _targetSystem);
		//完成进度分子
		SerializeUtils.WriteInt(stream, _numerator);
		//完成进度分母
		SerializeUtils.WriteInt(stream, _denominator);
		//活动开始的时间点
		SerializeUtils.WriteInt(stream, _startTime);
		//活动结束时间点
		SerializeUtils.WriteInt(stream, _overTime);
		//子分组（子标签）
		SerializeUtils.WriteInt(stream, _subGroup);
		//主分组（主标签）
		SerializeUtils.WriteInt(stream, _mainGroup);
		//排行榜自己的排名
		SerializeUtils.WriteInt(stream, _selfRank);
		//已领奖次数
		SerializeUtils.WriteInt(stream, _rewardedTimes);
		//奖励状态(0:不可领奖，1：已达成未领奖，2已领奖)
		SerializeUtils.WriteInt(stream, _rewardState);
		//剩余可领奖次数
		SerializeUtils.WriteInt(stream, _leftRewardTimes);
		//总共领奖次数
		SerializeUtils.WriteInt(stream, _totalRewardTimes);
		//活动特征:(1,新服活动,其他，老服活动)
		SerializeUtils.WriteInt(stream, _age);
		//参与活动条件
		SerializeUtils.WriteString(stream, _condition);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//活动id
		_id = SerializeUtils.ReadInt(stream);
		//类型
		_type = SerializeUtils.ReadInt(stream);
		//活动奖励
		int _rewardInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _rewardInfo_length; ++i) 
		{
			_rewardInfo.Add(SerializeUtils.ReadBean<CampRewardInfo>(stream));
		}
		//排行榜信息
		int _rankInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _rankInfo_length; ++i) 
		{
			_rankInfo.Add(SerializeUtils.ReadBean<CampRankInfo>(stream));
		}
		//系统活动参数
		_systenParam = SerializeUtils.ReadString(stream);
		//排行榜类型
		_rankType = SerializeUtils.ReadInt(stream);
		//活动名字
		_name = SerializeUtils.ReadString(stream);
		//主活动标签上面的图片
		_tabImg = SerializeUtils.ReadString(stream);
		//主活动标签
		_mainTab = SerializeUtils.ReadString(stream);
		//子活动标签
		_subTab = SerializeUtils.ReadString(stream);
		//活动描述
		_describe = SerializeUtils.ReadString(stream);
		//子面板类型
		_subPanelType = SerializeUtils.ReadInt(stream);
		//活动概述
		_generalize  = SerializeUtils.ReadInt(stream);
		//跳转的目标系统
		_targetSystem = SerializeUtils.ReadString(stream);
		//完成进度分子
		_numerator = SerializeUtils.ReadInt(stream);
		//完成进度分母
		_denominator = SerializeUtils.ReadInt(stream);
		//活动开始的时间点
		_startTime = SerializeUtils.ReadInt(stream);
		//活动结束时间点
		_overTime = SerializeUtils.ReadInt(stream);
		//子分组（子标签）
		_subGroup = SerializeUtils.ReadInt(stream);
		//主分组（主标签）
		_mainGroup = SerializeUtils.ReadInt(stream);
		//排行榜自己的排名
		_selfRank = SerializeUtils.ReadInt(stream);
		//已领奖次数
		_rewardedTimes = SerializeUtils.ReadInt(stream);
		//奖励状态(0:不可领奖，1：已达成未领奖，2已领奖)
		_rewardState = SerializeUtils.ReadInt(stream);
		//剩余可领奖次数
		_leftRewardTimes = SerializeUtils.ReadInt(stream);
		//总共领奖次数
		_totalRewardTimes = SerializeUtils.ReadInt(stream);
		//活动特征:(1,新服活动,其他，老服活动)
		_age = SerializeUtils.ReadInt(stream);
		//参与活动条件
		_condition = SerializeUtils.ReadString(stream);
	}
	
	/**
	 * 活动id
	 */
	public int Id
	{
		set { _id = value; }
	    get { return _id; }
	}
	
	/**
	 * 类型
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	/**
	 * get 活动奖励
	 * @return 
	 */
	public List<CampRewardInfo> GetRewardInfo()
	{
		return _rewardInfo;
	}
	
	/**
	 * set 活动奖励
	 */
	public void SetRewardInfo(List<CampRewardInfo> rewardInfo)
	{
		_rewardInfo = rewardInfo;
	}
	
	/**
	 * get 排行榜信息
	 * @return 
	 */
	public List<CampRankInfo> GetRankInfo()
	{
		return _rankInfo;
	}
	
	/**
	 * set 排行榜信息
	 */
	public void SetRankInfo(List<CampRankInfo> rankInfo)
	{
		_rankInfo = rankInfo;
	}
	
	/**
	 * 系统活动参数
	 */
	public string SystenParam
	{
		set { _systenParam = value; }
	    get { return _systenParam; }
	}
	
	/**
	 * 排行榜类型
	 */
	public int RankType
	{
		set { _rankType = value; }
	    get { return _rankType; }
	}
	
	/**
	 * 活动名字
	 */
	public string Name
	{
		set { _name = value; }
	    get { return _name; }
	}
	
	/**
	 * 主活动标签上面的图片
	 */
	public string TabImg
	{
		set { _tabImg = value; }
	    get { return _tabImg; }
	}
	
	/**
	 * 主活动标签
	 */
	public string MainTab
	{
		set { _mainTab = value; }
	    get { return _mainTab; }
	}
	
	/**
	 * 子活动标签
	 */
	public string SubTab
	{
		set { _subTab = value; }
	    get { return _subTab; }
	}
	
	/**
	 * 活动描述
	 */
	public string Describe
	{
		set { _describe = value; }
	    get { return _describe; }
	}
	
	/**
	 * 子面板类型
	 */
	public int SubPanelType
	{
		set { _subPanelType = value; }
	    get { return _subPanelType; }
	}
	
	/**
	 * 活动概述
	 */
	public int Generalize 
	{
		set { _generalize  = value; }
	    get { return _generalize ; }
	}
	
	/**
	 * 跳转的目标系统
	 */
	public string TargetSystem
	{
		set { _targetSystem = value; }
	    get { return _targetSystem; }
	}
	
	/**
	 * 完成进度分子
	 */
	public int Numerator
	{
		set { _numerator = value; }
	    get { return _numerator; }
	}
	
	/**
	 * 完成进度分母
	 */
	public int Denominator
	{
		set { _denominator = value; }
	    get { return _denominator; }
	}
	
	/**
	 * 活动开始的时间点
	 */
	public int StartTime
	{
		set { _startTime = value; }
	    get { return _startTime; }
	}
	
	/**
	 * 活动结束时间点
	 */
	public int OverTime
	{
		set { _overTime = value; }
	    get { return _overTime; }
	}
	
	/**
	 * 子分组（子标签）
	 */
	public int SubGroup
	{
		set { _subGroup = value; }
	    get { return _subGroup; }
	}
	
	/**
	 * 主分组（主标签）
	 */
	public int MainGroup
	{
		set { _mainGroup = value; }
	    get { return _mainGroup; }
	}
	
	/**
	 * 排行榜自己的排名
	 */
	public int SelfRank
	{
		set { _selfRank = value; }
	    get { return _selfRank; }
	}
	
	/**
	 * 已领奖次数
	 */
	public int RewardedTimes
	{
		set { _rewardedTimes = value; }
	    get { return _rewardedTimes; }
	}
	
	/**
	 * 奖励状态(0:不可领奖，1：已达成未领奖，2已领奖)
	 */
	public int RewardState
	{
		set { _rewardState = value; }
	    get { return _rewardState; }
	}
	
	/**
	 * 剩余可领奖次数
	 */
	public int LeftRewardTimes
	{
		set { _leftRewardTimes = value; }
	    get { return _leftRewardTimes; }
	}
	
	/**
	 * 总共领奖次数
	 */
	public int TotalRewardTimes
	{
		set { _totalRewardTimes = value; }
	    get { return _totalRewardTimes; }
	}
	
	/**
	 * 活动特征:(1,新服活动,其他，老服活动)
	 */
	public int Age
	{
		set { _age = value; }
	    get { return _age; }
	}
	
	/**
	 * 参与活动条件
	 */
	public string Condition
	{
		set { _condition = value; }
	    get { return _condition; }
	}
	
}