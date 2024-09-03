using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 在售商品列表 message
 */
public class ResCommodityOnSellMessage : Message 
{
	//在售商品列表
	List<RechargeBaseInfo> _onsellList = new List<RechargeBaseInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//在售商品列表
		SerializeUtils.WriteShort(stream, (short)_onsellList.Count);

		foreach (var element in _onsellList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//在售商品列表
		int _onsellList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _onsellList_length; ++i) 
		{
			_onsellList.Add(SerializeUtils.ReadBean<RechargeBaseInfo>(stream));
		}
	}
	
	/**
	 * get 在售商品列表
	 * @return 
	 */
	public List<RechargeBaseInfo> GetOnsellList()
	{
		return _onsellList;
	}
	
	/**
	 * set 在售商品列表
	 */
	public void SetOnsellList(List<RechargeBaseInfo> onsellList)
	{
		_onsellList = onsellList;
	}
	
	
	public override int GetId() 
	{
		return 312105;
	}
}