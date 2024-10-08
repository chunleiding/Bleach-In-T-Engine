using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 后端返回请求开始极限挑战战斗的结果 message
 */
public class ResStartUnlimitFightBattleMessage : Message 
{
	//开始极限挑战战斗是否成功[0:成功,1:等级不足,2:缺少角色,3:极限挑战道具数量不足,4:参数错误,5:挑战的boss不存在]
	int _status;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//开始极限挑战战斗是否成功[0:成功,1:等级不足,2:缺少角色,3:极限挑战道具数量不足,4:参数错误,5:挑战的boss不存在]
		SerializeUtils.WriteInt(stream, _status);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//开始极限挑战战斗是否成功[0:成功,1:等级不足,2:缺少角色,3:极限挑战道具数量不足,4:参数错误,5:挑战的boss不存在]
		_status = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 开始极限挑战战斗是否成功[0:成功,1:等级不足,2:缺少角色,3:极限挑战道具数量不足,4:参数错误,5:挑战的boss不存在]
	 */
	public int Status
	{
		set { _status = value; }
	    get { return _status; }
	}
	
	
	public override int GetId() 
	{
		return 221101;
	}
}