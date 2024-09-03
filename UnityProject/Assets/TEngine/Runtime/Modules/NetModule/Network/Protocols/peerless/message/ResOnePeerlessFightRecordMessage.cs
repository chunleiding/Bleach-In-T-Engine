using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 单个挑战记录 message
 */
public class ResOnePeerlessFightRecordMessage : Message 
{
	//对战记录
	TopArenaFightRecord _fightRecord;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//对战记录
		SerializeUtils.WriteBean(stream, _fightRecord);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//对战记录
		_fightRecord = SerializeUtils.ReadBean<TopArenaFightRecord>(stream);
	}
	
	/**
	 * 对战记录
	 */
	public TopArenaFightRecord FightRecord
	{
		set { _fightRecord = value; }
	    get { return _fightRecord; }
	}
	
	
	public override int GetId() 
	{
		return 817113;
	}
}