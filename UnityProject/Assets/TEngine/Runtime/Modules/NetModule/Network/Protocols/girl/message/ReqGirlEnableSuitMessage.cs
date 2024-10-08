using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 启用套装属性加成 message
 */
public class ReqGirlEnableSuitMessage : Message 
{
	//妹子id
	int _girlId;	
	//时装id
	int _dressId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//妹子id
		SerializeUtils.WriteInt(stream, _girlId);
		//时装id
		SerializeUtils.WriteInt(stream, _dressId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//妹子id
		_girlId = SerializeUtils.ReadInt(stream);
		//时装id
		_dressId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 妹子id
	 */
	public int GirlId
	{
		set { _girlId = value; }
	    get { return _girlId; }
	}
	
	/**
	 * 时装id
	 */
	public int DressId
	{
		set { _dressId = value; }
	    get { return _dressId; }
	}
	
	
	public override int GetId() 
	{
		return 108208;
	}
}