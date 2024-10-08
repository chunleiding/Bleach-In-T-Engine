using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 响应吃特供料理消息 message
 */
public class ResEatSpecialFoodMessage : Message 
{
	//吃特供料理结果[0:成功 ,1:已经吃完所有特供料理,2:战斗力不足]
	int _result;	
	//已经吃过的最大特供料理编号
	int _eatMaxSpecidFoodId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//吃特供料理结果[0:成功 ,1:已经吃完所有特供料理,2:战斗力不足]
		SerializeUtils.WriteInt(stream, _result);
		//已经吃过的最大特供料理编号
		SerializeUtils.WriteInt(stream, _eatMaxSpecidFoodId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//吃特供料理结果[0:成功 ,1:已经吃完所有特供料理,2:战斗力不足]
		_result = SerializeUtils.ReadInt(stream);
		//已经吃过的最大特供料理编号
		_eatMaxSpecidFoodId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 吃特供料理结果[0:成功 ,1:已经吃完所有特供料理,2:战斗力不足]
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * 已经吃过的最大特供料理编号
	 */
	public int EatMaxSpecidFoodId
	{
		set { _eatMaxSpecidFoodId = value; }
	    get { return _eatMaxSpecidFoodId; }
	}
	
	
	public override int GetId() 
	{
		return 106104;
	}
}