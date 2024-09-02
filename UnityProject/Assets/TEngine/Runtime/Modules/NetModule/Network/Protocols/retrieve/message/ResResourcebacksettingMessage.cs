using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 资源找回配置表 message
 */
public class ResResourcebacksettingMessage : Message 
{
	//开启功能完成指定关卡
	int _ConditionLevelId;	
	//开启功能玩家达到的等级
	int _ConditionPlayerLevel;	
	//资源最大找回天数
	int _MaxBackDays;	
	//需要的道具
	List<ItemInfo> _NeedItem = new List<ItemInfo>();
	//找回经验万分比
	List<int> _PercentExchange = new List<int>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//开启功能完成指定关卡
		SerializeUtils.WriteInt(stream, _ConditionLevelId);
		//开启功能玩家达到的等级
		SerializeUtils.WriteInt(stream, _ConditionPlayerLevel);
		//资源最大找回天数
		SerializeUtils.WriteInt(stream, _MaxBackDays);
		//需要的道具
		SerializeUtils.WriteShort(stream, (short)_NeedItem.Count);

		foreach (var element in _NeedItem)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//找回经验万分比
		SerializeUtils.WriteShort(stream, (short)_PercentExchange.Count);

		foreach (var element in _PercentExchange)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//开启功能完成指定关卡
		_ConditionLevelId = SerializeUtils.ReadInt(stream);
		//开启功能玩家达到的等级
		_ConditionPlayerLevel = SerializeUtils.ReadInt(stream);
		//资源最大找回天数
		_MaxBackDays = SerializeUtils.ReadInt(stream);
		//需要的道具
		int _NeedItem_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _NeedItem_length; ++i) 
		{
			_NeedItem.Add(SerializeUtils.ReadBean<ItemInfo>(stream));
		}
		//找回经验万分比
		int _PercentExchange_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _PercentExchange_length; ++i) 
		{
			_PercentExchange.Add(SerializeUtils.ReadInt(stream));
		}
	}
	
	/**
	 * 开启功能完成指定关卡
	 */
	public int ConditionLevelId
	{
		set { _ConditionLevelId = value; }
	    get { return _ConditionLevelId; }
	}
	
	/**
	 * 开启功能玩家达到的等级
	 */
	public int ConditionPlayerLevel
	{
		set { _ConditionPlayerLevel = value; }
	    get { return _ConditionPlayerLevel; }
	}
	
	/**
	 * 资源最大找回天数
	 */
	public int MaxBackDays
	{
		set { _MaxBackDays = value; }
	    get { return _MaxBackDays; }
	}
	
	/**
	 * get 需要的道具
	 * @return 
	 */
	public List<ItemInfo> GetNeedItem()
	{
		return _NeedItem;
	}
	
	/**
	 * set 需要的道具
	 */
	public void SetNeedItem(List<ItemInfo> NeedItem)
	{
		_NeedItem = NeedItem;
	}
	
	/**
	 * get 找回经验万分比
	 * @return 
	 */
	public List<int> GetPercentExchange()
	{
		return _PercentExchange;
	}
	
	/**
	 * set 找回经验万分比
	 */
	public void SetPercentExchange(List<int> PercentExchange)
	{
		_PercentExchange = PercentExchange;
	}
	
	
	public override int GetId() 
	{
		return 813103;
	}
}