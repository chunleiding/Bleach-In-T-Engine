using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 提示信息
 */
public class TipsInfoBean : IMessageSerialize 
{
	//文本展示效果
	int _textEffect;	
	//关卡id(前端用于这个去找当前关卡的下一个关卡的字母)、随机事件唯一值(前端根据这个去展示已经随机到的事件)
	int _targetId;	
	//参数列表1
	List<int> _paramOneList = new List<int>();
	//参数列表2
	List<int> _paramTwoList = new List<int>();
	//消除的buff
	List<BuffTipBean> _cleanBuffList = new List<BuffTipBean>();
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//文本展示效果
		SerializeUtils.WriteInt(stream, _textEffect);
		//关卡id(前端用于这个去找当前关卡的下一个关卡的字母)、随机事件唯一值(前端根据这个去展示已经随机到的事件)
		SerializeUtils.WriteInt(stream, _targetId);
		//参数列表1
		SerializeUtils.WriteShort(stream, (short)_paramOneList.Count);

		foreach (var element in _paramOneList)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
		//参数列表2
		SerializeUtils.WriteShort(stream, (short)_paramTwoList.Count);

		foreach (var element in _paramTwoList)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
		//消除的buff
		SerializeUtils.WriteShort(stream, (short)_cleanBuffList.Count);

		foreach (var element in _cleanBuffList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//文本展示效果
		_textEffect = SerializeUtils.ReadInt(stream);
		//关卡id(前端用于这个去找当前关卡的下一个关卡的字母)、随机事件唯一值(前端根据这个去展示已经随机到的事件)
		_targetId = SerializeUtils.ReadInt(stream);
		//参数列表1
		int _paramOneList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _paramOneList_length; ++i) 
		{
			_paramOneList.Add(SerializeUtils.ReadInt(stream));
		}
		//参数列表2
		int _paramTwoList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _paramTwoList_length; ++i) 
		{
			_paramTwoList.Add(SerializeUtils.ReadInt(stream));
		}
		//消除的buff
		int _cleanBuffList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _cleanBuffList_length; ++i) 
		{
			_cleanBuffList.Add(SerializeUtils.ReadBean<BuffTipBean>(stream));
		}
	}
	
	/**
	 * 文本展示效果
	 */
	public int TextEffect
	{
		set { _textEffect = value; }
	    get { return _textEffect; }
	}
	
	/**
	 * 关卡id(前端用于这个去找当前关卡的下一个关卡的字母)、随机事件唯一值(前端根据这个去展示已经随机到的事件)
	 */
	public int TargetId
	{
		set { _targetId = value; }
	    get { return _targetId; }
	}
	
	/**
	 * get 参数列表1
	 * @return 
	 */
	public List<int> GetParamOneList()
	{
		return _paramOneList;
	}
	
	/**
	 * set 参数列表1
	 */
	public void SetParamOneList(List<int> paramOneList)
	{
		_paramOneList = paramOneList;
	}
	
	/**
	 * get 参数列表2
	 * @return 
	 */
	public List<int> GetParamTwoList()
	{
		return _paramTwoList;
	}
	
	/**
	 * set 参数列表2
	 */
	public void SetParamTwoList(List<int> paramTwoList)
	{
		_paramTwoList = paramTwoList;
	}
	
	/**
	 * get 消除的buff
	 * @return 
	 */
	public List<BuffTipBean> GetCleanBuffList()
	{
		return _cleanBuffList;
	}
	
	/**
	 * set 消除的buff
	 */
	public void SetCleanBuffList(List<BuffTipBean> cleanBuffList)
	{
		_cleanBuffList = cleanBuffList;
	}
	
}