using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求获取无双死神对手信息 message
 */
public class ReqPeerlessOpponentMessage : Message 
{
	//玩家所在的段位
	int _grade;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//玩家所在的段位
		SerializeUtils.WriteInt(stream, _grade);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//玩家所在的段位
		_grade = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 玩家所在的段位
	 */
	public int Grade
	{
		set { _grade = value; }
	    get { return _grade; }
	}
	
	
	public override int GetId() 
	{
		return 817100;
	}
}