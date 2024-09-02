using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 小游戏相关参数 message
 */
public class ResSmallGameinfoMessage : Message 
{
	//速率积分List
	List<RateScore> _smallGameInfo = new List<RateScore>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//速率积分List
		SerializeUtils.WriteShort(stream, (short)_smallGameInfo.Count);

		foreach (var element in _smallGameInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//速率积分List
		int _smallGameInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _smallGameInfo_length; ++i) 
		{
			_smallGameInfo.Add(SerializeUtils.ReadBean<RateScore>(stream));
		}
	}
	
	/**
	 * get 速率积分List
	 * @return 
	 */
	public List<RateScore> GetSmallGameInfo()
	{
		return _smallGameInfo;
	}
	
	/**
	 * set 速率积分List
	 */
	public void SetSmallGameInfo(List<RateScore> smallGameInfo)
	{
		_smallGameInfo = smallGameInfo;
	}
	
	
	public override int GetId() 
	{
		return 815101;
	}
}