using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 返回进入番队副本结果 message
 */
public class ResEnterGangInstanceMessage : Message 
{
	//0:进入成功,1:副本未开启,2:副本挑战已经结束,3:其他玩家正在挑战,4:超过玩家每日番队副本最大挑战次数
	int _res;	
	//正在挑战的玩家名称(当res为3时有效)
	string _fightingPlayerName;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0:进入成功,1:副本未开启,2:副本挑战已经结束,3:其他玩家正在挑战,4:超过玩家每日番队副本最大挑战次数
		SerializeUtils.WriteInt(stream, _res);
		//正在挑战的玩家名称(当res为3时有效)
		SerializeUtils.WriteString(stream, _fightingPlayerName);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0:进入成功,1:副本未开启,2:副本挑战已经结束,3:其他玩家正在挑战,4:超过玩家每日番队副本最大挑战次数
		_res = SerializeUtils.ReadInt(stream);
		//正在挑战的玩家名称(当res为3时有效)
		_fightingPlayerName = SerializeUtils.ReadString(stream);
	}
	
	/**
	 * 0:进入成功,1:副本未开启,2:副本挑战已经结束,3:其他玩家正在挑战,4:超过玩家每日番队副本最大挑战次数
	 */
	public int Res
	{
		set { _res = value; }
	    get { return _res; }
	}
	
	/**
	 * 正在挑战的玩家名称(当res为3时有效)
	 */
	public string FightingPlayerName
	{
		set { _fightingPlayerName = value; }
	    get { return _fightingPlayerName; }
	}
	
	
	public override int GetId() 
	{
		return 109133;
	}
}