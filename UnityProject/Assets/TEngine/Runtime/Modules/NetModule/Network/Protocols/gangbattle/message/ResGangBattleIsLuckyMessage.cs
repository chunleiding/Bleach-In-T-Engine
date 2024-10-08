using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队战是否幸运番队 message
 */
public class ResGangBattleIsLuckyMessage : Message 
{
	//0：非幸运，1：幸运
	int _isLucky;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0：非幸运，1：幸运
		SerializeUtils.WriteInt(stream, _isLucky);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0：非幸运，1：幸运
		_isLucky = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0：非幸运，1：幸运
	 */
	public int IsLucky
	{
		set { _isLucky = value; }
	    get { return _isLucky; }
	}
	
	
	public override int GetId() 
	{
		return 112112;
	}
}