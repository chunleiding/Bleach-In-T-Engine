using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 发送名人堂成员名单 message
 */
public class ResSuperStarMessage : Message 
{
	//全部名人堂成员列表
	List<PeerlessSuperStar> _superStarList = new List<PeerlessSuperStar>();
	//被膜拜的期数
	List<int> _worship = new List<int>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//全部名人堂成员列表
		SerializeUtils.WriteShort(stream, (short)_superStarList.Count);

		foreach (var element in _superStarList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//被膜拜的期数
		SerializeUtils.WriteShort(stream, (short)_worship.Count);

		foreach (var element in _worship)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//全部名人堂成员列表
		int _superStarList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _superStarList_length; ++i) 
		{
			_superStarList.Add(SerializeUtils.ReadBean<PeerlessSuperStar>(stream));
		}
		//被膜拜的期数
		int _worship_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _worship_length; ++i) 
		{
			_worship.Add(SerializeUtils.ReadInt(stream));
		}
	}
	
	/**
	 * get 全部名人堂成员列表
	 * @return 
	 */
	public List<PeerlessSuperStar> GetSuperStarList()
	{
		return _superStarList;
	}
	
	/**
	 * set 全部名人堂成员列表
	 */
	public void SetSuperStarList(List<PeerlessSuperStar> superStarList)
	{
		_superStarList = superStarList;
	}
	
	/**
	 * get 被膜拜的期数
	 * @return 
	 */
	public List<int> GetWorship()
	{
		return _worship;
	}
	
	/**
	 * set 被膜拜的期数
	 */
	public void SetWorship(List<int> worship)
	{
		_worship = worship;
	}
	
	
	public override int GetId() 
	{
		return 817119;
	}
}