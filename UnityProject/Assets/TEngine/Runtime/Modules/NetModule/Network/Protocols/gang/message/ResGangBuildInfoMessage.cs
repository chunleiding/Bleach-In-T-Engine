using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 响应番队建设消息 message
 */
public class ResGangBuildInfoMessage : Message 
{
	//建设信息列表
	List<BuildInfo> _buildInfoList = new List<BuildInfo>();
	//可否领奖[1:可以领奖,0:不可以领奖]
	int _canReward;	
	//下一次刷新倒计时秒数
	int _nexRefreshTimeSeconds;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//建设信息列表
		SerializeUtils.WriteShort(stream, (short)_buildInfoList.Count);

		foreach (var element in _buildInfoList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
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
		//建设信息列表
		int _buildInfoList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _buildInfoList_length; ++i) 
		{
			_buildInfoList.Add(SerializeUtils.ReadBean<BuildInfo>(stream));
		}
		//可否领奖[1:可以领奖,0:不可以领奖]
		_canReward = SerializeUtils.ReadInt(stream);
		//下一次刷新倒计时秒数
		_nexRefreshTimeSeconds = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * get 建设信息列表
	 * @return 
	 */
	public List<BuildInfo> GetBuildInfoList()
	{
		return _buildInfoList;
	}
	
	/**
	 * set 建设信息列表
	 */
	public void SetBuildInfoList(List<BuildInfo> buildInfoList)
	{
		_buildInfoList = buildInfoList;
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
		return 109152;
	}
}