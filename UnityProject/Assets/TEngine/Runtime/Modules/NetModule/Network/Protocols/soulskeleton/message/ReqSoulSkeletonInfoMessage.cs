using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求灵骸信息 message
 */
public class ReqSoulSkeletonInfoMessage : Message 
{
	//月卡存在状态(0:增加,1删除)
	int _monthCardState;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//月卡存在状态(0:增加,1删除)
		SerializeUtils.WriteInt(stream, _monthCardState);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//月卡存在状态(0:增加,1删除)
		_monthCardState = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 月卡存在状态(0:增加,1删除)
	 */
	public int MonthCardState
	{
		set { _monthCardState = value; }
	    get { return _monthCardState; }
	}
	
	
	public override int GetId() 
	{
		return 809104;
	}
}