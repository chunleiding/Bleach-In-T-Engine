using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 商店所有道具信息（上线和改变的时候会发送，前端也可主动请求） message
 */
public class ResShopInfoMessage : Message 
{
	//商店类型(1:浦原商店, 2:竞技商店)
	int _type;	
	//道具信息
	List<ShopItemInfo> _info = new List<ShopItemInfo>();
	//下次刷新时间距离当前的秒数
	int _nextRefreshTime;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//商店类型(1:浦原商店, 2:竞技商店)
		SerializeUtils.WriteInt(stream, _type);
		//道具信息
		SerializeUtils.WriteShort(stream, (short)_info.Count);

		foreach (var element in _info)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//下次刷新时间距离当前的秒数
		SerializeUtils.WriteInt(stream, _nextRefreshTime);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//商店类型(1:浦原商店, 2:竞技商店)
		_type = SerializeUtils.ReadInt(stream);
		//道具信息
		int _info_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _info_length; ++i) 
		{
			_info.Add(SerializeUtils.ReadBean<ShopItemInfo>(stream));
		}
		//下次刷新时间距离当前的秒数
		_nextRefreshTime = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 商店类型(1:浦原商店, 2:竞技商店)
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	/**
	 * get 道具信息
	 * @return 
	 */
	public List<ShopItemInfo> GetInfo()
	{
		return _info;
	}
	
	/**
	 * set 道具信息
	 */
	public void SetInfo(List<ShopItemInfo> info)
	{
		_info = info;
	}
	
	/**
	 * 下次刷新时间距离当前的秒数
	 */
	public int NextRefreshTime
	{
		set { _nextRefreshTime = value; }
	    get { return _nextRefreshTime; }
	}
	
	
	public override int GetId() 
	{
		return 104101;
	}
}