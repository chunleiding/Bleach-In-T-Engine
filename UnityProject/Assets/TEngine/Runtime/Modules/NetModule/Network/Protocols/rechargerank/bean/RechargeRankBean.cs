using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 玩家排名类
 */
public class RechargeRankBean : IMessageSerialize 
{
	//我的排名
	int _myRank;	
	//升级排名需要的钱数
	int _improveMoney;	
	//区服-名字
	List<string> _rankNameList = new List<string>();
	//1:每日充值;2:总充值;3:每日消耗;4:总消耗
	int _type;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//我的排名
		SerializeUtils.WriteInt(stream, _myRank);
		//升级排名需要的钱数
		SerializeUtils.WriteInt(stream, _improveMoney);
		//区服-名字
		SerializeUtils.WriteShort(stream, (short)_rankNameList.Count);

		foreach (var element in _rankNameList)  
		{
			SerializeUtils.WriteString(stream, element);
		}
		//1:每日充值;2:总充值;3:每日消耗;4:总消耗
		SerializeUtils.WriteInt(stream, _type);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//我的排名
		_myRank = SerializeUtils.ReadInt(stream);
		//升级排名需要的钱数
		_improveMoney = SerializeUtils.ReadInt(stream);
		//区服-名字
		int _rankNameList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _rankNameList_length; ++i) 
		{
			_rankNameList.Add(SerializeUtils.ReadString(stream));
		}
		//1:每日充值;2:总充值;3:每日消耗;4:总消耗
		_type = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 我的排名
	 */
	public int MyRank
	{
		set { _myRank = value; }
	    get { return _myRank; }
	}
	
	/**
	 * 升级排名需要的钱数
	 */
	public int ImproveMoney
	{
		set { _improveMoney = value; }
	    get { return _improveMoney; }
	}
	
	/**
	 * get 区服-名字
	 * @return 
	 */
	public List<string> GetRankNameList()
	{
		return _rankNameList;
	}
	
	/**
	 * set 区服-名字
	 */
	public void SetRankNameList(List<string> rankNameList)
	{
		_rankNameList = rankNameList;
	}
	
	/**
	 * 1:每日充值;2:总充值;3:每日消耗;4:总消耗
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
}