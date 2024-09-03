using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 换一批回复 message
 */
public class ResChargeCargoMessage : Message 
{
	//显示的队伍信息
	List<EscortPlayerDetailInfo> _cargoList = new List<EscortPlayerDetailInfo>();
	//距离下一次刷新货物剩余时间
	int _lastTime;	
	//换一批的cd时间
	int _cdTime;	
	//剩余的换一批次数
	int _chargeOverNum;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//显示的队伍信息
		SerializeUtils.WriteShort(stream, (short)_cargoList.Count);

		foreach (var element in _cargoList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//距离下一次刷新货物剩余时间
		SerializeUtils.WriteInt(stream, _lastTime);
		//换一批的cd时间
		SerializeUtils.WriteInt(stream, _cdTime);
		//剩余的换一批次数
		SerializeUtils.WriteInt(stream, _chargeOverNum);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//显示的队伍信息
		int _cargoList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _cargoList_length; ++i) 
		{
			_cargoList.Add(SerializeUtils.ReadBean<EscortPlayerDetailInfo>(stream));
		}
		//距离下一次刷新货物剩余时间
		_lastTime = SerializeUtils.ReadInt(stream);
		//换一批的cd时间
		_cdTime = SerializeUtils.ReadInt(stream);
		//剩余的换一批次数
		_chargeOverNum = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * get 显示的队伍信息
	 * @return 
	 */
	public List<EscortPlayerDetailInfo> GetCargoList()
	{
		return _cargoList;
	}
	
	/**
	 * set 显示的队伍信息
	 */
	public void SetCargoList(List<EscortPlayerDetailInfo> cargoList)
	{
		_cargoList = cargoList;
	}
	
	/**
	 * 距离下一次刷新货物剩余时间
	 */
	public int LastTime
	{
		set { _lastTime = value; }
	    get { return _lastTime; }
	}
	
	/**
	 * 换一批的cd时间
	 */
	public int CdTime
	{
		set { _cdTime = value; }
	    get { return _cdTime; }
	}
	
	/**
	 * 剩余的换一批次数
	 */
	public int ChargeOverNum
	{
		set { _chargeOverNum = value; }
	    get { return _chargeOverNum; }
	}
	
	
	public override int GetId() 
	{
		return 810103;
	}
}