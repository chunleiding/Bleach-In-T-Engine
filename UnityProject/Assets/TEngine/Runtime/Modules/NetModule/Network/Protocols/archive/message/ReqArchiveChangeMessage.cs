using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 图鉴状态改变 message
 */
public class ReqArchiveChangeMessage : Message 
{
	//状态改变的图鉴id
	int _archiveId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//状态改变的图鉴id
		SerializeUtils.WriteInt(stream, _archiveId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//状态改变的图鉴id
		_archiveId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 状态改变的图鉴id
	 */
	public int ArchiveId
	{
		set { _archiveId = value; }
	    get { return _archiveId; }
	}
	
	
	public override int GetId() 
	{
		return 829102;
	}
}