using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 极限挑战扫荡结果 message
 */
public class ResMopUnlimitFightBattleMessage : Message 
{
	//极限挑战扫荡是否成功[0:扫荡成功,1:扫荡失败]
	int _result;	
	//基础奖励列表
	MopReward _baseRewardInfos;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//极限挑战扫荡是否成功[0:扫荡成功,1:扫荡失败]
		SerializeUtils.WriteInt(stream, _result);
		//基础奖励列表
		SerializeUtils.WriteBean(stream, _baseRewardInfos);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//极限挑战扫荡是否成功[0:扫荡成功,1:扫荡失败]
		_result = SerializeUtils.ReadInt(stream);
		//基础奖励列表
		_baseRewardInfos = SerializeUtils.ReadBean<MopReward>(stream);
	}
	
	/**
	 * 极限挑战扫荡是否成功[0:扫荡成功,1:扫荡失败]
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * 基础奖励列表
	 */
	public MopReward BaseRewardInfos
	{
		set { _baseRewardInfos = value; }
	    get { return _baseRewardInfos; }
	}
	
	
	public override int GetId() 
	{
		return 221105;
	}
}