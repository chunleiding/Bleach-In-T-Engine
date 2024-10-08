using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 开启特训箱子 message
 */
public class ReqOpenSpecialTrainingBoxMessage : Message 
{
	//箱子的位置(0到8)
	int _boxIndex;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//箱子的位置(0到8)
		SerializeUtils.WriteInt(stream, _boxIndex);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//箱子的位置(0到8)
		_boxIndex = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 箱子的位置(0到8)
	 */
	public int BoxIndex
	{
		set { _boxIndex = value; }
	    get { return _boxIndex; }
	}
	
	
	public override int GetId() 
	{
		return 310202;
	}
}