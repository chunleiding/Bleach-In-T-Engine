using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 斩魄刀皮肤信息
 */
public class KnifeSkinInfo : IMessageSerialize 
{
	//斩魄刀皮肤id
	int _skinId;	
	//有皮肤0 正在使用1 没有2
	int _skinState;	
	//剩余时间(-1永久)
	int _leftTime;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//斩魄刀皮肤id
		SerializeUtils.WriteInt(stream, _skinId);
		//有皮肤0 正在使用1 没有2
		SerializeUtils.WriteInt(stream, _skinState);
		//剩余时间(-1永久)
		SerializeUtils.WriteInt(stream, _leftTime);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//斩魄刀皮肤id
		_skinId = SerializeUtils.ReadInt(stream);
		//有皮肤0 正在使用1 没有2
		_skinState = SerializeUtils.ReadInt(stream);
		//剩余时间(-1永久)
		_leftTime = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 斩魄刀皮肤id
	 */
	public int SkinId
	{
		set { _skinId = value; }
	    get { return _skinId; }
	}
	
	/**
	 * 有皮肤0 正在使用1 没有2
	 */
	public int SkinState
	{
		set { _skinState = value; }
	    get { return _skinState; }
	}
	
	/**
	 * 剩余时间(-1永久)
	 */
	public int LeftTime
	{
		set { _leftTime = value; }
	    get { return _leftTime; }
	}
	
}