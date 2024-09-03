using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 收到的节日称号列表 message
 */
public class ResSpecialTitleListMessage : Message 
{
	//节日称号列表
	List<SpecialTitleInfo> _specialTitleList = new List<SpecialTitleInfo>();
	//购买剩余时间:秒
	int _leftTime;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//节日称号列表
		SerializeUtils.WriteShort(stream, (short)_specialTitleList.Count);

		foreach (var element in _specialTitleList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//购买剩余时间:秒
		SerializeUtils.WriteInt(stream, _leftTime);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//节日称号列表
		int _specialTitleList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _specialTitleList_length; ++i) 
		{
			_specialTitleList.Add(SerializeUtils.ReadBean<SpecialTitleInfo>(stream));
		}
		//购买剩余时间:秒
		_leftTime = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * get 节日称号列表
	 * @return 
	 */
	public List<SpecialTitleInfo> GetSpecialTitleList()
	{
		return _specialTitleList;
	}
	
	/**
	 * set 节日称号列表
	 */
	public void SetSpecialTitleList(List<SpecialTitleInfo> specialTitleList)
	{
		_specialTitleList = specialTitleList;
	}
	
	/**
	 * 购买剩余时间:秒
	 */
	public int LeftTime
	{
		set { _leftTime = value; }
	    get { return _leftTime; }
	}
	
	
	public override int GetId() 
	{
		return 827110;
	}
}