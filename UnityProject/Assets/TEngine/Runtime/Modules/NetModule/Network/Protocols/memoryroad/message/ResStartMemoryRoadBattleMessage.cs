using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 后端返回请求开始战斗的结果 message
 */
public class ResStartMemoryRoadBattleMessage : Message 
{
	//开始战斗是否成功[0:成功,10204:等级不足,10214:缺少角色,10261:记忆之路挑战次数不足]
	int _status;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//开始战斗是否成功[0:成功,10204:等级不足,10214:缺少角色,10261:记忆之路挑战次数不足]
		SerializeUtils.WriteInt(stream, _status);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//开始战斗是否成功[0:成功,10204:等级不足,10214:缺少角色,10261:记忆之路挑战次数不足]
		_status = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 开始战斗是否成功[0:成功,10204:等级不足,10214:缺少角色,10261:记忆之路挑战次数不足]
	 */
	public int Status
	{
		set { _status = value; }
	    get { return _status; }
	}
	
	
	public override int GetId() 
	{
		return 220101;
	}
}