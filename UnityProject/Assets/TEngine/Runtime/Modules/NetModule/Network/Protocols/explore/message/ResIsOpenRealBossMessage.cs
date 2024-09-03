using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 是否开启真boss奖励面板 message
 */
public class ResIsOpenRealBossMessage : Message 
{
	//0：不开启boss奖励展示 1： 开启
	int _isShowBossReward;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0：不开启boss奖励展示 1： 开启
		SerializeUtils.WriteInt(stream, _isShowBossReward);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0：不开启boss奖励展示 1： 开启
		_isShowBossReward = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0：不开启boss奖励展示 1： 开启
	 */
	public int IsShowBossReward
	{
		set { _isShowBossReward = value; }
	    get { return _isShowBossReward; }
	}
	
	
	public override int GetId() 
	{
		return 831118;
	}
}