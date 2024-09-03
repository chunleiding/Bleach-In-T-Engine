using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 登陆结果 message
 */
public class ResLoginResultMessage : Message 
{
	//0-成功  1-服务器未开启 2-用户名密码错 等 3-在ip黑名单中  4-在玩家黑名单中 5-版本不匹配
	int _isSuccess;	
	//0-无玩家信息 1-有玩家信息
	int _havePlayer;	
	//0-正常登陆，1-断线重连，消息数量匹配
	int _type;	
	//番队组长账户名称
	string _gangLeaderAccountName;	
	//角色创建时间点[单位秒]
	long _createTime;	
	//游戏服玩家账号id，如果是平台登录则是由平台userId生成玩家账号Id
	long _accountId;	
	//玩家对应平台的账号标识, 如果是平台登录则平台的userId,内部登录则为输入账号
	string _accountName;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0-成功  1-服务器未开启 2-用户名密码错 等 3-在ip黑名单中  4-在玩家黑名单中 5-版本不匹配
		SerializeUtils.WriteInt(stream, _isSuccess);
		//0-无玩家信息 1-有玩家信息
		SerializeUtils.WriteInt(stream, _havePlayer);
		//0-正常登陆，1-断线重连，消息数量匹配
		SerializeUtils.WriteInt(stream, _type);
		//番队组长账户名称
		SerializeUtils.WriteString(stream, _gangLeaderAccountName);
		//角色创建时间点[单位秒]
		SerializeUtils.WriteLong(stream, _createTime);
		//游戏服玩家账号id，如果是平台登录则是由平台userId生成玩家账号Id
		SerializeUtils.WriteLong(stream, _accountId);
		//玩家对应平台的账号标识, 如果是平台登录则平台的userId,内部登录则为输入账号
		SerializeUtils.WriteString(stream, _accountName);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0-成功  1-服务器未开启 2-用户名密码错 等 3-在ip黑名单中  4-在玩家黑名单中 5-版本不匹配
		_isSuccess = SerializeUtils.ReadInt(stream);
		//0-无玩家信息 1-有玩家信息
		_havePlayer = SerializeUtils.ReadInt(stream);
		//0-正常登陆，1-断线重连，消息数量匹配
		_type = SerializeUtils.ReadInt(stream);
		//番队组长账户名称
		_gangLeaderAccountName = SerializeUtils.ReadString(stream);
		//角色创建时间点[单位秒]
		_createTime = SerializeUtils.ReadLong(stream);
		//游戏服玩家账号id，如果是平台登录则是由平台userId生成玩家账号Id
		_accountId = SerializeUtils.ReadLong(stream);
		//玩家对应平台的账号标识, 如果是平台登录则平台的userId,内部登录则为输入账号
		_accountName = SerializeUtils.ReadString(stream);
	}
	
	/**
	 * 0-成功  1-服务器未开启 2-用户名密码错 等 3-在ip黑名单中  4-在玩家黑名单中 5-版本不匹配
	 */
	public int IsSuccess
	{
		set { _isSuccess = value; }
	    get { return _isSuccess; }
	}
	
	/**
	 * 0-无玩家信息 1-有玩家信息
	 */
	public int HavePlayer
	{
		set { _havePlayer = value; }
	    get { return _havePlayer; }
	}
	
	/**
	 * 0-正常登陆，1-断线重连，消息数量匹配
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	/**
	 * 番队组长账户名称
	 */
	public string GangLeaderAccountName
	{
		set { _gangLeaderAccountName = value; }
	    get { return _gangLeaderAccountName; }
	}
	
	/**
	 * 角色创建时间点[单位秒]
	 */
	public long CreateTime
	{
		set { _createTime = value; }
	    get { return _createTime; }
	}
	
	/**
	 * 游戏服玩家账号id，如果是平台登录则是由平台userId生成玩家账号Id
	 */
	public long AccountId
	{
		set { _accountId = value; }
	    get { return _accountId; }
	}
	
	/**
	 * 玩家对应平台的账号标识, 如果是平台登录则平台的userId,内部登录则为输入账号
	 */
	public string AccountName
	{
		set { _accountName = value; }
	    get { return _accountName; }
	}
	
	
	public override int GetId() 
	{
		return 100101;
	}
}