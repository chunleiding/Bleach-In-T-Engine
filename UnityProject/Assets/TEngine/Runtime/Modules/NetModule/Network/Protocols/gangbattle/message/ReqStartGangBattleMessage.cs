using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队战挑战开始请求 message
 */
public class ReqStartGangBattleMessage : Message 
{
	//对手玩家id
	long _enemyPlayerId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//对手玩家id
		SerializeUtils.WriteLong(stream, _enemyPlayerId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//对手玩家id
		_enemyPlayerId = SerializeUtils.ReadLong(stream);
	}
	
	/**
	 * 对手玩家id
	 */
	public long EnemyPlayerId
	{
		set { _enemyPlayerId = value; }
	    get { return _enemyPlayerId; }
	}
	
	
	public override int GetId() 
	{
		return 112206;
	}
}