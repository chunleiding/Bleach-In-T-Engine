using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 体力找回数据
 */
public class HealthData : IMessageSerialize 
{
	//日期
	string _Time;	
	//购买体力剩余次数
	int _HealthTimes;	
	//经验值
	int _Exp;	
	//体力购买次数
	int _buyTimes;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//日期
		SerializeUtils.WriteString(stream, _Time);
		//购买体力剩余次数
		SerializeUtils.WriteInt(stream, _HealthTimes);
		//经验值
		SerializeUtils.WriteInt(stream, _Exp);
		//体力购买次数
		SerializeUtils.WriteInt(stream, _buyTimes);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//日期
		_Time = SerializeUtils.ReadString(stream);
		//购买体力剩余次数
		_HealthTimes = SerializeUtils.ReadInt(stream);
		//经验值
		_Exp = SerializeUtils.ReadInt(stream);
		//体力购买次数
		_buyTimes = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 日期
	 */
	public string Time
	{
		set { _Time = value; }
	    get { return _Time; }
	}
	
	/**
	 * 购买体力剩余次数
	 */
	public int HealthTimes
	{
		set { _HealthTimes = value; }
	    get { return _HealthTimes; }
	}
	
	/**
	 * 经验值
	 */
	public int Exp
	{
		set { _Exp = value; }
	    get { return _Exp; }
	}
	
	/**
	 * 体力购买次数
	 */
	public int BuyTimes
	{
		set { _buyTimes = value; }
	    get { return _buyTimes; }
	}
	
}