using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求保存新手指导信息 message
 */
public class ReqSaveFreshGuideMessage : Message 
{
	//新手指导信息
	int _completedId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//新手指导信息
		SerializeUtils.WriteInt(stream, _completedId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//新手指导信息
		_completedId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 新手指导信息
	 */
	public int CompletedId
	{
		set { _completedId = value; }
	    get { return _completedId; }
	}
	
	
	public override int GetId() 
	{
		return 213202;
	}
}