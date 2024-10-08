using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 响应一键特训消息 message
 */
public class ResOneKeySpecialTrainingMessage : Message 
{
	//0:成功,1:无特权卡,2:魂玉不足,3:还没有开始特训,4:已经开始手动特训
	int _result;	
	//正在特训的角色(0:没有特训)
	int _characterId;	
	//正在特训加强的buffId
	int _buffId;	
	//最终的buff等级
	int _endBuffLevel;	
	//正在特训的箱子信息
	List<BoxInfo> _boxInfos = new List<BoxInfo>();
	//最后选择开启的箱子，如果之前已经成功开启全部普通箱子，则停止开启剩余的箱子[炸弹]
	List<int> _lastOpendPositions = new List<int>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
        //0:成功,1:无特权卡,2:魂玉不足,3:还没有开始特训,4:已经开始手动特训
		SerializeUtils.WriteInt(stream, _result);
		//正在特训的角色(0:没有特训)
		SerializeUtils.WriteInt(stream, _characterId);
		//正在特训加强的buffId
		SerializeUtils.WriteInt(stream, _buffId);
		//最终的buff等级
		SerializeUtils.WriteInt(stream, _endBuffLevel);
		//正在特训的箱子信息
		SerializeUtils.WriteShort(stream, (short)_boxInfos.Count);

		foreach (var element in _boxInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//最后选择开启的箱子，如果之前已经成功开启全部普通箱子，则停止开启剩余的箱子[炸弹]
		SerializeUtils.WriteShort(stream, (short)_lastOpendPositions.Count);

		foreach (var element in _lastOpendPositions)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
        //0:成功,1:无特权卡,2:魂玉不足,3:还没有开始特训,4:已经开始手动特训
		_result = SerializeUtils.ReadInt(stream);
		//正在特训的角色(0:没有特训)
		_characterId = SerializeUtils.ReadInt(stream);
		//正在特训加强的buffId
		_buffId = SerializeUtils.ReadInt(stream);
		//最终的buff等级
		_endBuffLevel = SerializeUtils.ReadInt(stream);
		//正在特训的箱子信息
		int _boxInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _boxInfos_length; ++i) 
		{
			_boxInfos.Add(SerializeUtils.ReadBean<BoxInfo>(stream));
		}
		//最后选择开启的箱子，如果之前已经成功开启全部普通箱子，则停止开启剩余的箱子[炸弹]
		int _lastOpendPositions_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _lastOpendPositions_length; ++i) 
		{
			_lastOpendPositions.Add(SerializeUtils.ReadInt(stream));
		}
	}

    /**
     * 0:成功,1:无特权卡,2:魂玉不足,3:还没有开始特训,4:已经开始手动特训
     */
    public int Result
	{
		set { _result = value; }
	    get { return _result; }
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
	 * 最终的buff等级
	 */
	public int EndBuffLevel
	{
		set { _endBuffLevel = value; }
	    get { return _endBuffLevel; }
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
	 * get 最后选择开启的箱子，如果之前已经成功开启全部普通箱子，则停止开启剩余的箱子[炸弹]
	 * @return 
	 */
	public List<int> GetLastOpendPositions()
	{
		return _lastOpendPositions;
	}
	
	/**
	 * set 最后选择开启的箱子，如果之前已经成功开启全部普通箱子，则停止开启剩余的箱子[炸弹]
	 */
	public void SetLastOpendPositions(List<int> lastOpendPositions)
	{
		_lastOpendPositions = lastOpendPositions;
	}
	
	
	public override int GetId() 
	{
		return 310106;
	}
}