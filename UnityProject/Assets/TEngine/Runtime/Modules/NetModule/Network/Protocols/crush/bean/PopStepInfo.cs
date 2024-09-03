using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 每步的数据（包含消除和生成的元素）
 */
public class PopStepInfo : IMessageSerialize 
{
	//消除的元素坐标列表
	List<int> _clearElementIndexList = new List<int>();
	//生成的元素列表
	List<PopElementInfo> _generatedElementList = new List<PopElementInfo>();
	//每步增加的积分
	int _addScore;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//消除的元素坐标列表
		SerializeUtils.WriteShort(stream, (short)_clearElementIndexList.Count);

		foreach (var element in _clearElementIndexList)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
		//生成的元素列表
		SerializeUtils.WriteShort(stream, (short)_generatedElementList.Count);

		foreach (var element in _generatedElementList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//每步增加的积分
		SerializeUtils.WriteInt(stream, _addScore);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//消除的元素坐标列表
		int _clearElementIndexList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _clearElementIndexList_length; ++i) 
		{
			_clearElementIndexList.Add(SerializeUtils.ReadInt(stream));
		}
		//生成的元素列表
		int _generatedElementList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _generatedElementList_length; ++i) 
		{
			_generatedElementList.Add(SerializeUtils.ReadBean<PopElementInfo>(stream));
		}
		//每步增加的积分
		_addScore = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * get 消除的元素坐标列表
	 * @return 
	 */
	public List<int> GetClearElementIndexList()
	{
		return _clearElementIndexList;
	}
	
	/**
	 * set 消除的元素坐标列表
	 */
	public void SetClearElementIndexList(List<int> clearElementIndexList)
	{
		_clearElementIndexList = clearElementIndexList;
	}
	
	/**
	 * get 生成的元素列表
	 * @return 
	 */
	public List<PopElementInfo> GetGeneratedElementList()
	{
		return _generatedElementList;
	}
	
	/**
	 * set 生成的元素列表
	 */
	public void SetGeneratedElementList(List<PopElementInfo> generatedElementList)
	{
		_generatedElementList = generatedElementList;
	}
	
	/**
	 * 每步增加的积分
	 */
	public int AddScore
	{
		set { _addScore = value; }
	    get { return _addScore; }
	}
	
}