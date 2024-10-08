using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 对手信息 message
 */
public class ResTopArenaOpponentMessage : Message 
{
	//对手信息
	TopArenaFightersInfo _oppoInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//对手信息
		SerializeUtils.WriteBean(stream, _oppoInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//对手信息
		_oppoInfo = SerializeUtils.ReadBean<TopArenaFightersInfo>(stream);
	}
	
	/**
	 * 对手信息
	 */
	public TopArenaFightersInfo OppoInfo
	{
		set { _oppoInfo = value; }
	    get { return _oppoInfo; }
	}
	
	
	public override int GetId() 
	{
		return 503101;
	}
}