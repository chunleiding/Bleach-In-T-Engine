using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 瞬步关卡回复 message
 */
public class ResSkipUpLevelMessage : Message 
{
	//瞬步状态：0 成功 1 失败 2 次数不够 3 当前关卡不支持 4 体力不够
	int _result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//瞬步状态：0 成功 1 失败 2 次数不够 3 当前关卡不支持 4 体力不够
		SerializeUtils.WriteInt(stream, _result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//瞬步状态：0 成功 1 失败 2 次数不够 3 当前关卡不支持 4 体力不够
		_result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 瞬步状态：0 成功 1 失败 2 次数不够 3 当前关卡不支持 4 体力不够
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	
	public override int GetId() 
	{
		return 831112;
	}
}