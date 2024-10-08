using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 腾讯充值协议 message
 */
public class ReqRechargeTencentMessage : Message 
{
	//openId
	string _openId;	
	//openKey
	string _openKey;	
	//payToken
	string _payToken;	
	//pf
	string _pf;	
	//zoneid
	string _zoneid;	
	//金额
	string _amt;	
	//pfkey
	string _pfkey;	
	//商品ID
	int _productId;	
	//类型：0：手机QQ，1：微信
	int _type;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//openId
		SerializeUtils.WriteString(stream, _openId);
		//openKey
		SerializeUtils.WriteString(stream, _openKey);
		//payToken
		SerializeUtils.WriteString(stream, _payToken);
		//pf
		SerializeUtils.WriteString(stream, _pf);
		//zoneid
		SerializeUtils.WriteString(stream, _zoneid);
		//金额
		SerializeUtils.WriteString(stream, _amt);
		//pfkey
		SerializeUtils.WriteString(stream, _pfkey);
		//商品ID
		SerializeUtils.WriteInt(stream, _productId);
		//类型：0：手机QQ，1：微信
		SerializeUtils.WriteInt(stream, _type);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//openId
		_openId = SerializeUtils.ReadString(stream);
		//openKey
		_openKey = SerializeUtils.ReadString(stream);
		//payToken
		_payToken = SerializeUtils.ReadString(stream);
		//pf
		_pf = SerializeUtils.ReadString(stream);
		//zoneid
		_zoneid = SerializeUtils.ReadString(stream);
		//金额
		_amt = SerializeUtils.ReadString(stream);
		//pfkey
		_pfkey = SerializeUtils.ReadString(stream);
		//商品ID
		_productId = SerializeUtils.ReadInt(stream);
		//类型：0：手机QQ，1：微信
		_type = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * openId
	 */
	public string OpenId
	{
		set { _openId = value; }
	    get { return _openId; }
	}
	
	/**
	 * openKey
	 */
	public string OpenKey
	{
		set { _openKey = value; }
	    get { return _openKey; }
	}
	
	/**
	 * payToken
	 */
	public string PayToken
	{
		set { _payToken = value; }
	    get { return _payToken; }
	}
	
	/**
	 * pf
	 */
	public string Pf
	{
		set { _pf = value; }
	    get { return _pf; }
	}
	
	/**
	 * zoneid
	 */
	public string Zoneid
	{
		set { _zoneid = value; }
	    get { return _zoneid; }
	}
	
	/**
	 * 金额
	 */
	public string Amt
	{
		set { _amt = value; }
	    get { return _amt; }
	}
	
	/**
	 * pfkey
	 */
	public string Pfkey
	{
		set { _pfkey = value; }
	    get { return _pfkey; }
	}
	
	/**
	 * 商品ID
	 */
	public int ProductId
	{
		set { _productId = value; }
	    get { return _productId; }
	}
	
	/**
	 * 类型：0：手机QQ，1：微信
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	
	public override int GetId() 
	{
		return 312205;
	}
}