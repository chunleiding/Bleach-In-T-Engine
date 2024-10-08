using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 玩家特训信息 message
 */
public class ResSpecialTrainingInfoMessage : Message 
{
	//正在特训的角色(0:没有特训)
	int _characterId;	
	//正在特训加强的buffId
	int _buffId;	
	//正在特训的箱子信息
	List<BoxInfo> _boxInfos = new List<BoxInfo>();
	//剩余炸弹数量
	int _bombNum;	
	//是否有未被抵消的箱子(0:没有,非0:有)
	int _hasNotNeutralizeBox;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//正在特训的角色(0:没有特训)
		SerializeUtils.WriteInt(stream, _characterId);
		//正在特训加强的buffId
		SerializeUtils.WriteInt(stream, _buffId);
		//正在特训的箱子信息
		SerializeUtils.WriteShort(stream, (short)_boxInfos.Count);

		foreach (var element in _boxInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//剩余炸弹数量
		SerializeUtils.WriteInt(stream, _bombNum);
		//是否有未被抵消的箱子(0:没有,非0:有)
		SerializeUtils.WriteInt(stream, _hasNotNeutralizeBox);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//正在特训的角色(0:没有特训)
		_characterId = SerializeUtils.ReadInt(stream);
		//正在特训加强的buffId
		_buffId = SerializeUtils.ReadInt(stream);
		//正在特训的箱子信息
		int _boxInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _boxInfos_length; ++i) 
		{
			_boxInfos.Add(SerializeUtils.ReadBean<BoxInfo>(stream));
		}
		//剩余炸弹数量
		_bombNum = SerializeUtils.ReadInt(stream);
		//是否有未被抵消的箱子(0:没有,非0:有)
		_hasNotNeutralizeBox = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 正在特训的角色(0:没有特训)
	 */
	public int CharacterId
	{
		set { _characterId = value; }
	    get { return _characterId; }
	}
	
	/**
	 * 正在特训加强的buffId
	 */
	public int BuffId
	{
		set { _buffId = value; }
	    get { return _buffId; }
	}
	
	/**
	 * get 正在特训的箱子信息
	 * @return 
	 */
	public List<BoxInfo> GetBoxInfos()
	{
		return _boxInfos;
	}
	
	/**
	 * set 正在特训的箱子信息
	 */
	public void SetBoxInfos(List<BoxInfo> boxInfos)
	{
		_boxInfos = boxInfos;
	}
	
	/**
	 * 剩余炸弹数量
	 */
	public int BombNum
	{
		set { _bombNum = value; }
	    get { return _bombNum; }
	}
	
	/**
	 * 是否有未被抵消的箱子(0:没有,非0:有)
	 */
	public int HasNotNeutralizeBox
	{
		set { _hasNotNeutralizeBox = value; }
	    get { return _hasNotNeutralizeBox; }
	}
	
	
	public override int GetId() 
	{
		return 310103;
	}
}