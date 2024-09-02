using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 回复打开红包记录 message
 */
public class ResOpenRedPacketRecordMessage : Message 
{
	//自己红包信息
	SelfRedPacketInfo _selfRedPacketInfo;	
	//收取的红包记录
	List<RedPacketInfo> _receiveRedPacket = new List<RedPacketInfo>();
	//发送的红包记录
	List<RedPacketInfo> _sendRedPacket = new List<RedPacketInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//自己红包信息
		SerializeUtils.WriteBean(stream, _selfRedPacketInfo);
		//收取的红包记录
		SerializeUtils.WriteShort(stream, (short)_receiveRedPacket.Count);

		foreach (var element in _receiveRedPacket)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//发送的红包记录
		SerializeUtils.WriteShort(stream, (short)_sendRedPacket.Count);

		foreach (var element in _sendRedPacket)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//自己红包信息
		_selfRedPacketInfo = SerializeUtils.ReadBean<SelfRedPacketInfo>(stream);
		//收取的红包记录
		int _receiveRedPacket_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _receiveRedPacket_length; ++i) 
		{
			_receiveRedPacket.Add(SerializeUtils.ReadBean<RedPacketInfo>(stream));
		}
		//发送的红包记录
		int _sendRedPacket_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _sendRedPacket_length; ++i) 
		{
			_sendRedPacket.Add(SerializeUtils.ReadBean<RedPacketInfo>(stream));
		}
	}
	
	/**
	 * 自己红包信息
	 */
	public SelfRedPacketInfo SelfRedPacketInfo
	{
		set { _selfRedPacketInfo = value; }
	    get { return _selfRedPacketInfo; }
	}
	
	/**
	 * get 收取的红包记录
	 * @return 
	 */
	public List<RedPacketInfo> GetReceiveRedPacket()
	{
		return _receiveRedPacket;
	}
	
	/**
	 * set 收取的红包记录
	 */
	public void SetReceiveRedPacket(List<RedPacketInfo> receiveRedPacket)
	{
		_receiveRedPacket = receiveRedPacket;
	}
	
	/**
	 * get 发送的红包记录
	 * @return 
	 */
	public List<RedPacketInfo> GetSendRedPacket()
	{
		return _sendRedPacket;
	}
	
	/**
	 * set 发送的红包记录
	 */
	public void SetSendRedPacket(List<RedPacketInfo> sendRedPacket)
	{
		_sendRedPacket = sendRedPacket;
	}
	
	
	public override int GetId() 
	{
		return 826106;
	}
}