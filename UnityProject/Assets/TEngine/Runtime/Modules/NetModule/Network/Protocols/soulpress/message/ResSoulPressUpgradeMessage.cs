using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 升级结果 message
 */
public class ResSoulPressUpgradeMessage : Message 
{
	//升级结果：0成功，1角色总阶数不够，2 材料不足，3系统未开放
	int _Result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//升级结果：0成功，1角色总阶数不够，2 材料不足，3系统未开放
		SerializeUtils.WriteInt(stream, _Result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//升级结果：0成功，1角色总阶数不够，2 材料不足，3系统未开放
		_Result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 升级结果：0成功，1角色总阶数不够，2 材料不足，3系统未开放
	 */
	public int Result
	{
		set { _Result = value; }
	    get { return _Result; }
	}
	
	
	public override int GetId() 
	{
		return 804102;
	}
}