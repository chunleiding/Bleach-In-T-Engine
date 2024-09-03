using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 地图坐标
 */
public class MapCoordinate : IMessageSerialize 
{
	//横坐标
	int _x;	
	//纵坐标
	int _y;	
	//关卡id
	int _levelId;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//横坐标
		SerializeUtils.WriteInt(stream, _x);
		//纵坐标
		SerializeUtils.WriteInt(stream, _y);
		//关卡id
		SerializeUtils.WriteInt(stream, _levelId);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//横坐标
		_x = SerializeUtils.ReadInt(stream);
		//纵坐标
		_y = SerializeUtils.ReadInt(stream);
		//关卡id
		_levelId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 横坐标
	 */
	public int X
	{
		set { _x = value; }
	    get { return _x; }
	}
	
	/**
	 * 纵坐标
	 */
	public int Y
	{
		set { _y = value; }
	    get { return _y; }
	}
	
	/**
	 * 关卡id
	 */
	public int LevelId
	{
		set { _levelId = value; }
	    get { return _levelId; }
	}
	
}