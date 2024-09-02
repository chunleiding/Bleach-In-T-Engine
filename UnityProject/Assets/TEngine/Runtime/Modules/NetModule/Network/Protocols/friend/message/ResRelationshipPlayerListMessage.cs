using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 后端同步玩家关系消息 message
 */
public class ResRelationshipPlayerListMessage : Message 
{
	//黑名单列表
	List<RelationshipPlayer> _blackPlayerList = new List<RelationshipPlayer>();
	//好友列表
	List<RelationshipPlayer> _friendList = new List<RelationshipPlayer>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//黑名单列表
		SerializeUtils.WriteShort(stream, (short)_blackPlayerList.Count);

		foreach (var element in _blackPlayerList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//好友列表
		SerializeUtils.WriteShort(stream, (short)_friendList.Count);

		foreach (var element in _friendList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//黑名单列表
		int _blackPlayerList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _blackPlayerList_length; ++i) 
		{
			_blackPlayerList.Add(SerializeUtils.ReadBean<RelationshipPlayer>(stream));
		}
		//好友列表
		int _friendList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _friendList_length; ++i) 
		{
			_friendList.Add(SerializeUtils.ReadBean<RelationshipPlayer>(stream));
		}
	}
	
	/**
	 * get 黑名单列表
	 * @return 
	 */
	public List<RelationshipPlayer> GetBlackPlayerList()
	{
		return _blackPlayerList;
	}
	
	/**
	 * set 黑名单列表
	 */
	public void SetBlackPlayerList(List<RelationshipPlayer> blackPlayerList)
	{
		_blackPlayerList = blackPlayerList;
	}
	
	/**
	 * get 好友列表
	 * @return 
	 */
	public List<RelationshipPlayer> GetFriendList()
	{
		return _friendList;
	}
	
	/**
	 * set 好友列表
	 */
	public void SetFriendList(List<RelationshipPlayer> friendList)
	{
		_friendList = friendList;
	}
	
	
	public override int GetId() 
	{
		return 223104;
	}
}