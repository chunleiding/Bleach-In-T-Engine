using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队成员祈愿信息
 */
public class GangPrayInfo : IMessageSerialize 
{
	//祈愿倒计时：秒
	int _prayLeftTime;	
	//番队玩家id
	long _playerId;	
	//哪些人给我赠送了道具
	List<long> _givePrayPlayerIds = new List<long>();
	//祈愿道具信息
	GangPrayItem _gangPrayItem;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//祈愿倒计时：秒
		SerializeUtils.WriteInt(stream, _prayLeftTime);
		//番队玩家id
		SerializeUtils.WriteLong(stream, _playerId);
		//哪些人给我赠送了道具
		SerializeUtils.WriteShort(stream, (short)_givePrayPlayerIds.Count);

		foreach (var element in _givePrayPlayerIds)  
		{
			SerializeUtils.WriteLong(stream, element);
		}
		//祈愿道具信息
		SerializeUtils.WriteBean(stream, _gangPrayItem);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//祈愿倒计时：秒
		_prayLeftTime = SerializeUtils.ReadInt(stream);
		//番队玩家id
		_playerId = SerializeUtils.ReadLong(stream);
		//哪些人给我赠送了道具
		int _givePrayPlayerIds_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _givePrayPlayerIds_length; ++i) 
		{
			_givePrayPlayerIds.Add(SerializeUtils.ReadLong(stream));
		}
		//祈愿道具信息
		_gangPrayItem = SerializeUtils.ReadBean<GangPrayItem>(stream);
	}
	
	/**
	 * 祈愿倒计时：秒
	 */
	public int PrayLeftTime
	{
		set { _prayLeftTime = value; }
	    get { return _prayLeftTime; }
	}
	
	/**
	 * 番队玩家id
	 */
	public long PlayerId
	{
		set { _playerId = value; }
	    get { return _playerId; }
	}
	
	/**
	 * get 哪些人给我赠送了道具
	 * @return 
	 */
	public List<long> GetGivePrayPlayerIds()
	{
		return _givePrayPlayerIds;
	}
	
	/**
	 * set 哪些人给我赠送了道具
	 */
	public void SetGivePrayPlayerIds(List<long> givePrayPlayerIds)
	{
		_givePrayPlayerIds = givePrayPlayerIds;
	}
	
	/**
	 * 祈愿道具信息
	 */
	public GangPrayItem GangPrayItem
	{
		set { _gangPrayItem = value; }
	    get { return _gangPrayItem; }
	}
	
}