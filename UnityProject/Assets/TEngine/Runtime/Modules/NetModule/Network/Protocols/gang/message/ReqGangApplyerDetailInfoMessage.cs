using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求获取番队申请者明细信息 message
 */
public class ReqGangApplyerDetailInfoMessage : Message 
{
	//番队id
	long _gangId;	
	//番队申请者玩家id
	long _applyerId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//番队id
		SerializeUtils.WriteLong(stream, _gangId);
		//番队申请者玩家id
		SerializeUtils.WriteLong(stream, _applyerId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//番队id
		_gangId = SerializeUtils.ReadLong(stream);
		//番队申请者玩家id
		_applyerId = SerializeUtils.ReadLong(stream);
	}
	
	/**
	 * 番队id
	 */
	public long GangId
	{
		set { _gangId = value; }
	    get { return _gangId; }
	}
	
	/**
	 * 番队申请者玩家id
	 */
	public long ApplyerId
	{
		set { _applyerId = value; }
	    get { return _applyerId; }
	}
	
	
	public override int GetId() 
	{
		return 109221;
	}
}