using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 无双死神名人堂
 */
public class PeerlessSuperStar : IMessageSerialize 
{
	//名人堂成员
	TopArenaRankingInfo _superStar;	
	//期数
	int _time;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//名人堂成员
		SerializeUtils.WriteBean(stream, _superStar);
		//期数
		SerializeUtils.WriteInt(stream, _time);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//名人堂成员
		_superStar = SerializeUtils.ReadBean<TopArenaRankingInfo>(stream);
		//期数
		_time = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 名人堂成员
	 */
	public TopArenaRankingInfo SuperStar
	{
		set { _superStar = value; }
	    get { return _superStar; }
	}
	
	/**
	 * 期数
	 */
	public int Time
	{
		set { _time = value; }
	    get { return _time; }
	}
	
}