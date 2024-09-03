using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 宠物猪所有配置 message
 */
public class ResPetBoniAllInfoMessage : Message 
{
	//宠物每个等级对应的所有配置
	List<PetBoniInfo> _petInfo = new List<PetBoniInfo>();
	//宠物最大等级
	int _petMaxLevel;	
	//免费食材道具id：增加饱食度
	ItemInfo _petFreeFood;	
	//免费食材每日饱食度上限
	int _petFreeDailySatiety;	
	//付费食材每日饱食度上限
	int _petPayDailySatiety;	
	//宠物每日总饱食度上限
	int _petSumDailySatiety;	
	//1点饱食度对应多少点经验值
	int _petSatietyExchangeExperience;	
	//付费食材道具id：增加饱食度
	ItemInfo _petPayFood;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//宠物每个等级对应的所有配置
		SerializeUtils.WriteShort(stream, (short)_petInfo.Count);

		foreach (var element in _petInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//宠物最大等级
		SerializeUtils.WriteInt(stream, _petMaxLevel);
		//免费食材道具id：增加饱食度
		SerializeUtils.WriteBean(stream, _petFreeFood);
		//免费食材每日饱食度上限
		SerializeUtils.WriteInt(stream, _petFreeDailySatiety);
		//付费食材每日饱食度上限
		SerializeUtils.WriteInt(stream, _petPayDailySatiety);
		//宠物每日总饱食度上限
		SerializeUtils.WriteInt(stream, _petSumDailySatiety);
		//1点饱食度对应多少点经验值
		SerializeUtils.WriteInt(stream, _petSatietyExchangeExperience);
		//付费食材道具id：增加饱食度
		SerializeUtils.WriteBean(stream, _petPayFood);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//宠物每个等级对应的所有配置
		int _petInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _petInfo_length; ++i) 
		{
			_petInfo.Add(SerializeUtils.ReadBean<PetBoniInfo>(stream));
		}
		//宠物最大等级
		_petMaxLevel = SerializeUtils.ReadInt(stream);
		//免费食材道具id：增加饱食度
		_petFreeFood = SerializeUtils.ReadBean<ItemInfo>(stream);
		//免费食材每日饱食度上限
		_petFreeDailySatiety = SerializeUtils.ReadInt(stream);
		//付费食材每日饱食度上限
		_petPayDailySatiety = SerializeUtils.ReadInt(stream);
		//宠物每日总饱食度上限
		_petSumDailySatiety = SerializeUtils.ReadInt(stream);
		//1点饱食度对应多少点经验值
		_petSatietyExchangeExperience = SerializeUtils.ReadInt(stream);
		//付费食材道具id：增加饱食度
		_petPayFood = SerializeUtils.ReadBean<ItemInfo>(stream);
	}
	
	/**
	 * get 宠物每个等级对应的所有配置
	 * @return 
	 */
	public List<PetBoniInfo> GetPetInfo()
	{
		return _petInfo;
	}
	
	/**
	 * set 宠物每个等级对应的所有配置
	 */
	public void SetPetInfo(List<PetBoniInfo> petInfo)
	{
		_petInfo = petInfo;
	}
	
	/**
	 * 宠物最大等级
	 */
	public int PetMaxLevel
	{
		set { _petMaxLevel = value; }
	    get { return _petMaxLevel; }
	}
	
	/**
	 * 免费食材道具id：增加饱食度
	 */
	public ItemInfo PetFreeFood
	{
		set { _petFreeFood = value; }
	    get { return _petFreeFood; }
	}
	
	/**
	 * 免费食材每日饱食度上限
	 */
	public int PetFreeDailySatiety
	{
		set { _petFreeDailySatiety = value; }
	    get { return _petFreeDailySatiety; }
	}
	
	/**
	 * 付费食材每日饱食度上限
	 */
	public int PetPayDailySatiety
	{
		set { _petPayDailySatiety = value; }
	    get { return _petPayDailySatiety; }
	}
	
	/**
	 * 宠物每日总饱食度上限
	 */
	public int PetSumDailySatiety
	{
		set { _petSumDailySatiety = value; }
	    get { return _petSumDailySatiety; }
	}
	
	/**
	 * 1点饱食度对应多少点经验值
	 */
	public int PetSatietyExchangeExperience
	{
		set { _petSatietyExchangeExperience = value; }
	    get { return _petSatietyExchangeExperience; }
	}
	
	/**
	 * 付费食材道具id：增加饱食度
	 */
	public ItemInfo PetPayFood
	{
		set { _petPayFood = value; }
	    get { return _petPayFood; }
	}
	
	
	public override int GetId() 
	{
		return 822100;
	}
}