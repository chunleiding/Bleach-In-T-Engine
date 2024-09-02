using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求领取番队福袋结果 message
 */
public class ResReceiveGangBagMessage : Message 
{
	//0:成功,1:重复领取,2:该福袋已被领完,3:福袋领取时间结束,4:上次退出番队时间不足
	int _res;	
	//当res为0时奖励的灵子奖励(金钱)
	int _gold;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0:成功,1:重复领取,2:该福袋已被领完,3:福袋领取时间结束,4:上次退出番队时间不足
		SerializeUtils.WriteInt(stream, _res);
		//当res为0时奖励的灵子奖励(金钱)
		SerializeUtils.WriteInt(stream, _gold);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0:成功,1:重复领取,2:该福袋已被领完,3:福袋领取时间结束,4:上次退出番队时间不足
		_res = SerializeUtils.ReadInt(stream);
		//当res为0时奖励的灵子奖励(金钱)
		_gold = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0:成功,1:重复领取,2:该福袋已被领完,3:福袋领取时间结束,4:上次退出番队时间不足
	 */
	public int Res
	{
		set { _res = value; }
	    get { return _res; }
	}
	
	/**
	 * 当res为0时奖励的灵子奖励(金钱)
	 */
	public int Gold
	{
		set { _gold = value; }
	    get { return _gold; }
	}
	
	
	public override int GetId() 
	{
		return 109136;
	}
}