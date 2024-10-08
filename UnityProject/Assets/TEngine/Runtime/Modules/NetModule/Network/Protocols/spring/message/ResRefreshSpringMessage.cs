using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 前端请求刷新温泉结果 message
 */
public class ResRefreshSpringMessage : Message 
{
	//温泉id
	int _springId;	
	//结果(0:成功,1:不是vip,2:该vip等级刷新次数不足,3:魂玉不足)
	int _res;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//温泉id
		SerializeUtils.WriteInt(stream, _springId);
		//结果(0:成功,1:不是vip,2:该vip等级刷新次数不足,3:魂玉不足)
		SerializeUtils.WriteInt(stream, _res);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//温泉id
		_springId = SerializeUtils.ReadInt(stream);
		//结果(0:成功,1:不是vip,2:该vip等级刷新次数不足,3:魂玉不足)
		_res = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 温泉id
	 */
	public int SpringId
	{
		set { _springId = value; }
	    get { return _springId; }
	}
	
	/**
	 * 结果(0:成功,1:不是vip,2:该vip等级刷新次数不足,3:魂玉不足)
	 */
	public int Res
	{
		set { _res = value; }
	    get { return _res; }
	}
	
	
	public override int GetId() 
	{
		return 306105;
	}
}