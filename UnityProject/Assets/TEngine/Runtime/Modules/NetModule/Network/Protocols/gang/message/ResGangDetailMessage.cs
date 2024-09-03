using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 自己番队详细信息 message
 */
public class ResGangDetailMessage : Message 
{
	//仅仅自己关心的信息
	GangMemberSelfInfo _selfInfo;	
	//详细信息
	GangDetailInfo _detail;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//仅仅自己关心的信息
		SerializeUtils.WriteBean(stream, _selfInfo);
		//详细信息
		SerializeUtils.WriteBean(stream, _detail);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//仅仅自己关心的信息
		_selfInfo = SerializeUtils.ReadBean<GangMemberSelfInfo>(stream);
		//详细信息
		_detail = SerializeUtils.ReadBean<GangDetailInfo>(stream);
	}
	
	/**
	 * 仅仅自己关心的信息
	 */
	public GangMemberSelfInfo SelfInfo
	{
		set { _selfInfo = value; }
	    get { return _selfInfo; }
	}
	
	/**
	 * 详细信息
	 */
	public GangDetailInfo Detail
	{
		set { _detail = value; }
	    get { return _detail; }
	}
	
	
	public override int GetId() 
	{
		return 109102;
	}
}