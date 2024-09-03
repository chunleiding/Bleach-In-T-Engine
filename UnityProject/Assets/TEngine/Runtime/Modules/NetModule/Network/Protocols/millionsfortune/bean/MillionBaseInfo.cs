using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 百万转盘配置信息
 */
public class MillionBaseInfo : IMessageSerialize 
{
	//转盘奖励id
	int _millionId;	
	//1：奖池奖励，2：普通奖励；3：闪烁事件
	int _rewardType;	
	//奖励显示图标（道具ID）配置为0时，为闪烁事件（3为闪烁事件、4、5、6通用为奖池奖励）
	int _rewardItem;	
	//道具奖励数量
	int _number;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//转盘奖励id
		SerializeUtils.WriteInt(stream, _millionId);
		//1：奖池奖励，2：普通奖励；3：闪烁事件
		SerializeUtils.WriteInt(stream, _rewardType);
		//奖励显示图标（道具ID）配置为0时，为闪烁事件（3为闪烁事件、4、5、6通用为奖池奖励）
		SerializeUtils.WriteInt(stream, _rewardItem);
		//道具奖励数量
		SerializeUtils.WriteInt(stream, _number);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//转盘奖励id
		_millionId = SerializeUtils.ReadInt(stream);
		//1：奖池奖励，2：普通奖励；3：闪烁事件
		_rewardType = SerializeUtils.ReadInt(stream);
		//奖励显示图标（道具ID）配置为0时，为闪烁事件（3为闪烁事件、4、5、6通用为奖池奖励）
		_rewardItem = SerializeUtils.ReadInt(stream);
		//道具奖励数量
		_number = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 转盘奖励id
	 */
	public int MillionId
	{
		set { _millionId = value; }
	    get { return _millionId; }
	}
	
	/**
	 * 1：奖池奖励，2：普通奖励；3：闪烁事件
	 */
	public int RewardType
	{
		set { _rewardType = value; }
	    get { return _rewardType; }
	}
	
	/**
	 * 奖励显示图标（道具ID）配置为0时，为闪烁事件（3为闪烁事件、4、5、6通用为奖池奖励）
	 */
	public int RewardItem
	{
		set { _rewardItem = value; }
	    get { return _rewardItem; }
	}
	
	/**
	 * 道具奖励数量
	 */
	public int Number
	{
		set { _number = value; }
	    get { return _number; }
	}
	
}