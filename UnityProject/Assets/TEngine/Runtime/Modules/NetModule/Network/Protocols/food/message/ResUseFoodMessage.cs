using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 响应对当前烹制出的普通料理操作方式消息 message
 */
public class ResUseFoodMessage : Message 
{
	//操作做好的普通料理结果[0:成功 ,1:参数错误,2:还没有做普通料理,3:vip等级不足,不可以放弃普通料理]
	int _result;	
	//操作[0:吃,1:放弃]
	int _type;	
	//普通料理编号
	int _foodId;	
	//厨艺总经验
	int _cookExp;	
	//总共已经吃过的普通料理次数
	int _eatFoodTotalNum;	
	//当前可吃普通料理的次数
	int _eatFoodNum;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//操作做好的普通料理结果[0:成功 ,1:参数错误,2:还没有做普通料理,3:vip等级不足,不可以放弃普通料理]
		SerializeUtils.WriteInt(stream, _result);
		//操作[0:吃,1:放弃]
		SerializeUtils.WriteInt(stream, _type);
		//普通料理编号
		SerializeUtils.WriteInt(stream, _foodId);
		//厨艺总经验
		SerializeUtils.WriteInt(stream, _cookExp);
		//总共已经吃过的普通料理次数
		SerializeUtils.WriteInt(stream, _eatFoodTotalNum);
		//当前可吃普通料理的次数
		SerializeUtils.WriteInt(stream, _eatFoodNum);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//操作做好的普通料理结果[0:成功 ,1:参数错误,2:还没有做普通料理,3:vip等级不足,不可以放弃普通料理]
		_result = SerializeUtils.ReadInt(stream);
		//操作[0:吃,1:放弃]
		_type = SerializeUtils.ReadInt(stream);
		//普通料理编号
		_foodId = SerializeUtils.ReadInt(stream);
		//厨艺总经验
		_cookExp = SerializeUtils.ReadInt(stream);
		//总共已经吃过的普通料理次数
		_eatFoodTotalNum = SerializeUtils.ReadInt(stream);
		//当前可吃普通料理的次数
		_eatFoodNum = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 操作做好的普通料理结果[0:成功 ,1:参数错误,2:还没有做普通料理,3:vip等级不足,不可以放弃普通料理]
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * 操作[0:吃,1:放弃]
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	/**
	 * 普通料理编号
	 */
	public int FoodId
	{
		set { _foodId = value; }
	    get { return _foodId; }
	}
	
	/**
	 * 厨艺总经验
	 */
	public int CookExp
	{
		set { _cookExp = value; }
	    get { return _cookExp; }
	}
	
	/**
	 * 总共已经吃过的普通料理次数
	 */
	public int EatFoodTotalNum
	{
		set { _eatFoodTotalNum = value; }
	    get { return _eatFoodTotalNum; }
	}
	
	/**
	 * 当前可吃普通料理的次数
	 */
	public int EatFoodNum
	{
		set { _eatFoodNum = value; }
	    get { return _eatFoodNum; }
	}
	
	
	public override int GetId() 
	{
		return 106103;
	}
}