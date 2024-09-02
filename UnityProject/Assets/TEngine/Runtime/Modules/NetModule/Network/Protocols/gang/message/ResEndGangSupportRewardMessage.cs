using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 返回结束番队助战的奖励 message
 */
public class ResEndGangSupportRewardMessage : Message 
{
	//金钱奖励(时间和次数金钱奖励和)
	int _gold;	
	//助战次数
	int _supportNum;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//金钱奖励(时间和次数金钱奖励和)
		SerializeUtils.WriteInt(stream, _gold);
		//助战次数
		SerializeUtils.WriteInt(stream, _supportNum);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//金钱奖励(时间和次数金钱奖励和)
		_gold = SerializeUtils.ReadInt(stream);
		//助战次数
		_supportNum = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 金钱奖励(时间和次数金钱奖励和)
	 */
	public int Gold
	{
		set { _gold = value; }
	    get { return _gold; }
	}
	
	/**
	 * 助战次数
	 */
	public int SupportNum
	{
		set { _supportNum = value; }
	    get { return _supportNum; }
	}
	
	
	public override int GetId() 
	{
		return 109132;
	}
}