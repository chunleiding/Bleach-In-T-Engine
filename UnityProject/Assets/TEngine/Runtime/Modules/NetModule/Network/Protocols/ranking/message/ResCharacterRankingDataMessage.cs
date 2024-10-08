using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 角色排行榜数据 message
 */
public class ResCharacterRankingDataMessage : Message 
{
	//角色排行榜列表
	List<CharacterRankingBean> _characterRankingData = new List<CharacterRankingBean>();
	//周评
	string _weekComment;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//角色排行榜列表
		SerializeUtils.WriteShort(stream, (short)_characterRankingData.Count);

		foreach (var element in _characterRankingData)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//周评
		SerializeUtils.WriteString(stream, _weekComment);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//角色排行榜列表
		int _characterRankingData_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _characterRankingData_length; ++i) 
		{
			_characterRankingData.Add(SerializeUtils.ReadBean<CharacterRankingBean>(stream));
		}
		//周评
		_weekComment = SerializeUtils.ReadString(stream);
	}
	
	/**
	 * get 角色排行榜列表
	 * @return 
	 */
	public List<CharacterRankingBean> GetCharacterRankingData()
	{
		return _characterRankingData;
	}
	
	/**
	 * set 角色排行榜列表
	 */
	public void SetCharacterRankingData(List<CharacterRankingBean> characterRankingData)
	{
		_characterRankingData = characterRankingData;
	}
	
	/**
	 * 周评
	 */
	public string WeekComment
	{
		set { _weekComment = value; }
	    get { return _weekComment; }
	}
	
	
	public override int GetId() 
	{
		return 209103;
	}
}