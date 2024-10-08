using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 后端返回请求提升角色成长率等级的结果 message
 */
public class ResUpCharacterGrowthLevelMessage : Message 
{
	//结果[0:成功,1:参数错误,2:功能未开放,3:角色不存在,4:已经是最高成长率等级,5:资源不足]
	int _result;	
	//角色编号
	int _characterId;	
	//角色成长率等级
	int _growthLevel;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//结果[0:成功,1:参数错误,2:功能未开放,3:角色不存在,4:已经是最高成长率等级,5:资源不足]
		SerializeUtils.WriteInt(stream, _result);
		//角色编号
		SerializeUtils.WriteInt(stream, _characterId);
		//角色成长率等级
		SerializeUtils.WriteInt(stream, _growthLevel);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//结果[0:成功,1:参数错误,2:功能未开放,3:角色不存在,4:已经是最高成长率等级,5:资源不足]
		_result = SerializeUtils.ReadInt(stream);
		//角色编号
		_characterId = SerializeUtils.ReadInt(stream);
		//角色成长率等级
		_growthLevel = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 结果[0:成功,1:参数错误,2:功能未开放,3:角色不存在,4:已经是最高成长率等级,5:资源不足]
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * 角色编号
	 */
	public int CharacterId
	{
		set { _characterId = value; }
	    get { return _characterId; }
	}
	
	/**
	 * 角色成长率等级
	 */
	public int GrowthLevel
	{
		set { _growthLevel = value; }
	    get { return _growthLevel; }
	}
	
	
	public override int GetId() 
	{
		return 222101;
	}
}