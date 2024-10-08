using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 返回前端请求开始特训结果 message
 */
public class ResBeginSpecialTrainingMessage : Message 
{
	//特训的角色
	int _characterId;	
	//特训加强的buffId
	int _buffId;	
	//炸弹数量
	int _bombNum;	
	//0:成功,1:正在特训中，不能开始特训,2:超过最大特训等级，不能特训,3:灵子不足
	int _res;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//特训的角色
		SerializeUtils.WriteInt(stream, _characterId);
		//特训加强的buffId
		SerializeUtils.WriteInt(stream, _buffId);
		//炸弹数量
		SerializeUtils.WriteInt(stream, _bombNum);
		//0:成功,1:正在特训中，不能开始特训,2:超过最大特训等级，不能特训,3:灵子不足
		SerializeUtils.WriteInt(stream, _res);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//特训的角色
		_characterId = SerializeUtils.ReadInt(stream);
		//特训加强的buffId
		_buffId = SerializeUtils.ReadInt(stream);
		//炸弹数量
		_bombNum = SerializeUtils.ReadInt(stream);
		//0:成功,1:正在特训中，不能开始特训,2:超过最大特训等级，不能特训,3:灵子不足
		_res = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 特训的角色
	 */
	public int CharacterId
	{
		set { _characterId = value; }
	    get { return _characterId; }
	}
	
	/**
	 * 特训加强的buffId
	 */
	public int BuffId
	{
		set { _buffId = value; }
	    get { return _buffId; }
	}
	
	/**
	 * 炸弹数量
	 */
	public int BombNum
	{
		set { _bombNum = value; }
	    get { return _bombNum; }
	}
	
	/**
	 * 0:成功,1:正在特训中，不能开始特训,2:超过最大特训等级，不能特训,3:灵子不足
	 */
	public int Res
	{
		set { _res = value; }
	    get { return _res; }
	}
	
	
	public override int GetId() 
	{
		return 310101;
	}
}