using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求查看番队信息结果[通过起止索引] message
 */
public class ResGangInfoByIndexMessage : Message 
{
	//番队信息列表
	List<GangInfo> _gangInfoList = new List<GangInfo>();
	//剩余的可以查询的番队信息条数
	int _reduceNum;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//番队信息列表
		SerializeUtils.WriteShort(stream, (short)_gangInfoList.Count);

		foreach (var element in _gangInfoList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//剩余的可以查询的番队信息条数
		SerializeUtils.WriteInt(stream, _reduceNum);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//番队信息列表
		int _gangInfoList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _gangInfoList_length; ++i) 
		{
			_gangInfoList.Add(SerializeUtils.ReadBean<GangInfo>(stream));
		}
		//剩余的可以查询的番队信息条数
		_reduceNum = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * get 番队信息列表
	 * @return 
	 */
	public List<GangInfo> GetGangInfoList()
	{
		return _gangInfoList;
	}
	
	/**
	 * set 番队信息列表
	 */
	public void SetGangInfoList(List<GangInfo> gangInfoList)
	{
		_gangInfoList = gangInfoList;
	}
	
	/**
	 * 剩余的可以查询的番队信息条数
	 */
	public int ReduceNum
	{
		set { _reduceNum = value; }
	    get { return _reduceNum; }
	}
	
	
	public override int GetId() 
	{
		return 109142;
	}
}