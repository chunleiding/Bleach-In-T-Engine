using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 灵压信息 message
 */
public class ResSoulPressInfoMessage : Message 
{
	//当前灵压id
	int _SoulPressId;	
	//灵压效果剩余时间，超过1阶后为0
	int _effectLeftTime;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//当前灵压id
		SerializeUtils.WriteInt(stream, _SoulPressId);
		//灵压效果剩余时间，超过1阶后为0
		SerializeUtils.WriteInt(stream, _effectLeftTime);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//当前灵压id
		_SoulPressId = SerializeUtils.ReadInt(stream);
		//灵压效果剩余时间，超过1阶后为0
		_effectLeftTime = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 当前灵压id
	 */
	public int SoulPressId
	{
		set { _SoulPressId = value; }
	    get { return _SoulPressId; }
	}
	
	/**
	 * 灵压效果剩余时间，超过1阶后为0
	 */
	public int EffectLeftTime
	{
		set { _effectLeftTime = value; }
	    get { return _effectLeftTime; }
	}
	
	
	public override int GetId() 
	{
		return 804100;
	}
}