using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 刷新血量 message
 */
public class ResUpdateWorldBossHpMessage : Message 
{
	//血量列表
	List<SoulTrialHp> _hpList = new List<SoulTrialHp>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//血量列表
		SerializeUtils.WriteShort(stream, (short)_hpList.Count);

		foreach (var element in _hpList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//血量列表
		int _hpList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _hpList_length; ++i) 
		{
			_hpList.Add(SerializeUtils.ReadBean<SoulTrialHp>(stream));
		}
	}
	
	/**
	 * get 血量列表
	 * @return 
	 */
	public List<SoulTrialHp> GetHpList()
	{
		return _hpList;
	}
	
	/**
	 * set 血量列表
	 */
	public void SetHpList(List<SoulTrialHp> hpList)
	{
		_hpList = hpList;
	}
	
	
	public override int GetId() 
	{
		return 807115;
	}
}