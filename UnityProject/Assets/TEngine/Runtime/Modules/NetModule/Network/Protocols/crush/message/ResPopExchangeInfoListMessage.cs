using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 回复消消乐兑换列表 message
 */
public class ResPopExchangeInfoListMessage : Message 
{
	//兑换列表
	List<PopExchangeInfo> _exchangeInfoList = new List<PopExchangeInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//兑换列表
		SerializeUtils.WriteShort(stream, (short)_exchangeInfoList.Count);

		foreach (var element in _exchangeInfoList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//兑换列表
		int _exchangeInfoList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _exchangeInfoList_length; ++i) 
		{
			_exchangeInfoList.Add(SerializeUtils.ReadBean<PopExchangeInfo>(stream));
		}
	}
	
	/**
	 * get 兑换列表
	 * @return 
	 */
	public List<PopExchangeInfo> GetExchangeInfoList()
	{
		return _exchangeInfoList;
	}
	
	/**
	 * set 兑换列表
	 */
	public void SetExchangeInfoList(List<PopExchangeInfo> exchangeInfoList)
	{
		_exchangeInfoList = exchangeInfoList;
	}
	
	
	public override int GetId() 
	{
		return 821103;
	}
}