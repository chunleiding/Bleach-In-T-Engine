using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 单条图鉴刷新时 message
 */
public class ResArchiveInfoMessage : Message 
{
	//图鉴信息更新
	ArchiveInfo _ArchiveInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//图鉴信息更新
		SerializeUtils.WriteBean(stream, _ArchiveInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//图鉴信息更新
		_ArchiveInfo = SerializeUtils.ReadBean<ArchiveInfo>(stream);
	}
	
	/**
	 * 图鉴信息更新
	 */
	public ArchiveInfo ArchiveInfo
	{
		set { _ArchiveInfo = value; }
	    get { return _ArchiveInfo; }
	}
	
	
	public override int GetId() 
	{
		return 829101;
	}
}