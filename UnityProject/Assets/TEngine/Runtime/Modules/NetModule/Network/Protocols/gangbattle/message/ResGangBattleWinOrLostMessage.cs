using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队战系统是否开启标志 message
 */
public class ResGangBattleWinOrLostMessage : Message 
{
	//番队战胜负，0：负，1：胜利，2：未出结果
	int _result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//番队战胜负，0：负，1：胜利，2：未出结果
		SerializeUtils.WriteInt(stream, _result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//番队战胜负，0：负，1：胜利，2：未出结果
		_result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 番队战胜负，0：负，1：胜利，2：未出结果
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	
	public override int GetId() 
	{
		return 112111;
	}
}