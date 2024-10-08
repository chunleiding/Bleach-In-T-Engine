using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 百万招财世界纪录 message
 */
public class ResMillionRecordMessage : Message 
{
	//百万招财世界纪录
	MillionRecord _millionRecord;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//百万招财世界纪录
		SerializeUtils.WriteBean(stream, _millionRecord);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//百万招财世界纪录
		_millionRecord = SerializeUtils.ReadBean<MillionRecord>(stream);
	}
	
	/**
	 * 百万招财世界纪录
	 */
	public MillionRecord MillionRecord
	{
		set { _millionRecord = value; }
	    get { return _millionRecord; }
	}
	
	
	public override int GetId() 
	{
		return 202103;
	}
}