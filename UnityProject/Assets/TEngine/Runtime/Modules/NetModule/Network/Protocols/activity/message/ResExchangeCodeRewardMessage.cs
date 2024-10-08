using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 领取兑换码奖励响应消息 message
 */
public class ResExchangeCodeRewardMessage : Message 
{
	//响应结果状态[0:兑换成功,1:兑换码不存在,2:您已经获得过本次活动奖励！无法使用其他兑换码,3:兑换码无法使用,4:兑换码已使用,5:兑换码已过期]
	int _result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//响应结果状态[0:兑换成功,1:兑换码不存在,2:您已经获得过本次活动奖励！无法使用其他兑换码,3:兑换码无法使用,4:兑换码已使用,5:兑换码已过期]
		SerializeUtils.WriteInt(stream, _result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//响应结果状态[0:兑换成功,1:兑换码不存在,2:您已经获得过本次活动奖励！无法使用其他兑换码,3:兑换码无法使用,4:兑换码已使用,5:兑换码已过期]
		_result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 响应结果状态[0:兑换成功,1:兑换码不存在,2:您已经获得过本次活动奖励！无法使用其他兑换码,3:兑换码无法使用,4:兑换码已使用,5:兑换码已过期]
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	
	public override int GetId() 
	{
		return 311107;
	}
}