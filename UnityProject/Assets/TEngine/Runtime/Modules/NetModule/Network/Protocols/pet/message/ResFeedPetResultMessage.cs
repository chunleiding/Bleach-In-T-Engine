using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 喂食回复 message
 */
public class ResFeedPetResultMessage : Message 
{
	//0成功 大于0 其他原因
	int _feedResult;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0成功 大于0 其他原因
		SerializeUtils.WriteInt(stream, _feedResult);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0成功 大于0 其他原因
		_feedResult = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0成功 大于0 其他原因
	 */
	public int FeedResult
	{
		set { _feedResult = value; }
	    get { return _feedResult; }
	}
	
	
	public override int GetId() 
	{
		return 822104;
	}
}