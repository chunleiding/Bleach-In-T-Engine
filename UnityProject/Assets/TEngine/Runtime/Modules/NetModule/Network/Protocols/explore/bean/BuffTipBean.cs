using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * buff提示信息
 */
public class BuffTipBean : IMessageSerialize 
{
	//增益1 减益 -1
	int _buffType;	
	//持续关卡  -1此轮 n为后n关
	int _nextLevelNum;	
	//影响属性类型
	int _attributeType;	
	//事件的唯一标识
	int _eventId;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//增益1 减益 -1
		SerializeUtils.WriteInt(stream, _buffType);
		//持续关卡  -1此轮 n为后n关
		SerializeUtils.WriteInt(stream, _nextLevelNum);
		//影响属性类型
		SerializeUtils.WriteInt(stream, _attributeType);
		//事件的唯一标识
		SerializeUtils.WriteInt(stream, _eventId);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//增益1 减益 -1
		_buffType = SerializeUtils.ReadInt(stream);
		//持续关卡  -1此轮 n为后n关
		_nextLevelNum = SerializeUtils.ReadInt(stream);
		//影响属性类型
		_attributeType = SerializeUtils.ReadInt(stream);
		//事件的唯一标识
		_eventId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 增益1 减益 -1
	 */
	public int BuffType
	{
		set { _buffType = value; }
	    get { return _buffType; }
	}
	
	/**
	 * 持续关卡  -1此轮 n为后n关
	 */
	public int NextLevelNum
	{
		set { _nextLevelNum = value; }
	    get { return _nextLevelNum; }
	}
	
	/**
	 * 影响属性类型
	 */
	public int AttributeType
	{
		set { _attributeType = value; }
	    get { return _attributeType; }
	}
	
	/**
	 * 事件的唯一标识
	 */
	public int EventId
	{
		set { _eventId = value; }
	    get { return _eventId; }
	}
	
}