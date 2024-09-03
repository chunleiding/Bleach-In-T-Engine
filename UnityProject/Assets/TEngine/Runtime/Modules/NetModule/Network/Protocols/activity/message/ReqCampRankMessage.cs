using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 排行榜信息 message
 */
public class ReqCampRankMessage : Message 
{
	//类型(1：等级榜,2:阶级榜,3:充值榜）
	int _type;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//类型(1：等级榜,2:阶级榜,3:充值榜）
		SerializeUtils.WriteInt(stream, _type);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//类型(1：等级榜,2:阶级榜,3:充值榜）
		_type = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 类型(1：等级榜,2:阶级榜,3:充值榜）
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	
	public override int GetId() 
	{
		return 311210;
	}
}