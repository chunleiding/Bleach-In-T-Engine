using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 接受玩家角色星数对应提升的百分比 message
 */
public class ResPercentageListMessage : Message 
{
	//开启等级
	int _needLevel;	
	//崩玉之力总星数提升属性百分比(星数,万分比；星数,万分比；。。。。。)
	List<PercentageInfo> _totalPercentageInfo = new List<PercentageInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//开启等级
		SerializeUtils.WriteInt(stream, _needLevel);
		//崩玉之力总星数提升属性百分比(星数,万分比；星数,万分比；。。。。。)
		SerializeUtils.WriteShort(stream, (short)_totalPercentageInfo.Count);

		foreach (var element in _totalPercentageInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//开启等级
		_needLevel = SerializeUtils.ReadInt(stream);
		//崩玉之力总星数提升属性百分比(星数,万分比；星数,万分比；。。。。。)
		int _totalPercentageInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _totalPercentageInfo_length; ++i) 
		{
			_totalPercentageInfo.Add(SerializeUtils.ReadBean<PercentageInfo>(stream));
		}
	}
	
	/**
	 * 开启等级
	 */
	public int NeedLevel
	{
		set { _needLevel = value; }
	    get { return _needLevel; }
	}
	
	/**
	 * get 崩玉之力总星数提升属性百分比(星数,万分比；星数,万分比；。。。。。)
	 * @return 
	 */
	public List<PercentageInfo> GetTotalPercentageInfo()
	{
		return _totalPercentageInfo;
	}
	
	/**
	 * set 崩玉之力总星数提升属性百分比(星数,万分比；星数,万分比；。。。。。)
	 */
	public void SetTotalPercentageInfo(List<PercentageInfo> totalPercentageInfo)
	{
		_totalPercentageInfo = totalPercentageInfo;
	}
	
	
	public override int GetId() 
	{
		return 824101;
	}
}