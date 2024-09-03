using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 回复打开红包 message
 */
public class ResOpenRedPacketMessage : Message 
{
	//单个红包最新信息
	RedPacketInfo _redPacketInfo;	
	//0：成功 其他：失败
	int _result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//单个红包最新信息
		SerializeUtils.WriteBean(stream, _redPacketInfo);
		//0：成功 其他：失败
		SerializeUtils.WriteInt(stream, _result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//单个红包最新信息
		_redPacketInfo = SerializeUtils.ReadBean<RedPacketInfo>(stream);
		//0：成功 其他：失败
		_result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 单个红包最新信息
	 */
	public RedPacketInfo RedPacketInfo
	{
		set { _redPacketInfo = value; }
	    get { return _redPacketInfo; }
	}
	
	/**
	 * 0：成功 其他：失败
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	
	public override int GetId() 
	{
		return 826103;
	}
}