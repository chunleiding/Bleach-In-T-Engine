using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 回复消消乐数据消息 message
 */
public class ResPopInfoMessage : Message 
{
	//可操作步数
	int _stepNum;	
	//积分
	int _score;	
	//地图数据
	List<int> _mapInfo = new List<int>();
	//充值数据与步数比例
	int _payStepRatio;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//可操作步数
		SerializeUtils.WriteInt(stream, _stepNum);
		//积分
		SerializeUtils.WriteInt(stream, _score);
		//地图数据
		SerializeUtils.WriteShort(stream, (short)_mapInfo.Count);

		foreach (var element in _mapInfo)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
		//充值数据与步数比例
		SerializeUtils.WriteInt(stream, _payStepRatio);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//可操作步数
		_stepNum = SerializeUtils.ReadInt(stream);
		//积分
		_score = SerializeUtils.ReadInt(stream);
		//地图数据
		int _mapInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _mapInfo_length; ++i) 
		{
			_mapInfo.Add(SerializeUtils.ReadInt(stream));
		}
		//充值数据与步数比例
		_payStepRatio = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 可操作步数
	 */
	public int StepNum
	{
		set { _stepNum = value; }
	    get { return _stepNum; }
	}
	
	/**
	 * 积分
	 */
	public int Score
	{
		set { _score = value; }
	    get { return _score; }
	}
	
	/**
	 * get 地图数据
	 * @return 
	 */
	public List<int> GetMapInfo()
	{
		return _mapInfo;
	}
	
	/**
	 * set 地图数据
	 */
	public void SetMapInfo(List<int> mapInfo)
	{
		_mapInfo = mapInfo;
	}
	
	/**
	 * 充值数据与步数比例
	 */
	public int PayStepRatio
	{
		set { _payStepRatio = value; }
	    get { return _payStepRatio; }
	}
	
	
	public override int GetId() 
	{
		return 821100;
	}
}