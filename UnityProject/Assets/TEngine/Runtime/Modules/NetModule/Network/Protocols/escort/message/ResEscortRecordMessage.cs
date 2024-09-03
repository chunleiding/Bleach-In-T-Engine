using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 护送记录回复 message
 */
public class ResEscortRecordMessage : Message 
{
	//玩家自己的打劫成功记录
	List<string> _record = new List<string>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//玩家自己的打劫成功记录
		SerializeUtils.WriteShort(stream, (short)_record.Count);

		foreach (var element in _record)  
		{
			SerializeUtils.WriteString(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//玩家自己的打劫成功记录
		int _record_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _record_length; ++i) 
		{
			_record.Add(SerializeUtils.ReadString(stream));
		}
	}
	
	/**
	 * get 玩家自己的打劫成功记录
	 * @return 
	 */
	public List<string> GetRecord()
	{
		return _record;
	}
	
	/**
	 * set 玩家自己的打劫成功记录
	 */
	public void SetRecord(List<string> record)
	{
		_record = record;
	}
	
	
	public override int GetId() 
	{
		return 810107;
	}
}