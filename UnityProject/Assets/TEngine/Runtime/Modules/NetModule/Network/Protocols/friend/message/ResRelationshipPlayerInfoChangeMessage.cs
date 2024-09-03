using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 关系玩家数据值改变消息 message
 */
public class ResRelationshipPlayerInfoChangeMessage : Message 
{
	//新属性值
	int _value;	
	//发送变化的关系玩家的编号
	long _playerId;	
	//属性类型[1:当前使用角色编号,2:当前使用角色阶级,3:当前使用角色成长率等级,4:玩家等级,5:离线时间[单位分钟,-1表示上限],6:vip等级]
	int _type;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//新属性值
		SerializeUtils.WriteInt(stream, _value);
		//发送变化的关系玩家的编号
		SerializeUtils.WriteLong(stream, _playerId);
		//属性类型[1:当前使用角色编号,2:当前使用角色阶级,3:当前使用角色成长率等级,4:玩家等级,5:离线时间[单位分钟,-1表示上限],6:vip等级]
		SerializeUtils.WriteInt(stream, _type);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//新属性值
		_value = SerializeUtils.ReadInt(stream);
		//发送变化的关系玩家的编号
		_playerId = SerializeUtils.ReadLong(stream);
		//属性类型[1:当前使用角色编号,2:当前使用角色阶级,3:当前使用角色成长率等级,4:玩家等级,5:离线时间[单位分钟,-1表示上限],6:vip等级]
		_type = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 新属性值
	 */
	public int Value
	{
		set { _value = value; }
	    get { return _value; }
	}
	
	/**
	 * 发送变化的关系玩家的编号
	 */
	public long PlayerId
	{
		set { _playerId = value; }
	    get { return _playerId; }
	}
	
	/**
	 * 属性类型[1:当前使用角色编号,2:当前使用角色阶级,3:当前使用角色成长率等级,4:玩家等级,5:离线时间[单位分钟,-1表示上限],6:vip等级]
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	
	public override int GetId() 
	{
		return 223204;
	}
}