using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 前端请求完成关卡 message
 */
public class ReqCompleteLevelMessage : Message 
{
	//角色id
	int _roleId;	
	//关卡难度id
	int _levelDifficultyId;	
	//通关时长（秒）
	int _duration;	
	//是否成功（0：挑战失败，1：挑战成功）
	int _success;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//角色id
		SerializeUtils.WriteInt(stream, _roleId);
		//关卡难度id
		SerializeUtils.WriteInt(stream, _levelDifficultyId);
		//通关时长（秒）
		SerializeUtils.WriteInt(stream, _duration);
		//是否成功（0：挑战失败，1：挑战成功）
		SerializeUtils.WriteInt(stream, _success);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//角色id
		_roleId = SerializeUtils.ReadInt(stream);
		//关卡难度id
		_levelDifficultyId = SerializeUtils.ReadInt(stream);
		//通关时长（秒）
		_duration = SerializeUtils.ReadInt(stream);
		//是否成功（0：挑战失败，1：挑战成功）
		_success = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 角色id
	 */
	public int RoleId
	{
		set { _roleId = value; }
	    get { return _roleId; }
	}
	
	/**
	 * 关卡难度id
	 */
	public int LevelDifficultyId
	{
		set { _levelDifficultyId = value; }
	    get { return _levelDifficultyId; }
	}
	
	/**
	 * 通关时长（秒）
	 */
	public int Duration
	{
		set { _duration = value; }
	    get { return _duration; }
	}
	
	/**
	 * 是否成功（0：挑战失败，1：挑战成功）
	 */
	public int Success
	{
		set { _success = value; }
	    get { return _success; }
	}
	
	
	public override int GetId() 
	{
		return 102202;
	}
}