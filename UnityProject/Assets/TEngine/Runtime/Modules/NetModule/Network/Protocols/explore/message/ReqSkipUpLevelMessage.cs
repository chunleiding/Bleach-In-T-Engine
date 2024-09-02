using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求瞬步该关卡 message
 */
public class ReqSkipUpLevelMessage : Message 
{
	//当前关卡id
	int _curLevelId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//当前关卡id
		SerializeUtils.WriteInt(stream, _curLevelId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//当前关卡id
		_curLevelId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 当前关卡id
	 */
	public int CurLevelId
	{
		set { _curLevelId = value; }
	    get { return _curLevelId; }
	}
	
	
	public override int GetId() 
	{
		return 831111;
	}
}