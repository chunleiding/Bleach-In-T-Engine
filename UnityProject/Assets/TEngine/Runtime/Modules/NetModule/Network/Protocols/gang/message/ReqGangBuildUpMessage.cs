using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求升级番队建设升级消息 message
 */
public class ReqGangBuildUpMessage : Message 
{
	//建设编号
	int _buildId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//建设编号
		SerializeUtils.WriteInt(stream, _buildId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//建设编号
		_buildId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 建设编号
	 */
	public int BuildId
	{
		set { _buildId = value; }
	    get { return _buildId; }
	}
	
	
	public override int GetId() 
	{
		return 109253;
	}
}