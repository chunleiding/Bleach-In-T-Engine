using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 一键魂之力 message
 */
public class ResFastStrengthenDeathpowerMessage : Message 
{
	//结果，0成功
	int _result;	
	//当前魂之力id
	int _curPowerId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//结果，0成功
		SerializeUtils.WriteInt(stream, _result);
		//当前魂之力id
		SerializeUtils.WriteInt(stream, _curPowerId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//结果，0成功
		_result = SerializeUtils.ReadInt(stream);
		//当前魂之力id
		_curPowerId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 结果，0成功
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * 当前魂之力id
	 */
	public int CurPowerId
	{
		set { _curPowerId = value; }
	    get { return _curPowerId; }
	}
	
	
	public override int GetId() 
	{
		return 309203;
	}
}