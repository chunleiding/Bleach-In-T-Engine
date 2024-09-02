using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 发放番队福袋结果 message
 */
public class ResGiveGangBagMessage : Message 
{
	//0:成功,1:魂玉不足,2:超过发放福袋次数
	int _res;	
	//福袋类型（id）
	int _bagType;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0:成功,1:魂玉不足,2:超过发放福袋次数
		SerializeUtils.WriteInt(stream, _res);
		//福袋类型（id）
		SerializeUtils.WriteInt(stream, _bagType);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0:成功,1:魂玉不足,2:超过发放福袋次数
		_res = SerializeUtils.ReadInt(stream);
		//福袋类型（id）
		_bagType = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0:成功,1:魂玉不足,2:超过发放福袋次数
	 */
	public int Res
	{
		set { _res = value; }
	    get { return _res; }
	}
	
	/**
	 * 福袋类型（id）
	 */
	public int BagType
	{
		set { _bagType = value; }
	    get { return _bagType; }
	}
	
	
	public override int GetId() 
	{
		return 109135;
	}
}