using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 新增玩家番队申请(同步申请信息) message
 */
public class ResAddGangApplyMessage : Message 
{
	//番队申请者信息
	GangApplyerInfo _applyerInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//番队申请者信息
		SerializeUtils.WriteBean(stream, _applyerInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//番队申请者信息
		_applyerInfo = SerializeUtils.ReadBean<GangApplyerInfo>(stream);
	}
	
	/**
	 * 番队申请者信息
	 */
	public GangApplyerInfo ApplyerInfo
	{
		set { _applyerInfo = value; }
	    get { return _applyerInfo; }
	}
	
	
	public override int GetId() 
	{
		return 109118;
	}
}