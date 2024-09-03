using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 响应升级番队建设升级消息 message
 */
public class ResGangBuildUpMessage : Message 
{
	//请求升级番队建设结果[0:成功,1:参数错误,2:不是番队队长,3:建设不存在,4:建设以及是最高等级,5:番队点数不足]
	int _result;	
	//建设信息
	BuildInfo _buildInfo;	
	//可否领奖[1:可以领奖,0:不可以领奖]
	int _canReward;	
	//下一次刷新倒计时秒数
	int _nexRefreshTimeSeconds;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//请求升级番队建设结果[0:成功,1:参数错误,2:不是番队队长,3:建设不存在,4:建设以及是最高等级,5:番队点数不足]
		SerializeUtils.WriteInt(stream, _result);
		//建设信息
		SerializeUtils.WriteBean(stream, _buildInfo);
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
		//请求升级番队建设结果[0:成功,1:参数错误,2:不是番队队长,3:建设不存在,4:建设以及是最高等级,5:番队点数不足]
		_result = SerializeUtils.ReadInt(stream);
		//建设信息
		_buildInfo = SerializeUtils.ReadBean<BuildInfo>(stream);
		//可否领奖[1:可以领奖,0:不可以领奖]
		_canReward = SerializeUtils.ReadInt(stream);
		//下一次刷新倒计时秒数
		_nexRefreshTimeSeconds = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 请求升级番队建设结果[0:成功,1:参数错误,2:不是番队队长,3:建设不存在,4:建设以及是最高等级,5:番队点数不足]
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * 建设信息
	 */
	public BuildInfo BuildInfo
	{
		set { _buildInfo = value; }
	    get { return _buildInfo; }
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
		return 109153;
	}
}