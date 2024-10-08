using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 前端请求开始探索 message
 */
public class ReqBeginDiscoveryMessage : Message 
{
	//探索角色id
	List<int> _roles = new List<int>();
	//探索id
	int _discoveryId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//探索角色id
		SerializeUtils.WriteShort(stream, (short)_roles.Count);

		foreach (var element in _roles)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
		//探索id
		SerializeUtils.WriteInt(stream, _discoveryId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//探索角色id
		int _roles_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _roles_length; ++i) 
		{
			_roles.Add(SerializeUtils.ReadInt(stream));
		}
		//探索id
		_discoveryId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * get 探索角色id
	 * @return 
	 */
	public List<int> GetRoles()
	{
		return _roles;
	}
	
	/**
	 * set 探索角色id
	 */
	public void SetRoles(List<int> roles)
	{
		_roles = roles;
	}
	
	/**
	 * 探索id
	 */
	public int DiscoveryId
	{
		set { _discoveryId = value; }
	    get { return _discoveryId; }
	}
	
	
	public override int GetId() 
	{
		return 303201;
	}
}