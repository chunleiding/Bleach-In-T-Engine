using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 出战角色列表 message
 */
public class ResButterflyFighterListMessage : Message 
{
	//出战角色列表
	List<int> _fighterList = new List<int>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//出战角色列表
		SerializeUtils.WriteShort(stream, (short)_fighterList.Count);

		foreach (var element in _fighterList)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//出战角色列表
		int _fighterList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _fighterList_length; ++i) 
		{
			_fighterList.Add(SerializeUtils.ReadInt(stream));
		}
	}
	
	/**
	 * get 出战角色列表
	 * @return 
	 */
	public List<int> GetFighterList()
	{
		return _fighterList;
	}
	
	/**
	 * set 出战角色列表
	 */
	public void SetFighterList(List<int> fighterList)
	{
		_fighterList = fighterList;
	}
	
	
	public override int GetId() 
	{
		return 211303;
	}
}