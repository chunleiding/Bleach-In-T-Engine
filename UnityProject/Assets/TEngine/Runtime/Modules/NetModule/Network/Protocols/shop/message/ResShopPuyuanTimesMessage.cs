using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 浦元商店购买次数 message
 */
public class ResShopPuyuanTimesMessage : Message 
{
	//次数
	int _times;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//次数
		SerializeUtils.WriteInt(stream, _times);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//次数
		_times = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 次数
	 */
	public int Times
	{
		set { _times = value; }
	    get { return _times; }
	}
	
	
	public override int GetId() 
	{
		return 104103;
	}
}