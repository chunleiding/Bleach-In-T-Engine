using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 灵骸升级结果消息 message
 */
public class ResSoulSkeletonLevelUpMessage : Message 
{
	//0:成功;1:系统未开放;2:已达到最高等级;3:所需材料不足
	int _result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0:成功;1:系统未开放;2:已达到最高等级;3:所需材料不足
		SerializeUtils.WriteInt(stream, _result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0:成功;1:系统未开放;2:已达到最高等级;3:所需材料不足
		_result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0:成功;1:系统未开放;2:已达到最高等级;3:所需材料不足
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	
	public override int GetId() 
	{
		return 809103;
	}
}