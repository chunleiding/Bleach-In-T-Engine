using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 一护试炼基础信息 message
 */
public class ResIchigoTrialBaseInfoMessage : Message 
{
	//活动是否开启 0：未开启；1：开启
	int _isOpen;	
	//可购买次数列表
	List<int> _buyTimeList = new List<int>();
	//倒计时变红时间
	int _timeAlert;	
	//本期活动结束时间
	string _thisPeriodEndTime;	
	//下次活动时间
	string _nextTime;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//活动是否开启 0：未开启；1：开启
		SerializeUtils.WriteInt(stream, _isOpen);
		//可购买次数列表
		SerializeUtils.WriteShort(stream, (short)_buyTimeList.Count);

		foreach (var element in _buyTimeList)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
		//倒计时变红时间
		SerializeUtils.WriteInt(stream, _timeAlert);
		//本期活动结束时间
		SerializeUtils.WriteString(stream, _thisPeriodEndTime);
		//下次活动时间
		SerializeUtils.WriteString(stream, _nextTime);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//活动是否开启 0：未开启；1：开启
		_isOpen = SerializeUtils.ReadInt(stream);
		//可购买次数列表
		int _buyTimeList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _buyTimeList_length; ++i) 
		{
			_buyTimeList.Add(SerializeUtils.ReadInt(stream));
		}
		//倒计时变红时间
		_timeAlert = SerializeUtils.ReadInt(stream);
		//本期活动结束时间
		_thisPeriodEndTime = SerializeUtils.ReadString(stream);
		//下次活动时间
		_nextTime = SerializeUtils.ReadString(stream);
	}
	
	/**
	 * 活动是否开启 0：未开启；1：开启
	 */
	public int IsOpen
	{
		set { _isOpen = value; }
	    get { return _isOpen; }
	}
	
	/**
	 * get 可购买次数列表
	 * @return 
	 */
	public List<int> GetBuyTimeList()
	{
		return _buyTimeList;
	}
	
	/**
	 * set 可购买次数列表
	 */
	public void SetBuyTimeList(List<int> buyTimeList)
	{
		_buyTimeList = buyTimeList;
	}
	
	/**
	 * 倒计时变红时间
	 */
	public int TimeAlert
	{
		set { _timeAlert = value; }
	    get { return _timeAlert; }
	}
	
	/**
	 * 本期活动结束时间
	 */
	public string ThisPeriodEndTime
	{
		set { _thisPeriodEndTime = value; }
	    get { return _thisPeriodEndTime; }
	}
	
	/**
	 * 下次活动时间
	 */
	public string NextTime
	{
		set { _nextTime = value; }
	    get { return _nextTime; }
	}
	
	
	public override int GetId() 
	{
		return 825100;
	}
}