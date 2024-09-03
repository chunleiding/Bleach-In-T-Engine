using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 回复开始货运后的结果 message
 */
public class ResStartTransportMessage : Message 
{
	//我的货运信息
	EscortPlayerDetailInfo _myselfShipInfo;	
	//0成功，其他失败
	int _result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//我的货运信息
		SerializeUtils.WriteBean(stream, _myselfShipInfo);
		//0成功，其他失败
		SerializeUtils.WriteInt(stream, _result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//我的货运信息
		_myselfShipInfo = SerializeUtils.ReadBean<EscortPlayerDetailInfo>(stream);
		//0成功，其他失败
		_result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 我的货运信息
	 */
	public EscortPlayerDetailInfo MyselfShipInfo
	{
		set { _myselfShipInfo = value; }
	    get { return _myselfShipInfo; }
	}
	
	/**
	 * 0成功，其他失败
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	
	public override int GetId() 
	{
		return 810118;
	}
}