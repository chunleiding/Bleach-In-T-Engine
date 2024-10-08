using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 返回购买挑战次数信息 message
 */
public class ResBuyMemoryRoadTimesMessage : Message 
{
	//购买挑战次数是否成功[0:成功,1:还有剩余挑战次数,2:魂玉不足
	int _status;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//购买挑战次数是否成功[0:成功,1:还有剩余挑战次数,2:魂玉不足
		SerializeUtils.WriteInt(stream, _status);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//购买挑战次数是否成功[0:成功,1:还有剩余挑战次数,2:魂玉不足
		_status = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 购买挑战次数是否成功[0:成功,1:还有剩余挑战次数,2:魂玉不足
	 */
	public int Status
	{
		set { _status = value; }
	    get { return _status; }
	}
	
	
	public override int GetId() 
	{
		return 220102;
	}
}