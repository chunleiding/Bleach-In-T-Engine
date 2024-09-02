using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 单个福袋信息 message
 */
public class ResGangBagInfoMessage : Message 
{
	//福袋信息
	GangBagInfo _bag;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//福袋信息
		SerializeUtils.WriteBean(stream, _bag);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//福袋信息
		_bag = SerializeUtils.ReadBean<GangBagInfo>(stream);
	}
	
	/**
	 * 福袋信息
	 */
	public GangBagInfo Bag
	{
		set { _bag = value; }
	    get { return _bag; }
	}
	
	
	public override int GetId() 
	{
		return 109138;
	}
}