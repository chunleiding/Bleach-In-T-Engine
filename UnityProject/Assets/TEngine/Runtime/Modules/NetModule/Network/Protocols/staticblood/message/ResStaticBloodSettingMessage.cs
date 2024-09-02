using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 前端setting表信息 message
 */
public class ResStaticBloodSettingMessage : Message 
{
	//开启等级
	int _needLevel;	
	//当玩家角色静血装达到满阶角色个数转化能量显示（1个角色达到满阶,能量；2个角色达到满阶，能量;三个角色达到满阶，能量；。。。。。。。）
	List<StaticBloodEnergy> _actorFullStageEnergy = new List<StaticBloodEnergy>();
	//静血装总星数提升基础能量值百分比（星数,万分比；星数,万分比；。。。。。）
	List<StaticBloodEnergy> _totalStarEnergy = new List<StaticBloodEnergy>();
	//战斗力系数(万分比分子)
	int _fightPowerRatio;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//开启等级
		SerializeUtils.WriteInt(stream, _needLevel);
		//当玩家角色静血装达到满阶角色个数转化能量显示（1个角色达到满阶,能量；2个角色达到满阶，能量;三个角色达到满阶，能量；。。。。。。。）
		SerializeUtils.WriteShort(stream, (short)_actorFullStageEnergy.Count);

		foreach (var element in _actorFullStageEnergy)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//静血装总星数提升基础能量值百分比（星数,万分比；星数,万分比；。。。。。）
		SerializeUtils.WriteShort(stream, (short)_totalStarEnergy.Count);

		foreach (var element in _totalStarEnergy)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//战斗力系数(万分比分子)
		SerializeUtils.WriteInt(stream, _fightPowerRatio);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//开启等级
		_needLevel = SerializeUtils.ReadInt(stream);
		//当玩家角色静血装达到满阶角色个数转化能量显示（1个角色达到满阶,能量；2个角色达到满阶，能量;三个角色达到满阶，能量；。。。。。。。）
		int _actorFullStageEnergy_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _actorFullStageEnergy_length; ++i) 
		{
			_actorFullStageEnergy.Add(SerializeUtils.ReadBean<StaticBloodEnergy>(stream));
		}
		//静血装总星数提升基础能量值百分比（星数,万分比；星数,万分比；。。。。。）
		int _totalStarEnergy_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _totalStarEnergy_length; ++i) 
		{
			_totalStarEnergy.Add(SerializeUtils.ReadBean<StaticBloodEnergy>(stream));
		}
		//战斗力系数(万分比分子)
		_fightPowerRatio = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 开启等级
	 */
	public int NeedLevel
	{
		set { _needLevel = value; }
	    get { return _needLevel; }
	}
	
	/**
	 * get 当玩家角色静血装达到满阶角色个数转化能量显示（1个角色达到满阶,能量；2个角色达到满阶，能量;三个角色达到满阶，能量；。。。。。。。）
	 * @return 
	 */
	public List<StaticBloodEnergy> GetActorFullStageEnergy()
	{
		return _actorFullStageEnergy;
	}
	
	/**
	 * set 当玩家角色静血装达到满阶角色个数转化能量显示（1个角色达到满阶,能量；2个角色达到满阶，能量;三个角色达到满阶，能量；。。。。。。。）
	 */
	public void SetActorFullStageEnergy(List<StaticBloodEnergy> actorFullStageEnergy)
	{
		_actorFullStageEnergy = actorFullStageEnergy;
	}
	
	/**
	 * get 静血装总星数提升基础能量值百分比（星数,万分比；星数,万分比；。。。。。）
	 * @return 
	 */
	public List<StaticBloodEnergy> GetTotalStarEnergy()
	{
		return _totalStarEnergy;
	}
	
	/**
	 * set 静血装总星数提升基础能量值百分比（星数,万分比；星数,万分比；。。。。。）
	 */
	public void SetTotalStarEnergy(List<StaticBloodEnergy> totalStarEnergy)
	{
		_totalStarEnergy = totalStarEnergy;
	}
	
	/**
	 * 战斗力系数(万分比分子)
	 */
	public int FightPowerRatio
	{
		set { _fightPowerRatio = value; }
	    get { return _fightPowerRatio; }
	}
	
	
	public override int GetId() 
	{
		return 812103;
	}
}