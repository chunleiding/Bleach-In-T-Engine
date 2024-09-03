using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求查看福袋领取明细结果 message
 */
public class ResViewGangBagReceiveDetailMessage : Message 
{
	//福袋id
	long _bagId;	
	//福袋所有者
	long _owner;	
	//番队福袋领取消息
	List<GangBagReceiveInfo> _receiveInfos = new List<GangBagReceiveInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//福袋id
		SerializeUtils.WriteLong(stream, _bagId);
		//福袋所有者
		SerializeUtils.WriteLong(stream, _owner);
		//番队福袋领取消息
		SerializeUtils.WriteShort(stream, (short)_receiveInfos.Count);

		foreach (var element in _receiveInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//福袋id
		_bagId = SerializeUtils.ReadLong(stream);
		//福袋所有者
		_owner = SerializeUtils.ReadLong(stream);
		//番队福袋领取消息
		int _receiveInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _receiveInfos_length; ++i) 
		{
			_receiveInfos.Add(SerializeUtils.ReadBean<GangBagReceiveInfo>(stream));
		}
	}
	
	/**
	 * 福袋id
	 */
	public long BagId
	{
		set { _bagId = value; }
	    get { return _bagId; }
	}
	
	/**
	 * 福袋所有者
	 */
	public long Owner
	{
		set { _owner = value; }
	    get { return _owner; }
	}
	
	/**
	 * get 番队福袋领取消息
	 * @return 
	 */
	public List<GangBagReceiveInfo> GetReceiveInfos()
	{
		return _receiveInfos;
	}
	
	/**
	 * set 番队福袋领取消息
	 */
	public void SetReceiveInfos(List<GangBagReceiveInfo> receiveInfos)
	{
		_receiveInfos = receiveInfos;
	}
	
	
	public override int GetId() 
	{
		return 109137;
	}
}