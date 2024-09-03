using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 关卡地图信息
 */
public class MapInfoBean : IMessageSerialize 
{
	//子节点关卡id
	List<int> _levelIdList = new List<int>();
	//关卡坐标信息
	MapCoordinate _mapCoord;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//子节点关卡id
		SerializeUtils.WriteShort(stream, (short)_levelIdList.Count);

		foreach (var element in _levelIdList)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
		//关卡坐标信息
		SerializeUtils.WriteBean(stream, _mapCoord);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//子节点关卡id
		int _levelIdList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _levelIdList_length; ++i) 
		{
			_levelIdList.Add(SerializeUtils.ReadInt(stream));
		}
		//关卡坐标信息
		_mapCoord = SerializeUtils.ReadBean<MapCoordinate>(stream);
	}
	
	/**
	 * get 子节点关卡id
	 * @return 
	 */
	public List<int> GetLevelIdList()
	{
		return _levelIdList;
	}
	
	/**
	 * set 子节点关卡id
	 */
	public void SetLevelIdList(List<int> levelIdList)
	{
		_levelIdList = levelIdList;
	}
	
	/**
	 * 关卡坐标信息
	 */
	public MapCoordinate MapCoord
	{
		set { _mapCoord = value; }
	    get { return _mapCoord; }
	}
	
}