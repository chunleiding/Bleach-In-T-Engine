using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 响应吃普通料理的次数消息 message
 */
public class ResEatFoodNumMessage : Message 
{
	//当前可吃普通料理的次数
	int _eatFoodNum;	
	//距离下次增加做普通料理的时间[秒值]
	int _nextAddEatFoodTime;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//当前可吃普通料理的次数
		SerializeUtils.WriteInt(stream, _eatFoodNum);
		//距离下次增加做普通料理的时间[秒值]
		SerializeUtils.WriteInt(stream, _nextAddEatFoodTime);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//当前可吃普通料理的次数
		_eatFoodNum = SerializeUtils.ReadInt(stream);
		//距离下次增加做普通料理的时间[秒值]
		_nextAddEatFoodTime = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 当前可吃普通料理的次数
	 */
	public int EatFoodNum
	{
		set { _eatFoodNum = value; }
	    get { return _eatFoodNum; }
	}
	
	/**
	 * 距离下次增加做普通料理的时间[秒值]
	 */
	public int NextAddEatFoodTime
	{
		set { _nextAddEatFoodTime = value; }
	    get { return _nextAddEatFoodTime; }
	}
	
	
	public override int GetId() 
	{
		return 106105;
	}
}