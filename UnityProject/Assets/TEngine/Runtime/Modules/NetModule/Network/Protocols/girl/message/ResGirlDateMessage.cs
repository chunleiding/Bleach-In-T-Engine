using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 妹子交往 message
 */
public class ResGirlDateMessage : Message 
{
	//交往后妹子新的信息
	GirlInfo _girl;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//交往后妹子新的信息
		SerializeUtils.WriteBean(stream, _girl);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//交往后妹子新的信息
		_girl = SerializeUtils.ReadBean<GirlInfo>(stream);
	}
	
	/**
	 * 交往后妹子新的信息
	 */
	public GirlInfo Girl
	{
		set { _girl = value; }
	    get { return _girl; }
	}
	
	
	public override int GetId() 
	{
		return 108102;
	}
}