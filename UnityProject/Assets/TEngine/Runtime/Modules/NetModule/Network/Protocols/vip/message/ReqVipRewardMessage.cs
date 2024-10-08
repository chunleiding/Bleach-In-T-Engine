using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 领取VIP等级礼包 message
 */
public class ReqVipRewardMessage : Message 
{
	//VIP等级
	int _vipLevel;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//VIP等级
		SerializeUtils.WriteInt(stream, _vipLevel);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//VIP等级
		_vipLevel = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * VIP等级
	 */
	public int VipLevel
	{
		set { _vipLevel = value; }
	    get { return _vipLevel; }
	}
	
	
	public override int GetId() 
	{
		return 313201;
	}
}