using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求进入一护试炼地图 message
 */
public class ReqEnterIchigoTrialMapMessage : Message 
{
	//角色id
	int _charId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//角色id
		SerializeUtils.WriteInt(stream, _charId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//角色id
		_charId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 角色id
	 */
	public int CharId
	{
		set { _charId = value; }
	    get { return _charId; }
	}
	
	
	public override int GetId() 
	{
		return 825109;
	}
}