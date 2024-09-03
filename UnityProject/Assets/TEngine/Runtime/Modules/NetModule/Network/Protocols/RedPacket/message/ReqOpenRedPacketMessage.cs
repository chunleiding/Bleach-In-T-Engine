using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求打开红包 message
 */
public class ReqOpenRedPacketMessage : Message 
{
	//红包编号
	int _redPacketId;	
	//1主面板 0其他
	int _redPacketType;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//红包编号
		SerializeUtils.WriteInt(stream, _redPacketId);
		//1主面板 0其他
		SerializeUtils.WriteInt(stream, _redPacketType);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//红包编号
		_redPacketId = SerializeUtils.ReadInt(stream);
		//1主面板 0其他
		_redPacketType = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 红包编号
	 */
	public int RedPacketId
	{
		set { _redPacketId = value; }
	    get { return _redPacketId; }
	}
	
	/**
	 * 1主面板 0其他
	 */
	public int RedPacketType
	{
		set { _redPacketType = value; }
	    get { return _redPacketType; }
	}
	
	
	public override int GetId() 
	{
		return 826102;
	}
}