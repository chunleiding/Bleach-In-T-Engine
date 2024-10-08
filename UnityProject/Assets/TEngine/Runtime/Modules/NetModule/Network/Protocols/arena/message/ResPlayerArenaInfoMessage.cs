using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 玩家竞技场信息 message
 */
public class ResPlayerArenaInfoMessage : Message 
{
	//玩家竞技场信息
	ArenaInfo _arenaInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//玩家竞技场信息
		SerializeUtils.WriteBean(stream, _arenaInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//玩家竞技场信息
		_arenaInfo = SerializeUtils.ReadBean<ArenaInfo>(stream);
	}
	
	/**
	 * 玩家竞技场信息
	 */
	public ArenaInfo ArenaInfo
	{
		set { _arenaInfo = value; }
	    get { return _arenaInfo; }
	}
	
	
	public override int GetId() 
	{
		return 206105;
	}
}