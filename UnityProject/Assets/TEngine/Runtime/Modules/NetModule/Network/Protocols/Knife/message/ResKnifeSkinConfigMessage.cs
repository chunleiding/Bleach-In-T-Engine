using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 斩魄刀皮肤阶级和天数价格 message
 */
public class ResKnifeSkinConfigMessage : Message 
{
	//热更内容
	List<KnifeSkinConfigInfo> _knifeSkinConfigList = new List<KnifeSkinConfigInfo>();
	//继承人物属性万分比
	int _percentValue;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//热更内容
		SerializeUtils.WriteShort(stream, (short)_knifeSkinConfigList.Count);

		foreach (var element in _knifeSkinConfigList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//继承人物属性万分比
		SerializeUtils.WriteInt(stream, _percentValue);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//热更内容
		int _knifeSkinConfigList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _knifeSkinConfigList_length; ++i) 
		{
			_knifeSkinConfigList.Add(SerializeUtils.ReadBean<KnifeSkinConfigInfo>(stream));
		}
		//继承人物属性万分比
		_percentValue = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * get 热更内容
	 * @return 
	 */
	public List<KnifeSkinConfigInfo> GetKnifeSkinConfigList()
	{
		return _knifeSkinConfigList;
	}
	
	/**
	 * set 热更内容
	 */
	public void SetKnifeSkinConfigList(List<KnifeSkinConfigInfo> knifeSkinConfigList)
	{
		_knifeSkinConfigList = knifeSkinConfigList;
	}
	
	/**
	 * 继承人物属性万分比
	 */
	public int PercentValue
	{
		set { _percentValue = value; }
	    get { return _percentValue; }
	}
	
	
	public override int GetId() 
	{
		return 816106;
	}
}