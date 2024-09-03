using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 同步最新分数和血量 message
 */
public class ResScoreHpChangedMessage : Message 
{
	//玩家最新分数
	int _score;	
	//玩家一护试炼血量
	int _ichigoTrialHp;	
	//积分的颜色 1：绿色；2：蓝色；3：紫色；4：橙色
	int _scoreColor;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//玩家最新分数
		SerializeUtils.WriteInt(stream, _score);
		//玩家一护试炼血量
		SerializeUtils.WriteInt(stream, _ichigoTrialHp);
		//积分的颜色 1：绿色；2：蓝色；3：紫色；4：橙色
		SerializeUtils.WriteInt(stream, _scoreColor);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//玩家最新分数
		_score = SerializeUtils.ReadInt(stream);
		//玩家一护试炼血量
		_ichigoTrialHp = SerializeUtils.ReadInt(stream);
		//积分的颜色 1：绿色；2：蓝色；3：紫色；4：橙色
		_scoreColor = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 玩家最新分数
	 */
	public int Score
	{
		set { _score = value; }
	    get { return _score; }
	}
	
	/**
	 * 玩家一护试炼血量
	 */
	public int IchigoTrialHp
	{
		set { _ichigoTrialHp = value; }
	    get { return _ichigoTrialHp; }
	}
	
	/**
	 * 积分的颜色 1：绿色；2：蓝色；3：紫色；4：橙色
	 */
	public int ScoreColor
	{
		set { _scoreColor = value; }
	    get { return _scoreColor; }
	}
	
	
	public override int GetId() 
	{
		return 825114;
	}
}