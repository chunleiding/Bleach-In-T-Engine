using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 返回全部通关信息 message
 */
public class ResClearanceInfosMessage : Message 
{
	//通关信息
	List<ClearanceInfo> _clearanceInfo = new List<ClearanceInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//通关信息
		SerializeUtils.WriteShort(stream, (short)_clearanceInfo.Count);

		foreach (var element in _clearanceInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//通关信息
		int _clearanceInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _clearanceInfo_length; ++i) 
		{
			_clearanceInfo.Add(SerializeUtils.ReadBean<ClearanceInfo>(stream));
		}
	}
	
	/**
	 * get 通关信息
	 * @return 
	 */
	public List<ClearanceInfo> GetClearanceInfo()
	{
		return _clearanceInfo;
	}
	
	/**
	 * set 通关信息
	 */
	public void SetClearanceInfo(List<ClearanceInfo> clearanceInfo)
	{
		_clearanceInfo = clearanceInfo;
	}
	
	
	public override int GetId() 
	{
		return 102300;
	}
}