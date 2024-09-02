using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 购买斩魄刀皮肤回复 message
 */
public class ResKnifeSkinMessage : Message 
{
	//0成功 1魂玉不足
	int _rsultSkin;	
	//皮肤剩余时间
	int _skinTime;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0成功 1魂玉不足
		SerializeUtils.WriteInt(stream, _rsultSkin);
		//皮肤剩余时间
		SerializeUtils.WriteInt(stream, _skinTime);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0成功 1魂玉不足
		_rsultSkin = SerializeUtils.ReadInt(stream);
		//皮肤剩余时间
		_skinTime = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0成功 1魂玉不足
	 */
	public int RsultSkin
	{
		set { _rsultSkin = value; }
	    get { return _rsultSkin; }
	}
	
	/**
	 * 皮肤剩余时间
	 */
	public int SkinTime
	{
		set { _skinTime = value; }
	    get { return _skinTime; }
	}
	
	
	public override int GetId() 
	{
		return 816104;
	}
}