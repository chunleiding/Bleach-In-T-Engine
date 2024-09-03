using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 回复领取红包次数 message
 */
public class ResReceiveCountMessage : Message 
{
	//红包总共领取次数
	int _totalCount;	
	//红包剩余可领取次数
	int _leftCount;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//红包总共领取次数
		SerializeUtils.WriteInt(stream, _totalCount);
		//红包剩余可领取次数
		SerializeUtils.WriteInt(stream, _leftCount);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//红包总共领取次数
		_totalCount = SerializeUtils.ReadInt(stream);
		//红包剩余可领取次数
		_leftCount = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 红包总共领取次数
	 */
	public int TotalCount
	{
		set { _totalCount = value; }
	    get { return _totalCount; }
	}
	
	/**
	 * 红包剩余可领取次数
	 */
	public int LeftCount
	{
		set { _leftCount = value; }
	    get { return _leftCount; }
	}
	
	
	public override int GetId() 
	{
		return 826107;
	}
}