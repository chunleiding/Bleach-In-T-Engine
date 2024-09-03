using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求玩家分数和血量改变 message
 */
public class ReqScoreHpChangedMessage : Message 
{
	//防御状态 0：防御；1：非防御
	int _defenseState;	
	//球的唯一标示符
	string _ballUId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//防御状态 0：防御；1：非防御
		SerializeUtils.WriteInt(stream, _defenseState);
		//球的唯一标示符
		SerializeUtils.WriteString(stream, _ballUId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//防御状态 0：防御；1：非防御
		_defenseState = SerializeUtils.ReadInt(stream);
		//球的唯一标示符
		_ballUId = SerializeUtils.ReadString(stream);
	}
	
	/**
	 * 防御状态 0：防御；1：非防御
	 */
	public int DefenseState
	{
		set { _defenseState = value; }
	    get { return _defenseState; }
	}
	
	/**
	 * 球的唯一标示符
	 */
	public string BallUId
	{
		set { _ballUId = value; }
	    get { return _ballUId; }
	}
	
	
	public override int GetId() 
	{
		return 825113;
	}
}