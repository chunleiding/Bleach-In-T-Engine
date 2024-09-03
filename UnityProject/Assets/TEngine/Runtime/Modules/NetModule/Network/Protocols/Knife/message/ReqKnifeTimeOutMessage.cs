using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 皮肤过期 message
 */
public class ReqKnifeTimeOutMessage : Message 
{
	//斩魄刀皮肤id
	int _skinId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//斩魄刀皮肤id
		SerializeUtils.WriteInt(stream, _skinId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//斩魄刀皮肤id
		_skinId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 斩魄刀皮肤id
	 */
	public int SkinId
	{
		set { _skinId = value; }
	    get { return _skinId; }
	}
	
	
	public override int GetId() 
	{
		return 816105;
	}
}