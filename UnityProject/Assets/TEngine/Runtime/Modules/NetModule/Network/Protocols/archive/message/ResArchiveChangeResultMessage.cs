using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 图鉴状态改变结果 message
 */
public class ResArchiveChangeResultMessage : Message 
{
	//图鉴id
	int _archiveId;	
	//结果:0成功；大于0 失败
	int _result;	
	//最新状态
	int _state;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//图鉴id
		SerializeUtils.WriteInt(stream, _archiveId);
		//结果:0成功；大于0 失败
		SerializeUtils.WriteInt(stream, _result);
		//最新状态
		SerializeUtils.WriteInt(stream, _state);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//图鉴id
		_archiveId = SerializeUtils.ReadInt(stream);
		//结果:0成功；大于0 失败
		_result = SerializeUtils.ReadInt(stream);
		//最新状态
		_state = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 图鉴id
	 */
	public int ArchiveId
	{
		set { _archiveId = value; }
	    get { return _archiveId; }
	}
	
	/**
	 * 结果:0成功；大于0 失败
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * 最新状态
	 */
	public int State
	{
		set { _state = value; }
	    get { return _state; }
	}
	
	
	public override int GetId() 
	{
		return 829103;
	}
}