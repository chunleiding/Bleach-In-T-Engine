using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 响应料理信息消息 message
 */
public class ResCookInfoMessage : Message 
{
	//厨艺总经验
	int _cookExp;	
	//已经吃过的最大特供料理编号
	int _eatMaxSpecidFoodId;	
	//总共已经吃过的普通料理次数
	int _eatFoodTotalNum;	
	//当前可吃普通料理的次数
	int _eatFoodNum;	
	//距离下次增加做普通料理的时间[秒值]
	int _nextAddEatFoodTime;	
	//当前未吃普通料理的编号
	int _unfinishEatFoodId;	
	//当前未吃普通料理的完成星级
	int _unfinishEatfoodStar;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//厨艺总经验
		SerializeUtils.WriteInt(stream, _cookExp);
		//已经吃过的最大特供料理编号
		SerializeUtils.WriteInt(stream, _eatMaxSpecidFoodId);
		//总共已经吃过的普通料理次数
		SerializeUtils.WriteInt(stream, _eatFoodTotalNum);
		//当前可吃普通料理的次数
		SerializeUtils.WriteInt(stream, _eatFoodNum);
		//距离下次增加做普通料理的时间[秒值]
		SerializeUtils.WriteInt(stream, _nextAddEatFoodTime);
		//当前未吃普通料理的编号
		SerializeUtils.WriteInt(stream, _unfinishEatFoodId);
		//当前未吃普通料理的完成星级
		SerializeUtils.WriteInt(stream, _unfinishEatfoodStar);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//厨艺总经验
		_cookExp = SerializeUtils.ReadInt(stream);
		//已经吃过的最大特供料理编号
		_eatMaxSpecidFoodId = SerializeUtils.ReadInt(stream);
		//总共已经吃过的普通料理次数
		_eatFoodTotalNum = SerializeUtils.ReadInt(stream);
		//当前可吃普通料理的次数
		_eatFoodNum = SerializeUtils.ReadInt(stream);
		//距离下次增加做普通料理的时间[秒值]
		_nextAddEatFoodTime = SerializeUtils.ReadInt(stream);
		//当前未吃普通料理的编号
		_unfinishEatFoodId = SerializeUtils.ReadInt(stream);
		//当前未吃普通料理的完成星级
		_unfinishEatfoodStar = SerializeUtils.ReadInt(stream);
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
	 * 已经吃过的最大特供料理编号
	 */
	public int EatMaxSpecidFoodId
	{
		set { _eatMaxSpecidFoodId = value; }
	    get { return _eatMaxSpecidFoodId; }
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
	
	/**
	 * 距离下次增加做普通料理的时间[秒值]
	 */
	public int NextAddEatFoodTime
	{
		set { _nextAddEatFoodTime = value; }
	    get { return _nextAddEatFoodTime; }
	}
	
	/**
	 * 当前未吃普通料理的编号
	 */
	public int UnfinishEatFoodId
	{
		set { _unfinishEatFoodId = value; }
	    get { return _unfinishEatFoodId; }
	}
	
	/**
	 * 当前未吃普通料理的完成星级
	 */
	public int UnfinishEatfoodStar
	{
		set { _unfinishEatfoodStar = value; }
	    get { return _unfinishEatfoodStar; }
	}
	
	
	public override int GetId() 
	{
		return 106101;
	}
}