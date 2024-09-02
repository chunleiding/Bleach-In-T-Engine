using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队成员祈愿列表 message
 */
public class ResGangPrayListMessage : Message 
{
	//番队成员祈愿列表
	List<GangPrayInfo> _gangPrayList = new List<GangPrayInfo>();
	//自己是否领取 0：没领取 1：已领
	int _isReward;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//番队成员祈愿列表
		SerializeUtils.WriteShort(stream, (short)_gangPrayList.Count);

		foreach (var element in _gangPrayList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//自己是否领取 0：没领取 1：已领
		SerializeUtils.WriteInt(stream, _isReward);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//番队成员祈愿列表
		int _gangPrayList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _gangPrayList_length; ++i) 
		{
			_gangPrayList.Add(SerializeUtils.ReadBean<GangPrayInfo>(stream));
		}
		//自己是否领取 0：没领取 1：已领
		_isReward = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * get 番队成员祈愿列表
	 * @return 
	 */
	public List<GangPrayInfo> GetGangPrayList()
	{
		return _gangPrayList;
	}
	
	/**
	 * set 番队成员祈愿列表
	 */
	public void SetGangPrayList(List<GangPrayInfo> gangPrayList)
	{
		_gangPrayList = gangPrayList;
	}
	
	/**
	 * 自己是否领取 0：没领取 1：已领
	 */
	public int IsReward
	{
		set { _isReward = value; }
	    get { return _isReward; }
	}
	
	
	public override int GetId() 
	{
		return 109257;
	}
}