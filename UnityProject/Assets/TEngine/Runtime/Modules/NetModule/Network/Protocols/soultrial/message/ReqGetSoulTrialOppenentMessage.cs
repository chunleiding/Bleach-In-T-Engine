using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 获取对手信息 message
 */
public class ReqGetSoulTrialOppenentMessage : Message 
{
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
	}
	
	
	public override int GetId() 
	{
		return 204206;
	}
}