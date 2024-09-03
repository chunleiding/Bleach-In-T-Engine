using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求升级或者升阶 message
 */
public class ReqUpGradeMessage : Message 
{
	//英雄id
	int _heroId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//英雄id
		SerializeUtils.WriteInt(stream, _heroId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//英雄id
		_heroId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 英雄id
	 */
	public int HeroId
	{
		set { _heroId = value; }
	    get { return _heroId; }
	}
	
	
	public override int GetId() 
	{
		return 824102;
	}
}