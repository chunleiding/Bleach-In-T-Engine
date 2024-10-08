using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 对战期自己番队总积分 message
 */
public class ResGangBattleSelfScoreMessage : Message 
{
	//自己番队积分
	int _score;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//自己番队积分
		SerializeUtils.WriteInt(stream, _score);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//自己番队积分
		_score = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 自己番队积分
	 */
	public int Score
	{
		set { _score = value; }
	    get { return _score; }
	}
	
	
	public override int GetId() 
	{
		return 112114;
	}
}