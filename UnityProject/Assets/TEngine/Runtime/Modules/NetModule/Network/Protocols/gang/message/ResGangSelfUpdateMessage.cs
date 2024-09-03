using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 自己信息更新 message
 */
public class ResGangSelfUpdateMessage : Message 
{
	//仅仅自己关心的信息
	GangMemberSelfInfo _info;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//仅仅自己关心的信息
		SerializeUtils.WriteBean(stream, _info);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//仅仅自己关心的信息
		_info = SerializeUtils.ReadBean<GangMemberSelfInfo>(stream);
	}
	
	/**
	 * 仅仅自己关心的信息
	 */
	public GangMemberSelfInfo Info
	{
		set { _info = value; }
	    get { return _info; }
	}
	
	
	public override int GetId() 
	{
		return 109114;
	}
}