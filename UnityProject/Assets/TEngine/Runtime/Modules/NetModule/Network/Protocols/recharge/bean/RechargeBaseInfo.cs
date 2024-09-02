using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 充值商品基础信息
 */
public class RechargeBaseInfo : IMessageSerialize 
{
	//商品ID
	int _commodityId;	
	//商品信息ID配合ItemConfig使用
	int _itemID;	
	//商品类型（1月卡，2永久卡，3成长卡, 4魂玉包（或是其他道具包））
	int _commodityType;	
	//信息类型，1为魂玉商品，2为非魂玉商品
	int _infoType;	
	//商品售价（图标ID：价格）ID1为RMB，ID2为魂玉
	RechargePrice _commodityPrice;	
	//首次购买该商品时商品数量的额外倍数
	int _firstMultiple;	
	//商品对应的基础道具数量，购买商品得到的道具数量=BaseReward *FirstMultiple(10:30为特殊，表示月卡持续时间为30天，-1表示持续时间为永久)
	List<ItemInfo> _baseReward = new List<ItemInfo>();
	//商品排序（0-100为雪花雪球类的活动商品；101-200为组合包系列活动商品；201-300为活动多倍魂玉档；301-400为常规商品；401以上为VIP礼包）
	int _sort;	
	//优惠次数，0表示无优惠，1表示首冲优惠
	int _privilegeType;	
	//标签描述id
	List<int> _labelDescription = new List<int>();
	//商品库存（可购买次数，0为无限）
	int _count;	
	//购买前置条件（前置条件类型：condition值，前置条件类型参见附表)0:0表示为空
	RechargePreCondition _precondition;	
	//是否显示标签，0表示不显示，1表示显示
	int _displayLabel;	
	//商品按类型分类显示，1表示活动类商品；2表示超值优惠类；3表示常规魂玉类，4表示VIP礼包
	int _commodityDisplayType;	
	//是否为魂玉翻倍活动的商品，1表示是，0表示不是
	int _activityCommodity;	
	//苹果商店商品id
	string _iOSAppProductId;	
	//赠品内容信息配合ItemConfig使用（道具ID：数量，允许为空，空表示没有）
	List<ItemInfo> _ExtraReward = new List<ItemInfo>();
	//备用商品ID1号
	string _extProductId1;	
	//备用商品ID2号
	string _extProductId2;	
	//备用商品ID3号
	string _extProductId3;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//商品ID
		SerializeUtils.WriteInt(stream, _commodityId);
		//商品信息ID配合ItemConfig使用
		SerializeUtils.WriteInt(stream, _itemID);
		//商品类型（1月卡，2永久卡，3成长卡, 4魂玉包（或是其他道具包））
		SerializeUtils.WriteInt(stream, _commodityType);
		//信息类型，1为魂玉商品，2为非魂玉商品
		SerializeUtils.WriteInt(stream, _infoType);
		//商品售价（图标ID：价格）ID1为RMB，ID2为魂玉
		SerializeUtils.WriteBean(stream, _commodityPrice);
		//首次购买该商品时商品数量的额外倍数
		SerializeUtils.WriteInt(stream, _firstMultiple);
		//商品对应的基础道具数量，购买商品得到的道具数量=BaseReward *FirstMultiple(10:30为特殊，表示月卡持续时间为30天，-1表示持续时间为永久)
		SerializeUtils.WriteShort(stream, (short)_baseReward.Count);

		foreach (var element in _baseReward)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//商品排序（0-100为雪花雪球类的活动商品；101-200为组合包系列活动商品；201-300为活动多倍魂玉档；301-400为常规商品；401以上为VIP礼包）
		SerializeUtils.WriteInt(stream, _sort);
		//优惠次数，0表示无优惠，1表示首冲优惠
		SerializeUtils.WriteInt(stream, _privilegeType);
		//标签描述id
		SerializeUtils.WriteShort(stream, (short)_labelDescription.Count);

