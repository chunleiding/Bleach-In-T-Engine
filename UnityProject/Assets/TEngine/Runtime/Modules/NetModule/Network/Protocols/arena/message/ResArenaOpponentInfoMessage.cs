using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 竞技场对手列表 message
 */
public class ResArenaOpponentInfoMessage : Message 
{
	//竞技场挑战者列表
	List<ArenaOpponentInfo> _arenaOpponetInfo = new List<ArenaOpponentInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//竞技场挑战者列表
		SerializeUtils.WriteShort(stream, (short)_arenaOpponetInfo.Count);

		foreach (var element in _arenaOpponetInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//竞技场挑战者列表
		int _arenaOpponetInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _arenaOpponetInfo_length; ++i) 
		{
			_arenaOpponetInfo.Add(SerializeUtils.ReadBean<ArenaOpponentInfo>(stream));
		}
	}
	
	/**
	 * get 竞技场挑战者列表
	 * @return 
	 */
	public List<ArenaOpponentInfo> GetArenaOpponetInfo()
	{
		return _arenaOpponetInfo;
	}
	
	/**
	 * set 竞技场挑战者列表
	 */
	public void SetArenaOpponetInfo(List<ArenaOpponentInfo> arenaOpponetInfo)
	{
		_arenaOpponetInfo = arenaOpponetInfo;
	}
	
	
	public override int GetId() 
	{
		return 206102;
	}
}