using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 回复所有的对战记录 message
 */
public class ResPeerlessFightRecordsMessage : Message 
{
	//对战记录列表
	List<TopArenaFightRecord> _fightRecords = new List<TopArenaFightRecord>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//对战记录列表
		SerializeUtils.WriteShort(stream, (short)_fightRecords.Count);

		foreach (var element in _fightRecords)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//对战记录列表
		int _fightRecords_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _fightRecords_length; ++i) 
		{
			_fightRecords.Add(SerializeUtils.ReadBean<TopArenaFightRecord>(stream));
		}
	}
	
	/**
	 * get 对战记录列表
	 * @return 
	 */
	public List<TopArenaFightRecord> GetFightRecords()
	{
		return _fightRecords;
	}
	
	/**
	 * set 对战记录列表
	 */
	public void SetFightRecords(List<TopArenaFightRecord> fightRecords)
	{
		_fightRecords = fightRecords;
	}
	
	
	public override int GetId() 
	{
		return 817109;
	}
}