		foreach (var element in _labelDescription)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
		//商品库存（可购买次数，0为无限）
		SerializeUtils.WriteInt(stream, _count);
		//购买前置条件（前置条件类型：condition值，前置条件类型参见附表)0:0表示为空
		SerializeUtils.WriteBean(stream, _precondition);
		//是否显示标签，0表示不显示，1表示显示
		SerializeUtils.WriteInt(stream, _displayLabel);
		//商品按类型分类显示，1表示活动类商品；2表示超值优惠类；3表示常规魂玉类，4表示VIP礼包
		SerializeUtils.WriteInt(stream, _commodityDisplayType);
		//是否为魂玉翻倍活动的商品，1表示是，0表示不是
		SerializeUtils.WriteInt(stream, _activityCommodity);
		//苹果商店商品id
		SerializeUtils.WriteString(stream, _iOSAppProductId);
		//赠品内容信息配合ItemConfig使用（道具ID：数量，允许为空，空表示没有）
		SerializeUtils.WriteShort(stream, (short)_ExtraReward.Count);

		foreach (var element in _ExtraReward)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//备用商品ID1号
		SerializeUtils.WriteString(stream, _extProductId1);
		//备用商品ID2号
		SerializeUtils.WriteString(stream, _extProductId2);
		//备用商品ID3号
		SerializeUtils.WriteString(stream, _extProductId3);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//商品ID
		_commodityId = SerializeUtils.ReadInt(stream);
		//商品信息ID配合ItemConfig使用
		_itemID = SerializeUtils.ReadInt(stream);
		//商品类型（1月卡，2永久卡，3成长卡, 4魂玉包（或是其他道具包））
		_commodityType = SerializeUtils.ReadInt(stream);
		//信息类型，1为魂玉商品，2为非魂玉商品
		_infoType = SerializeUtils.ReadInt(stream);
		//商品售价（图标ID：价格）ID1为RMB，ID2为魂玉
		_commodityPrice = SerializeUtils.ReadBean<RechargePrice>(stream);
		//首次购买该商品时商品数量的额外倍数
		_firstMultiple = SerializeUtils.ReadInt(stream);
		//商品对应的基础道具数量，购买商品得到的道具数量=BaseReward *FirstMultiple(10:30为特殊，表示月卡持续时间为30天，-1表示持续时间为永久)
		int _baseReward_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _baseReward_length; ++i) 
		{
			_baseReward.Add(SerializeUtils.ReadBean<ItemInfo>(stream));
		}
		//商品排序（0-100为雪花雪球类的活动商品；101-200为组合包系列活动商品；201-300为活动多倍魂玉档；301-400为常规商品；401以上为VIP礼包）
		_sort = SerializeUtils.ReadInt(stream);
		//优惠次数，0表示无优惠，1表示首冲优惠
		_privilegeType = SerializeUtils.ReadInt(stream);
		//标签描述id
		int _labelDescription_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _labelDescription_length; ++i) 
		{
			_labelDescription.Add(SerializeUtils.ReadInt(stream));
		}
		//商品库存（可购买次数，0为无限）
		_count = SerializeUtils.ReadInt(stream);
		//购买前置条件（前置条件类型：condition值，前置条件类型参见附表)0:0表示为空
		_precondition = SerializeUtils.ReadBean<RechargePreCondition>(stream);
		//是否显示标签，0表示不显示，1表示显示
		_displayLabel = SerializeUtils.ReadInt(stream);
		//商品按类型分类显示，1表示活动类商品；2表示超值优惠类；3表示常规魂玉类，4表示VIP礼包
		_commodityDisplayType = SerializeUtils.ReadInt(stream);
		//是否为魂玉翻倍活动的商品，1表示是，0表示不是
		_activityCommodity = SerializeUtils.ReadInt(stream);
		//苹果商店商品id
		_iOSAppProductId = SerializeUtils.ReadString(stream);
		//赠品内容信息配合ItemConfig使用（道具ID：数量，允许为空，空表示没有）
		int _ExtraReward_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _ExtraReward_length; ++i) 
		{
			_ExtraReward.Add(SerializeUtils.ReadBean<ItemInfo>(stream));
		}
		//备用商品ID1号
		_extProductId1 = SerializeUtils.ReadString(stream);
		//备用商品ID2号
		_extProductId2 = SerializeUtils.ReadString(stream);
		//备用商品ID3号
		_extProductId3 = SerializeUtils.ReadString(stream);
	}
	
	/**
	 * 商品ID
	 */
	public int CommodityId
	{
		set { _commodityId = value; }
	    get { return _commodityId; }
	}
	
	/**
	 * 商品信息ID配合ItemConfig使用
	 */
	public int ItemID
	{
		set { _itemID = value; }
	    get { return _itemID; }
	}
	
	/**
	 * 商品类型（1月卡，2永久卡，3成长卡, 4魂玉包（或是其他道具包））
	 */
	public int CommodityType
	{
		set { _commodityType = value; }
	    get { return _commodityType; }
	}
	
	/**
	 * 信息类型，1为魂玉商品，2为非魂玉商品
	 */
	public int InfoType
	{
		set { _infoType = value; }
	    get { return _infoType; }
	}
	
	/**
	 * 商品售价（图标ID：价格）ID1为RMB，ID2为魂玉
	 */
	public RechargePrice CommodityPrice
	{
		set { _commodityPrice = value; }
	    get { return _commodityPrice; }
	}
	
	/**
	 * 首次购买该商品时商品数量的额外倍数
	 */
	public int FirstMultiple
	{
		set { _firstMultiple = value; }
	    get { return _firstMultiple; }
	}
	
	/**
	 * get 商品对应的基础道具数量，购买商品得到的道具数量=BaseReward *FirstMultiple(10:30为特殊，表示月卡持续时间为30天，-1表示持续时间为永久)
	 * @return 
	 */
	public List<ItemInfo> GetBaseReward()
	{
		return _baseReward;
	}
	
	/**
	 * set 商品对应的基础道具数量，购买商品得到的道具数量=BaseReward *FirstMultiple(10:30为特殊，表示月卡持续时间为30天，-1表示持续时间为永久)
	 */
	public void SetBaseReward(List<ItemInfo> baseReward)
	{
		_baseReward = baseReward;
	}
	
	/**
	 * 商品排序（0-100为雪花雪球类的活动商品；101-200为组合包系列活动商品；201-300为活动多倍魂玉档；301-400为常规商品；401以上为VIP礼包）
	 */
	public int Sort
	{
		set { _sort = value; }
	    get { return _sort; }
	}
	
	/**
	 * 优惠次数，0表示无优惠，1表示首冲优惠
	 */
	public int PrivilegeType
	{
		set { _privilegeType = value; }
	    get { return _privilegeType; }
	}
	
	/**
	 * get 标签描述id
	 * @return 
	 */
	public List<int> GetLabelDescription()
	{
		return _labelDescription;
	}
	
	/**
	 * set 标签描述id
	 */
	public void SetLabelDescription(List<int> labelDescription)
	{
		_labelDescription = labelDescription;
	}
	
	/**
	 * 商品库存（可购买次数，0为无限）
	 */
	public int Count
	{
		set { _count = value; }
	    get { return _count; }
	}
	
	/**
	 * 购买前置条件（前置条件类型：condition值，前置条件类型参见附表)0:0表示为空
	 */
	public RechargePreCondition Precondition
	{
		set { _precondition = value; }
	    get { return _precondition; }
	}
	
	/**
	 * 是否显示标签，0表示不显示，1表示显示
	 */
	public int DisplayLabel
	{
		set { _displayLabel = value; }
	    get { return _displayLabel; }
	}
	
	/**
	 * 商品按类型分类显示，1表示活动类商品；2表示超值优惠类；3表示常规魂玉类，4表示VIP礼包
	 */
	public int CommodityDisplayType
	{
		set { _commodityDisplayType = value; }
	    get { return _commodityDisplayType; }
	}
	
	/**
	 * 是否为魂玉翻倍活动的商品，1表示是，0表示不是
	 */
	public int ActivityCommodity
	{
		set { _activityCommodity = value; }
	    get { return _activityCommodity; }
	}
	
	/**
	 * 苹果商店商品id
	 */
	public string IOSAppProductId
	{
		set { _iOSAppProductId = value; }
	    get { return _iOSAppProductId; }
	}
	
	/**
	 * get 赠品内容信息配合ItemConfig使用（道具ID：数量，允许为空，空表示没有）
	 * @return 
	 */
	public List<ItemInfo> GetExtraReward()
	{
		return _ExtraReward;
	}
	
	/**
	 * set 赠品内容信息配合ItemConfig使用（道具ID：数量，允许为空，空表示没有）
	 */
	public void SetExtraReward(List<ItemInfo> ExtraReward)
	{
		_ExtraReward = ExtraReward;
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
	
}