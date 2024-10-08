using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 领取登录奖励结果 message
 */
public class ResReceiveLoginRewardMessage : Message 
{
	//0:成功,1:该天已经领取过登录奖励,2:该天没有奖励可以领取(7天内登录了3天领取第4天的奖励如领取或领取第8天的奖励)
	int _res;	
	//领取登录奖励的天数(1-7)
	int _day;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0:成功,1:该天已经领取过登录奖励,2:该天没有奖励可以领取(7天内登录了3天领取第4天的奖励如领取或领取第8天的奖励)
		SerializeUtils.WriteInt(stream, _res);
		//领取登录奖励的天数(1-7)
		SerializeUtils.WriteInt(stream, _day);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0:成功,1:该天已经领取过登录奖励,2:该天没有奖励可以领取(7天内登录了3天领取第4天的奖励如领取或领取第8天的奖励)
		_res = SerializeUtils.ReadInt(stream);
		//领取登录奖励的天数(1-7)
		_day = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0:成功,1:该天已经领取过登录奖励,2:该天没有奖励可以领取(7天内登录了3天领取第4天的奖励如领取或领取第8天的奖励)
	 */
	public int Res
	{
		set { _res = value; }
	    get { return _res; }
	}
	
	/**
	 * 领取登录奖励的天数(1-7)
	 */
	public int Day
	{
		set { _day = value; }
	    get { return _day; }
	}
	
	
	public override int GetId() 
	{
		return 311101;
	}
}