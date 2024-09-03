using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 回复交换结果 message
 */
public class ResSwapResultMessage : Message 
{
	//每步消除列表
	List<PopStepInfo> _clearStepList = new List<PopStepInfo>();
	//交换结果(0:成功,1:步数不够,2:失败,3:其他错误)
	int _result;	
	//死局(0:不是,1:是)
	int _die;	
	//最终地图信息
	List<int> _mapInfo = new List<int>();
	//最终积分
	int _score;	
	//最终剩余步数
	int _stepNum;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//每步消除列表
		SerializeUtils.WriteShort(stream, (short)_clearStepList.Count);

		foreach (var element in _clearStepList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//交换结果(0:成功,1:步数不够,2:失败,3:其他错误)
		SerializeUtils.WriteInt(stream, _result);
		//死局(0:不是,1:是)
		SerializeUtils.WriteInt(stream, _die);
		//最终地图信息
		SerializeUtils.WriteShort(stream, (short)_mapInfo.Count);

		foreach (var element in _mapInfo)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
		//最终积分
		SerializeUtils.WriteInt(stream, _score);
		//最终剩余步数
		SerializeUtils.WriteInt(stream, _stepNum);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//每步消除列表
		int _clearStepList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _clearStepList_length; ++i) 
		{
			_clearStepList.Add(SerializeUtils.ReadBean<PopStepInfo>(stream));
		}
		//交换结果(0:成功,1:步数不够,2:失败,3:其他错误)
		_result = SerializeUtils.ReadInt(stream);
		//死局(0:不是,1:是)
		_die = SerializeUtils.ReadInt(stream);
		//最终地图信息
		int _mapInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _mapInfo_length; ++i) 
		{
			_mapInfo.Add(SerializeUtils.ReadInt(stream));
		}
		//最终积分
		_score = SerializeUtils.ReadInt(stream);
		//最终剩余步数
		_stepNum = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * get 每步消除列表
	 * @return 
	 */
	public List<PopStepInfo> GetClearStepList()
	{
		return _clearStepList;
	}
	
	/**
	 * set 每步消除列表
	 */
	public void SetClearStepList(List<PopStepInfo> clearStepList)
	{
		_clearStepList = clearStepList;
	}
	
	/**
	 * 交换结果(0:成功,1:步数不够,2:失败,3:其他错误)
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * 死局(0:不是,1:是)
	 */
	public int Die
	{
		set { _die = value; }
	    get { return _die; }
	}
	
	/**
	 * get 最终地图信息
	 * @return 
	 */
	public List<int> GetMapInfo()
	{
		return _mapInfo;
	}
	
	/**
	 * set 最终地图信息
	 */
	public void SetMapInfo(List<int> mapInfo)
	{
		_mapInfo = mapInfo;
	}
	
	/**
	 * 最终积分
	 */
	public int Score
	{
		set { _score = value; }
	    get { return _score; }
	}
	
	/**
	 * 最终剩余步数
	 */
	public int StepNum
	{
		set { _stepNum = value; }
	    get { return _stepNum; }
	}
	
	
	public override int GetId() 
	{
		return 821102;
	}
}