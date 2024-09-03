using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 回复对手信息 message
 */
public class ResPeerlessOpponentMessage : Message 
{
	//对手信息
	TopArenaFightersInfo _opponent;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//对手信息
		SerializeUtils.WriteBean(stream, _opponent);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//对手信息
		_opponent = SerializeUtils.ReadBean<TopArenaFightersInfo>(stream);
	}
	
	/**
	 * 对手信息
	 */
	public TopArenaFightersInfo Opponent
	{
		set { _opponent = value; }
	    get { return _opponent; }
	}
	
	
	public override int GetId() 
	{
		return 817105;
	}
}