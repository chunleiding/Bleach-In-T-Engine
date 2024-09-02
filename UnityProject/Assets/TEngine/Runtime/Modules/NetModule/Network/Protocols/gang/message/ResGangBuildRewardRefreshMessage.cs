using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 响应刷新番队建设奖励状态消息 message
 */
public class ResGangBuildRewardRefreshMessage : Message 
{
	//可否领奖[1:可以领奖,0:不可以领奖]
	int _canReward;	
	//下一次刷新倒计时秒数
	int _nexRefreshTimeSeconds;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//可否领奖[1:可以领奖,0:不可以领奖]
		SerializeUtils.WriteInt(stream, _canReward);
		//下一次刷新倒计时秒数
		SerializeUtils.WriteInt(stream, _nexRefreshTimeSeconds);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//可否领奖[1:可以领奖,0:不可以领奖]
		_canReward = SerializeUtils.ReadInt(stream);
		//下一次刷新倒计时秒数
		_nexRefreshTimeSeconds = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 可否领奖[1:可以领奖,0:不可以领奖]
	 */
	public int CanReward
	{
		set { _canReward = value; }
	    get { return _canReward; }
	}
	
	/**
	 * 下一次刷新倒计时秒数
	 */
	public int NexRefreshTimeSeconds
	{
		set { _nexRefreshTimeSeconds = value; }
	    get { return _nexRefreshTimeSeconds; }
	}
	
	
	public override int GetId() 
	{
		return 109156;
	}
}