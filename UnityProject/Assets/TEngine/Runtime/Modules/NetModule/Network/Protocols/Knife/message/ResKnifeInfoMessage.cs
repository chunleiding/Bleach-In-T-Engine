using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 斩魄刀初始化信息 message
 */
public class ResKnifeInfoMessage : Message 
{
	//斩魄刀皮肤信息
	List<KnifeSkinInfo> _skinList = new List<KnifeSkinInfo>();
	//斩魄刀阶级id
	int _knifeStageId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//斩魄刀皮肤信息
		SerializeUtils.WriteShort(stream, (short)_skinList.Count);

		foreach (var element in _skinList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//斩魄刀阶级id
		SerializeUtils.WriteInt(stream, _knifeStageId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//斩魄刀皮肤信息
		int _skinList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _skinList_length; ++i) 
		{
			_skinList.Add(SerializeUtils.ReadBean<KnifeSkinInfo>(stream));
		}
		//斩魄刀阶级id
		_knifeStageId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * get 斩魄刀皮肤信息
	 * @return 
	 */
	public List<KnifeSkinInfo> GetSkinList()
	{
		return _skinList;
	}
	
	/**
	 * set 斩魄刀皮肤信息
	 */
	public void SetSkinList(List<KnifeSkinInfo> skinList)
	{
		_skinList = skinList;
	}
	
	/**
	 * 斩魄刀阶级id
	 */
	public int KnifeStageId
	{
		set { _knifeStageId = value; }
	    get { return _knifeStageId; }
	}
	
	
	public override int GetId() 
	{
		return 816100;
	}
}