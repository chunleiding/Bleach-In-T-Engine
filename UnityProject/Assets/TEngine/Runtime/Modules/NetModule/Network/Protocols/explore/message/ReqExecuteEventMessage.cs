using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求执行事件 message
 */
public class ReqExecuteEventMessage : Message 
{
	//关卡id
	int _levelId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//关卡id
		SerializeUtils.WriteInt(stream, _levelId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//关卡id
		_levelId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 关卡id
	 */
	public int LevelId
	{
		set { _levelId = value; }
	    get { return _levelId; }
	}
	
	
	public override int GetId() 
	{
		return 831110;
	}
}