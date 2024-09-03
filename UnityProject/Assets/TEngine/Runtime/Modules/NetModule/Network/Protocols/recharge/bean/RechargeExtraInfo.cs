using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 充值商品额外信息
 */
public class RechargeExtraInfo : IMessageSerialize 
{
	//商品id
	int _commodityId;	
	//展示类型
	int _displayType;	
	//备用商品ID1号
	string _extProductId1;	
	//备用商品ID2号
	string _extProductId2;	
	//备用商品ID3号
	string _extProductId3;	
	//备用商品ID4号
	string _extProductId4;	
	//备用商品ID5号
	string _extProductId5;	
	//vip等级可见限制
	RechargePreCondition _precondition;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//商品id
		SerializeUtils.WriteInt(stream, _commodityId);
		//展示类型
		SerializeUtils.WriteInt(stream, _displayType);
		//备用商品ID1号
		SerializeUtils.WriteString(stream, _extProductId1);
		//备用商品ID2号
		SerializeUtils.WriteString(stream, _extProductId2);
		//备用商品ID3号
		SerializeUtils.WriteString(stream, _extProductId3);
		//备用商品ID4号
		SerializeUtils.WriteString(stream, _extProductId4);
		//备用商品ID5号
		SerializeUtils.WriteString(stream, _extProductId5);
		//vip等级可见限制
		SerializeUtils.WriteBean(stream, _precondition);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//商品id
		_commodityId = SerializeUtils.ReadInt(stream);
		//展示类型
		_displayType = SerializeUtils.ReadInt(stream);
		//备用商品ID1号
		_extProductId1 = SerializeUtils.ReadString(stream);
		//备用商品ID2号
		_extProductId2 = SerializeUtils.ReadString(stream);
		//备用商品ID3号
		_extProductId3 = SerializeUtils.ReadString(stream);
		//备用商品ID4号
		_extProductId4 = SerializeUtils.ReadString(stream);
		//备用商品ID5号
		_extProductId5 = SerializeUtils.ReadString(stream);
		//vip等级可见限制
		_precondition = SerializeUtils.ReadBean<RechargePreCondition>(stream);
	}
	
	/**
	 * 商品id
	 */
	public int CommodityId
	{
		set { _commodityId = value; }
	    get { return _commodityId; }
	}
	
	/**
	 * 展示类型
	 */
	public int DisplayType
	{
		set { _displayType = value; }
	    get { return _displayType; }
	}
	
	/**
	 * 备用商品ID1号
	 */
	public string ExtProductId1
	{
		set { _extProductId1 = value; }
	    get { return _extProductId1; }
	}
	
	/**
	 * 备用商品ID2号
	 */
	public string ExtProductId2
	{
		set { _extProductId2 = value; }
	    get { return _extProductId2; }
	}
	
	/**
	 * 备用商品ID3号
	 */
	public string ExtProductId3
	{
		set { _extProductId3 = value; }
	    get { return _extProductId3; }
	}
	
	/**
	 * 备用商品ID4号
	 */
	public string ExtProductId4
	{
		set { _extProductId4 = value; }
	    get { return _extProductId4; }
	}
	
	/**
	 * 备用商品ID5号
	 */
	public string ExtProductId5
	{
		set { _extProductId5 = value; }
	    get { return _extProductId5; }
	}
	
	/**
	 * vip等级可见限制
	 */
	public RechargePreCondition Precondition
	{
		set { _precondition = value; }
	    get { return _precondition; }
	}
	
}