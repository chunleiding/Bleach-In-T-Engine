using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 增加单场竞技场被挑战纪录 message
 */
public class ResAddArenaDefendInfoMessage : Message 
{
	//竞技场被挑战纪录列表
	ArenaDefendInfo _arenaDefendInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//竞技场被挑战纪录列表
		SerializeUtils.WriteBean(stream, _arenaDefendInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//竞技场被挑战纪录列表
		_arenaDefendInfo = SerializeUtils.ReadBean<ArenaDefendInfo>(stream);
	}
	
	/**
	 * 竞技场被挑战纪录列表
	 */
	public ArenaDefendInfo ArenaDefendInfo
	{
		set { _arenaDefendInfo = value; }
	    get { return _arenaDefendInfo; }
	}
	
	
	public override int GetId() 
	{
		return 206111;
	}
}