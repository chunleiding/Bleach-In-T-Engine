using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队申请者明细信息 message
 */
public class ResGangApplyerDetailInfoMessage : Message 
{
	//0:成功,1:番队申请人不存在
	int _res;	
	//番队申请者明细
	GangApplyerDetailInfo _applyerDetailInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0:成功,1:番队申请人不存在
		SerializeUtils.WriteInt(stream, _res);
		//番队申请者明细
		SerializeUtils.WriteBean(stream, _applyerDetailInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0:成功,1:番队申请人不存在
		_res = SerializeUtils.ReadInt(stream);
		//番队申请者明细
		_applyerDetailInfo = SerializeUtils.ReadBean<GangApplyerDetailInfo>(stream);
	}
	
	/**
	 * 0:成功,1:番队申请人不存在
	 */
	public int Res
	{
		set { _res = value; }
	    get { return _res; }
	}
	
	/**
	 * 番队申请者明细
	 */
	public GangApplyerDetailInfo ApplyerDetailInfo
	{
		set { _applyerDetailInfo = value; }
	    get { return _applyerDetailInfo; }
	}
	
	
	public override int GetId() 
	{
		return 109128;
	}
}