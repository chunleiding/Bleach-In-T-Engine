using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队玩家信息变更消息 message
 */
public class ResGangMemberBaseInfoUpdateMessage : Message 
{
	//番队玩家id
	long _playerId;	
	//1:当前角色id,2:玩家等级,3:玩家战斗力(活跃度通过ResGangActivity同步),4:番队队长变更(playerId为番队队长的玩家id),5:今日活跃度,6:当前角色阶级，7：当前角色成长等级，8：上下线
	int _type;	
	//变更后的值
	int _value;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//番队玩家id
		SerializeUtils.WriteLong(stream, _playerId);
		//1:当前角色id,2:玩家等级,3:玩家战斗力(活跃度通过ResGangActivity同步),4:番队队长变更(playerId为番队队长的玩家id),5:今日活跃度,6:当前角色阶级，7：当前角色成长等级，8：上下线
		SerializeUtils.WriteInt(stream, _type);
		//变更后的值
		SerializeUtils.WriteInt(stream, _value);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//番队玩家id
		_playerId = SerializeUtils.ReadLong(stream);
		//1:当前角色id,2:玩家等级,3:玩家战斗力(活跃度通过ResGangActivity同步),4:番队队长变更(playerId为番队队长的玩家id),5:今日活跃度,6:当前角色阶级，7：当前角色成长等级，8：上下线
		_type = SerializeUtils.ReadInt(stream);
		//变更后的值
		_value = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 番队玩家id
	 */
	public long PlayerId
	{
		set { _playerId = value; }
	    get { return _playerId; }
	}
	
	/**
	 * 1:当前角色id,2:玩家等级,3:玩家战斗力(活跃度通过ResGangActivity同步),4:番队队长变更(playerId为番队队长的玩家id),5:今日活跃度,6:当前角色阶级，7：当前角色成长等级，8：上下线
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	/**
	 * 变更后的值
	 */
	public int Value
	{
		set { _value = value; }
	    get { return _value; }
	}
	
	
	public override int GetId() 
	{
		return 109123;
	}
}