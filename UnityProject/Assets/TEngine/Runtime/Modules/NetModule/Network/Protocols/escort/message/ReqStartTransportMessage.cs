using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 开始运货 message
 */
public class ReqStartTransportMessage : Message 
{
	//运送货物的ID
	int _modelID;	
	//参与运送的角色
	List<int> _roles = new List<int>();
	//自己选择的魂共鸣
	List<int> _soulResonanceIds = new List<int>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//运送货物的ID
		SerializeUtils.WriteInt(stream, _modelID);
		//参与运送的角色
		SerializeUtils.WriteShort(stream, (short)_roles.Count);

		foreach (var element in _roles)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
		//自己选择的魂共鸣
		SerializeUtils.WriteShort(stream, (short)_soulResonanceIds.Count);

		foreach (var element in _soulResonanceIds)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//运送货物的ID
		_modelID = SerializeUtils.ReadInt(stream);
		//参与运送的角色
		int _roles_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _roles_length; ++i) 
		{
			_roles.Add(SerializeUtils.ReadInt(stream));
		}
		//自己选择的魂共鸣
		int _soulResonanceIds_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _soulResonanceIds_length; ++i) 
		{
			_soulResonanceIds.Add(SerializeUtils.ReadInt(stream));
		}
	}
	
	/**
	 * 运送货物的ID
	 */
	public int ModelID
	{
		set { _modelID = value; }
	    get { return _modelID; }
	}
	
	/**
	 * get 参与运送的角色
	 * @return 
	 */
	public List<int> GetRoles()
	{
		return _roles;
	}
	
	/**
	 * set 参与运送的角色
	 */
	public void SetRoles(List<int> roles)
	{
		_roles = roles;
	}
	
	/**
	 * get 自己选择的魂共鸣
	 * @return 
	 */
	public List<int> GetSoulResonanceIds()
	{
		return _soulResonanceIds;
	}
	
	/**
	 * set 自己选择的魂共鸣
	 */
	public void SetSoulResonanceIds(List<int> soulResonanceIds)
	{
		_soulResonanceIds = soulResonanceIds;
	}
	
	
	public override int GetId() 
	{
		return 810117;
	}
}