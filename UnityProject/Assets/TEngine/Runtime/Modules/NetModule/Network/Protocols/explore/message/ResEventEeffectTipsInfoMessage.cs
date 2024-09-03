using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 事件关卡效果提示 message
 */
public class ResEventEeffectTipsInfoMessage : Message 
{
	//触发事件结果信息
	List<TipsInfoBean> _eventEeffectTips = new List<TipsInfoBean>();
	//关卡id
	int _levelId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//触发事件结果信息
		SerializeUtils.WriteShort(stream, (short)_eventEeffectTips.Count);

		foreach (var element in _eventEeffectTips)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//关卡id
		SerializeUtils.WriteInt(stream, _levelId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//触发事件结果信息
		int _eventEeffectTips_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _eventEeffectTips_length; ++i) 
		{
			_eventEeffectTips.Add(SerializeUtils.ReadBean<TipsInfoBean>(stream));
		}
		//关卡id
		_levelId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * get 触发事件结果信息
	 * @return 
	 */
	public List<TipsInfoBean> GetEventEeffectTips()
	{
		return _eventEeffectTips;
	}
	
	/**
	 * set 触发事件结果信息
	 */
	public void SetEventEeffectTips(List<TipsInfoBean> eventEeffectTips)
	{
		_eventEeffectTips = eventEeffectTips;
	}
	
	/**
	 * 关卡id
	 */
	public int LevelId
	{
		set { _levelId = value; }
	    get { return _levelId; }
	}
	
	
	public override int GetId() 
	{
		return 831109;
	}
}