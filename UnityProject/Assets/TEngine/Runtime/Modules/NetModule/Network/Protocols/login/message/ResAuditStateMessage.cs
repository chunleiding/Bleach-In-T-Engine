using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 特殊状态开关 message
 */
public class ResAuditStateMessage : Message 
{
	//状态(0:审核中，其他:没在审核中)
	int _state;	
	//开启异步加载资源的平台
	List<string> _pfList = new List<string>();
	//版署审核游戏(渠道Chanel)
	List<string> _checkSexyChanel = new List<string>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//状态(0:审核中，其他:没在审核中)
		SerializeUtils.WriteInt(stream, _state);
		//开启异步加载资源的平台
		SerializeUtils.WriteShort(stream, (short)_pfList.Count);

		foreach (var element in _pfList)  
		{
			SerializeUtils.WriteString(stream, element);
		}
		//版署审核游戏(渠道Chanel)
		SerializeUtils.WriteShort(stream, (short)_checkSexyChanel.Count);

		foreach (var element in _checkSexyChanel)  
		{
			SerializeUtils.WriteString(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//状态(0:审核中，其他:没在审核中)
		_state = SerializeUtils.ReadInt(stream);
		//开启异步加载资源的平台
		int _pfList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _pfList_length; ++i) 
		{
			_pfList.Add(SerializeUtils.ReadString(stream));
		}
		//版署审核游戏(渠道Chanel)
		int _checkSexyChanel_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _checkSexyChanel_length; ++i) 
		{
			_checkSexyChanel.Add(SerializeUtils.ReadString(stream));
		}
	}
	
	/**
	 * 状态(0:审核中，其他:没在审核中)
	 */
	public int State
	{
		set { _state = value; }
	    get { return _state; }
	}
	
	/**
	 * get 开启异步加载资源的平台
	 * @return 
	 */
	public List<string> GetPfList()
	{
		return _pfList;
	}
	
	/**
	 * set 开启异步加载资源的平台
	 */
	public void SetPfList(List<string> pfList)
	{
		_pfList = pfList;
	}
	
	/**
	 * get 版署审核游戏(渠道Chanel)
	 * @return 
	 */
	public List<string> GetCheckSexyChanel()
	{
		return _checkSexyChanel;
	}
	
	/**
	 * set 版署审核游戏(渠道Chanel)
	 */
	public void SetCheckSexyChanel(List<string> checkSexyChanel)
	{
		_checkSexyChanel = checkSexyChanel;
	}
	
	
	public override int GetId() 
	{
		return 100211;
	}
}