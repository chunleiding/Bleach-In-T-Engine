using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 后端响应查看玩家消息 message
 */
public class ResViewPlayerInfoMessage : Message 
{
	//结果[0:成功,1:玩家不存在,2:玩家不在线]
	int _result;	
	//同步的玩家信息
	PlayerSyncInfo _playerSyncInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//结果[0:成功,1:玩家不存在,2:玩家不在线]
		SerializeUtils.WriteInt(stream, _result);
		//同步的玩家信息
		SerializeUtils.WriteBean(stream, _playerSyncInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//结果[0:成功,1:玩家不存在,2:玩家不在线]
		_result = SerializeUtils.ReadInt(stream);
		//同步的玩家信息
		_playerSyncInfo = SerializeUtils.ReadBean<PlayerSyncInfo>(stream);
	}
	
	/**
	 * 结果[0:成功,1:玩家不存在,2:玩家不在线]
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * 同步的玩家信息
	 */
	public PlayerSyncInfo PlayerSyncInfo
	{
		set { _playerSyncInfo = value; }
	    get { return _playerSyncInfo; }
	}
	
	
	public override int GetId() 
	{
		return 223101;
	}
}