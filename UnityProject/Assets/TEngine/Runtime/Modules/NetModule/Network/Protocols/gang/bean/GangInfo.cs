using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队基本信息
 */
public class GangInfo : IMessageSerialize 
{
	//番队id
	long _gangId;	
	//查询编号
	long _queryId;	
	//服务器id
	int _server;	
	//旗帜id
	int _flag;	
	//名称
	string _name;	
	//当前人数
	int _num;	
	//公告
	string _notice;	
	//0:无需验证 1:需要验证
	byte _applyFlag;	
	//0:未申请 1:已申请
	byte _applyed;	
	//番队活跃度
	int _active;	
	//队长名称
	string _captainName;	
	//离线时间[单位秒]
	long _captainOfflineTime;	
	//特定时间段番队活跃度
	int _dayActive;	
	//番队等级
	int _gangLevel;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//番队id
		SerializeUtils.WriteLong(stream, _gangId);
		//查询编号
		SerializeUtils.WriteLong(stream, _queryId);
		//服务器id
		SerializeUtils.WriteInt(stream, _server);
		//旗帜id
		SerializeUtils.WriteInt(stream, _flag);
		//名称
		SerializeUtils.WriteString(stream, _name);
		//当前人数
		SerializeUtils.WriteInt(stream, _num);
		//公告
		SerializeUtils.WriteString(stream, _notice);
		//0:无需验证 1:需要验证
		SerializeUtils.WriteByte(stream, _applyFlag);
		//0:未申请 1:已申请
		SerializeUtils.WriteByte(stream, _applyed);
		//番队活跃度
		SerializeUtils.WriteInt(stream, _active);
		//队长名称
		SerializeUtils.WriteString(stream, _captainName);
		//离线时间[单位秒]
		SerializeUtils.WriteLong(stream, _captainOfflineTime);
		//特定时间段番队活跃度
		SerializeUtils.WriteInt(stream, _dayActive);
		//番队等级
		SerializeUtils.WriteInt(stream, _gangLevel);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//番队id
		_gangId = SerializeUtils.ReadLong(stream);
		//查询编号
		_queryId = SerializeUtils.ReadLong(stream);
		//服务器id
		_server = SerializeUtils.ReadInt(stream);
		//旗帜id
		_flag = SerializeUtils.ReadInt(stream);
		//名称
		_name = SerializeUtils.ReadString(stream);
		//当前人数
		_num = SerializeUtils.ReadInt(stream);
		//公告
		_notice = SerializeUtils.ReadString(stream);
		//0:无需验证 1:需要验证
		_applyFlag = SerializeUtils.ReadByte(stream);
		//0:未申请 1:已申请
		_applyed = SerializeUtils.ReadByte(stream);
		//番队活跃度
		_active = SerializeUtils.ReadInt(stream);
		//队长名称
		_captainName = SerializeUtils.ReadString(stream);
		//离线时间[单位秒]
		_captainOfflineTime = SerializeUtils.ReadLong(stream);
		//特定时间段番队活跃度
		_dayActive = SerializeUtils.ReadInt(stream);
		//番队等级
		_gangLevel = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 番队id
	 */
	public long GangId
	{
		set { _gangId = value; }
	    get { return _gangId; }
	}
	
	/**
	 * 查询编号
	 */
	public long QueryId
	{
		set { _queryId = value; }
	    get { return _queryId; }
	}
	
	/**
	 * 服务器id
	 */
	public int Server
	{
		set { _server = value; }
	    get { return _server; }
	}
	
	/**
	 * 旗帜id
	 */
	public int Flag
	{
		set { _flag = value; }
	    get { return _flag; }
	}
	
	/**
	 * 名称
	 */
	public string Name
	{
		set { _name = value; }
	    get { return _name; }
	}
	
	/**
	 * 当前人数
	 */
	public int Num
	{
		set { _num = value; }
	    get { return _num; }
	}
	
	/**
	 * 公告
	 */
	public string Notice
	{
		set { _notice = value; }
	    get { return _notice; }
	}
	
	/**
	 * 0:无需验证 1:需要验证
	 */
	public byte ApplyFlag
	{
		set { _applyFlag = value; }
	    get { return _applyFlag; }
	}
	
	/**
	 * 0:未申请 1:已申请
	 */
	public byte Applyed
	{
		set { _applyed = value; }
	    get { return _applyed; }
	}
	
	/**
	 * 番队活跃度
	 */
	public int Active
	{
		set { _active = value; }
	    get { return _active; }
	}
	
	/**
	 * 队长名称
	 */
	public string CaptainName
	{
		set { _captainName = value; }
	    get { return _captainName; }
	}
	
	/**
	 * 离线时间[单位秒]
	 */
	public long CaptainOfflineTime
	{
		set { _captainOfflineTime = value; }
	    get { return _captainOfflineTime; }
	}
	
	/**
	 * 特定时间段番队活跃度
	 */
	public int DayActive
	{
		set { _dayActive = value; }
	    get { return _dayActive; }
	}
	
	/**
	 * 番队等级
	 */
	public int GangLevel
	{
		set { _gangLevel = value; }
	    get { return _gangLevel; }
	}
	
}