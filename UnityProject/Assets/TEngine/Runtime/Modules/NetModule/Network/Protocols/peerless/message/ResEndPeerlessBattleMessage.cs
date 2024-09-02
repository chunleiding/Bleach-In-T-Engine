using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 回复战斗结束消息 message
 */
public class ResEndPeerlessBattleMessage : Message 
{
	//0:成功 1：失败
	int _result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0:成功 1：失败
		SerializeUtils.WriteInt(stream, _result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0:成功 1：失败
		_result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0:成功 1：失败
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	
	public override int GetId() 
	{
		return 817103;
	}
}