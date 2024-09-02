using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 主界面货物基本信息
 */
public class EscortCargoBaseInfo : IMessageSerialize 
{
	//玩家id
	long _playerID;	
	//货物id
	int _cargoID;	
	//玩家等级
	int _palyerLevel;	
	//除主角外其他玩家的护送剩余时间
	long _otherPlayerTime;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//玩家id
		SerializeUtils.WriteLong(stream, _playerID);
		//货物id
		SerializeUtils.WriteInt(stream, _cargoID);
		//玩家等级
		SerializeUtils.WriteInt(stream, _palyerLevel);
		//除主角外其他玩家的护送剩余时间
		SerializeUtils.WriteLong(stream, _otherPlayerTime);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//玩家id
		_playerID = SerializeUtils.ReadLong(stream);
		//货物id
		_cargoID = SerializeUtils.ReadInt(stream);
		//玩家等级
		_palyerLevel = SerializeUtils.ReadInt(stream);
		//除主角外其他玩家的护送剩余时间
		_otherPlayerTime = SerializeUtils.ReadLong(stream);
	}
	
	/**
	 * 玩家id
	 */
	public long PlayerID
	{
		set { _playerID = value; }
	    get { return _playerID; }
	}
	
	/**
	 * 货物id
	 */
	public int CargoID
	{
		set { _cargoID = value; }
	    get { return _cargoID; }
	}
	
	/**
	 * 玩家等级
	 */
	public int PalyerLevel
	{
		set { _palyerLevel = value; }
	    get { return _palyerLevel; }
	}
	
	/**
	 * 除主角外其他玩家的护送剩余时间
	 */
	public long OtherPlayerTime
	{
		set { _otherPlayerTime = value; }
	    get { return _otherPlayerTime; }
	}
	
}