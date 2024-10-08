using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 开始地狱蝶回复 message
 */
public class ResStartButterflyMessage : Message 
{
	//0：成功，1：cd中，2：对手不能被抢，3：自己已毕业，不能再抢
	int _result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0：成功，1：cd中，2：对手不能被抢，3：自己已毕业，不能再抢
		SerializeUtils.WriteInt(stream, _result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0：成功，1：cd中，2：对手不能被抢，3：自己已毕业，不能再抢
		_result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0：成功，1：cd中，2：对手不能被抢，3：自己已毕业，不能再抢
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	
	public override int GetId() 
	{
		return 211202;
	}
}