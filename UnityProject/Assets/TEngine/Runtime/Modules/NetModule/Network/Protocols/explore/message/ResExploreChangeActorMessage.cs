using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 换人回复 message
 */
public class ResExploreChangeActorMessage : Message 
{
	//成功或失败 0：成功
	int _isSuccess;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//成功或失败 0：成功
		SerializeUtils.WriteInt(stream, _isSuccess);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//成功或失败 0：成功
		_isSuccess = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 成功或失败 0：成功
	 */
	public int IsSuccess
	{
		set { _isSuccess = value; }
	    get { return _isSuccess; }
	}
	
	
	public override int GetId() 
	{
		return 831105;
	}
}