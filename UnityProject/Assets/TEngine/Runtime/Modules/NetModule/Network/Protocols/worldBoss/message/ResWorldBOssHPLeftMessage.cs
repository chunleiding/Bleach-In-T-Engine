using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 服务器周期性下发boss剩余血量 message
 */
public class ResWorldBossHPLeftMessage : Message 
{
	//boss当前剩余血量
	int _hpLeft;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//boss当前剩余血量
		SerializeUtils.WriteInt(stream, _hpLeft);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//boss当前剩余血量
		_hpLeft = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * boss当前剩余血量
	 */
	public int HpLeft
	{
		set { _hpLeft = value; }
	    get { return _hpLeft; }
	}
	
	
	public override int GetId() 
	{
		return 807120;
	}
}