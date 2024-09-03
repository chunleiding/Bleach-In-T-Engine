using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求购买斩魄刀皮肤 message
 */
public class ReqKnifeSkinMessage : Message 
{
	//斩魄刀皮肤id
	int _skinid;	
	//1 7天 2  30天  3 永久
	int _dateNum;	
	//1：使用；2：购买
	int _type;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//斩魄刀皮肤id
		SerializeUtils.WriteInt(stream, _skinid);
		//1 7天 2  30天  3 永久
		SerializeUtils.WriteInt(stream, _dateNum);
		//1：使用；2：购买
		SerializeUtils.WriteInt(stream, _type);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//斩魄刀皮肤id
		_skinid = SerializeUtils.ReadInt(stream);
		//1 7天 2  30天  3 永久
		_dateNum = SerializeUtils.ReadInt(stream);
		//1：使用；2：购买
		_type = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 斩魄刀皮肤id
	 */
	public int Skinid
	{
		set { _skinid = value; }
	    get { return _skinid; }
	}
	
	/**
	 * 1 7天 2  30天  3 永久
	 */
	public int DateNum
	{
		set { _dateNum = value; }
	    get { return _dateNum; }
	}
	
	/**
	 * 1：使用；2：购买
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	
	public override int GetId() 
	{
		return 816103;
	}
}