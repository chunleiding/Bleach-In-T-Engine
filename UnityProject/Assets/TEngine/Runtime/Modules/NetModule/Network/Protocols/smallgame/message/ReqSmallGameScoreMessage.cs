using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 小游戏积分 message
 */
public class ReqSmallGameScoreMessage : Message 
{
	//积分
	int _score;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//积分
		SerializeUtils.WriteInt(stream, _score);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//积分
		_score = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 积分
	 */
	public int Score
	{
		set { _score = value; }
	    get { return _score; }
	}
	
	
	public override int GetId() 
	{
		return 815100;
	}
}