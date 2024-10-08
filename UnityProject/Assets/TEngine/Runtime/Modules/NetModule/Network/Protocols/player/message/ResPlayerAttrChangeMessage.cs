using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 同步玩家数据改变 message
 */
public class ResPlayerAttrChangeMessage : Message 
{
	//属性id : 0-玩家等级 1-环 2-灵子 3-魂玉 4-体力 5-星数 6-经验
	int _AttrbuteId;	
	//属性值
	int _AttrbuteValue;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//属性id : 0-玩家等级 1-环 2-灵子 3-魂玉 4-体力 5-星数 6-经验
		SerializeUtils.WriteInt(stream, _AttrbuteId);
		//属性值
		SerializeUtils.WriteInt(stream, _AttrbuteValue);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//属性id : 0-玩家等级 1-环 2-灵子 3-魂玉 4-体力 5-星数 6-经验
		_AttrbuteId = SerializeUtils.ReadInt(stream);
		//属性值
		_AttrbuteValue = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 属性id : 0-玩家等级 1-环 2-灵子 3-魂玉 4-体力 5-星数 6-经验
	 */
	public int AttrbuteId
	{
		set { _AttrbuteId = value; }
	    get { return _AttrbuteId; }
	}
	
	/**
	 * 属性值
	 */
	public int AttrbuteValue
	{
		set { _AttrbuteValue = value; }
	    get { return _AttrbuteValue; }
	}
	
	
	public override int GetId() 
	{
		return 105101;
	}
}