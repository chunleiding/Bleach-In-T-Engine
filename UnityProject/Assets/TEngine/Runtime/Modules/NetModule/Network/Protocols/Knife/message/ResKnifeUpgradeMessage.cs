using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 斩魄刀升级结果 message
 */
public class ResKnifeUpgradeMessage : Message 
{
	//0成功1材料不足，3系统为开放
	int _Result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0成功1材料不足，3系统为开放
		SerializeUtils.WriteInt(stream, _Result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0成功1材料不足，3系统为开放
		_Result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0成功1材料不足，3系统为开放
	 */
	public int Result
	{
		set { _Result = value; }
	    get { return _Result; }
	}
	
	
	public override int GetId() 
	{
		return 816102;
	}
}