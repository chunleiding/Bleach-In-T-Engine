using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求排行榜奖励 message
 */
public class ReqRankRewardMessage : Message 
{
	//排行榜类型，0-最强角色榜，1-总战力榜，2-等级排行榜
	int _type;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//排行榜类型，0-最强角色榜，1-总战力榜，2-等级排行榜
		SerializeUtils.WriteInt(stream, _type);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//排行榜类型，0-最强角色榜，1-总战力榜，2-等级排行榜
		_type = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 排行榜类型，0-最强角色榜，1-总战力榜，2-等级排行榜
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	
	public override int GetId() 
	{
		return 209202;
	}
}