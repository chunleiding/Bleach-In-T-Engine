using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求交换元素 message
 */
public class ReqSwapMessage : Message 
{
	//交换的坐标列表（1个为特殊元素，2个为普通元素）
	List<int> _indexList = new List<int>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//交换的坐标列表（1个为特殊元素，2个为普通元素）
		SerializeUtils.WriteShort(stream, (short)_indexList.Count);

		foreach (var element in _indexList)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//交换的坐标列表（1个为特殊元素，2个为普通元素）
		int _indexList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _indexList_length; ++i) 
		{
			_indexList.Add(SerializeUtils.ReadInt(stream));
		}
	}
	
	/**
	 * get 交换的坐标列表（1个为特殊元素，2个为普通元素）
	 * @return 
	 */
	public List<int> GetIndexList()
	{
		return _indexList;
	}
	
	/**
	 * set 交换的坐标列表（1个为特殊元素，2个为普通元素）
	 */
	public void SetIndexList(List<int> indexList)
	{
		_indexList = indexList;
	}
	
	
	public override int GetId() 
	{
		return 821101;
	}
}