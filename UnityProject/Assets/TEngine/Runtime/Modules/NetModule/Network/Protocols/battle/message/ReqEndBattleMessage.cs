using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 结束战斗请求 message
 */
public class ReqEndBattleMessage : Message 
{
	//战斗结果数据
	FightResultInfo _fightResultInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//战斗结果数据
		SerializeUtils.WriteBean(stream, _fightResultInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//战斗结果数据
		_fightResultInfo = SerializeUtils.ReadBean<FightResultInfo>(stream);
	}
	
	/**
	 * 战斗结果数据
	 */
	public FightResultInfo FightResultInfo
	{
		set { _fightResultInfo = value; }
	    get { return _fightResultInfo; }
	}
	
	
	public override int GetId() 
	{
		return 400102;
	}
}