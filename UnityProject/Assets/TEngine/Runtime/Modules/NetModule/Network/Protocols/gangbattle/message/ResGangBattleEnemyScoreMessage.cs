using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 对战期敌方番队总积分 message
 */
public class ResGangBattleEnemyScoreMessage : Message 
{
	//敌方番队积分
	int _score;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//敌方番队积分
		SerializeUtils.WriteInt(stream, _score);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//敌方番队积分
		_score = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 敌方番队积分
	 */
	public int Score
	{
		set { _score = value; }
	    get { return _score; }
	}
	
	
	public override int GetId() 
	{
		return 112115;
	}
}