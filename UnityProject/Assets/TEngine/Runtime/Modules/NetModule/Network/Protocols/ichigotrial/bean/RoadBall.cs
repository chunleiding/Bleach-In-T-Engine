using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 一户试炼球身份证
 */
public class RoadBall : IMessageSerialize 
{
	//球的配置ID
	int _ballId;	
	//该球唯一标识
	string _uid;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//球的配置ID
		SerializeUtils.WriteInt(stream, _ballId);
		//该球唯一标识
		SerializeUtils.WriteString(stream, _uid);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//球的配置ID
		_ballId = SerializeUtils.ReadInt(stream);
		//该球唯一标识
		_uid = SerializeUtils.ReadString(stream);
	}
	
	/**
	 * 球的配置ID
	 */
	public int BallId
	{
		set { _ballId = value; }
	    get { return _ballId; }
	}
	
	/**
	 * 该球唯一标识
	 */
	public string Uid
	{
		set { _uid = value; }
	    get { return _uid; }
	}
	
}