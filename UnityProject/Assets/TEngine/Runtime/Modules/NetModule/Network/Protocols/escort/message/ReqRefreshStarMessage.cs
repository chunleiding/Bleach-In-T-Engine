using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求刷新货物星星 message
 */
public class ReqRefreshStarMessage : Message 
{
	//1:满星0：单次
	int _refreshStar;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//1:满星0：单次
		SerializeUtils.WriteInt(stream, _refreshStar);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//1:满星0：单次
		_refreshStar = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 1:满星0：单次
	 */
	public int RefreshStar
	{
		set { _refreshStar = value; }
	    get { return _refreshStar; }
	}
	
	
	public override int GetId() 
	{
		return 810110;
	}
}