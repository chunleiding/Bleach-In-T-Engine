using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 发送全部的红包 message
 */
public class ResRedPacketListMessage : Message 
{
	//红包列表
	List<RedPacketInfo> _allRedPacketList = new List<RedPacketInfo>();
	//CD时间
	int _cdTIme;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//红包列表
		SerializeUtils.WriteShort(stream, (short)_allRedPacketList.Count);

		foreach (var element in _allRedPacketList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//CD时间
		SerializeUtils.WriteInt(stream, _cdTIme);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//红包列表
		int _allRedPacketList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _allRedPacketList_length; ++i) 
		{
			_allRedPacketList.Add(SerializeUtils.ReadBean<RedPacketInfo>(stream));
		}
		//CD时间
		_cdTIme = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * get 红包列表
	 * @return 
	 */
	public List<RedPacketInfo> GetAllRedPacketList()
	{
		return _allRedPacketList;
	}
	
	/**
	 * set 红包列表
	 */
	public void SetAllRedPacketList(List<RedPacketInfo> allRedPacketList)
	{
		_allRedPacketList = allRedPacketList;
	}
	
	/**
	 * CD时间
	 */
	public int CdTIme
	{
		set { _cdTIme = value; }
	    get { return _cdTIme; }
	}
	
	
	public override int GetId() 
	{
		return 826101;
	}
}