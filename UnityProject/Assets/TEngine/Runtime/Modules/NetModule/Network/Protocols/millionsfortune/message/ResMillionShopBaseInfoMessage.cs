using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 百万商店配置表信息 message
 */
public class ResMillionShopBaseInfoMessage : Message 
{
	//商品列表
	List<ShopBaseInfo> _infos = new List<ShopBaseInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//商品列表
		SerializeUtils.WriteShort(stream, (short)_infos.Count);

		foreach (var element in _infos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//商品列表
		int _infos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _infos_length; ++i) 
		{
			_infos.Add(SerializeUtils.ReadBean<ShopBaseInfo>(stream));
		}
	}
	
	/**
	 * get 商品列表
	 * @return 
	 */
	public List<ShopBaseInfo> GetInfos()
	{
		return _infos;
	}
	
	/**
	 * set 商品列表
	 */
	public void SetInfos(List<ShopBaseInfo> infos)
	{
		_infos = infos;
	}
	
	
	public override int GetId() 
	{
		return 316206;
	}
}