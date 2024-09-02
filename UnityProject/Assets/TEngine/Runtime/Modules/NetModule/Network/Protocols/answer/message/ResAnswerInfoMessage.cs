using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 发送答题信息 message
 */
public class ResAnswerInfoMessage : Message 
{
	//当前积分
	int _score;	
	//总题数
	int _totalNum;	
	//当前题数
	int _currentNum;	
	//本轮剩余时间（秒）
	int _roundLeftTime;	
	//活动开始剩余时间（秒）
	int _openLeftTime;	
	//活动开始时间
	string _openTime;	
	//活动状态（0:活动未开启，1:活动进行中，2:活动已结束）
	int _state;	
	//答对数量超过本服玩家占比
	int _beyondNum;	
	//题目ID
	int _questionId;	
	//A选项支持率（百分比数值）
	int _selectA;	
	//B选项支持率（百分比数值）
	int _selectB;	
	//C选项支持率（百分比数值）
	int _selectC;	
	//D选项支持率（百分比数值）
	int _selectD;	
	//正确选项
	string _correct;	
	//第几轮
	int _round;	
	//选择状态(0:未选，1:选了)
	int _choseState;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//当前积分
		SerializeUtils.WriteInt(stream, _score);
		//总题数
		SerializeUtils.WriteInt(stream, _totalNum);
		//当前题数
		SerializeUtils.WriteInt(stream, _currentNum);
		//本轮剩余时间（秒）
		SerializeUtils.WriteInt(stream, _roundLeftTime);
		//活动开始剩余时间（秒）
		SerializeUtils.WriteInt(stream, _openLeftTime);
		//活动开始时间
		SerializeUtils.WriteString(stream, _openTime);
		//活动状态（0:活动未开启，1:活动进行中，2:活动已结束）
		SerializeUtils.WriteInt(stream, _state);
		//答对数量超过本服玩家占比
		SerializeUtils.WriteInt(stream, _beyondNum);
		//题目ID
		SerializeUtils.WriteInt(stream, _questionId);
		//A选项支持率（百分比数值）
		SerializeUtils.WriteInt(stream, _selectA);
		//B选项支持率（百分比数值）
		SerializeUtils.WriteInt(stream, _selectB);
		//C选项支持率（百分比数值）
		SerializeUtils.WriteInt(stream, _selectC);
		//D选项支持率（百分比数值）
		SerializeUtils.WriteInt(stream, _selectD);
		//正确选项
		SerializeUtils.WriteString(stream, _correct);
		//第几轮
		SerializeUtils.WriteInt(stream, _round);
		//选择状态(0:未选，1:选了)
		SerializeUtils.WriteInt(stream, _choseState);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//当前积分
		_score = SerializeUtils.ReadInt(stream);
		//总题数
		_totalNum = SerializeUtils.ReadInt(stream);
		//当前题数
		_currentNum = SerializeUtils.ReadInt(stream);
		//本轮剩余时间（秒）
		_roundLeftTime = SerializeUtils.ReadInt(stream);
		//活动开始剩余时间（秒）
		_openLeftTime = SerializeUtils.ReadInt(stream);
		//活动开始时间
		_openTime = SerializeUtils.ReadString(stream);
		//活动状态（0:活动未开启，1:活动进行中，2:活动已结束）
		_state = SerializeUtils.ReadInt(stream);
		//答对数量超过本服玩家占比
		_beyondNum = SerializeUtils.ReadInt(stream);
		//题目ID
		_questionId = SerializeUtils.ReadInt(stream);
		//A选项支持率（百分比数值）
		_selectA = SerializeUtils.ReadInt(stream);
		//B选项支持率（百分比数值）
		_selectB = SerializeUtils.ReadInt(stream);
		//C选项支持率（百分比数值）
		_selectC = SerializeUtils.ReadInt(stream);
		//D选项支持率（百分比数值）
		_selectD = SerializeUtils.ReadInt(stream);
		//正确选项
		_correct = SerializeUtils.ReadString(stream);
		//第几轮
		_round = SerializeUtils.ReadInt(stream);
		//选择状态(0:未选，1:选了)
		_choseState = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 当前积分
	 */
	public int Score
	{
		set { _score = value; }
	    get { return _score; }
	}
	
	/**
	 * 总题数
	 */
	public int TotalNum
	{
		set { _totalNum = value; }
	    get { return _totalNum; }
	}
	
	/**
	 * 当前题数
	 */
	public int CurrentNum
	{
		set { _currentNum = value; }
	    get { return _currentNum; }
	}
	
	/**
	 * 本轮剩余时间（秒）
	 */
	public int RoundLeftTime
	{
		set { _roundLeftTime = value; }
	    get { return _roundLeftTime; }
	}
	
	/**
	 * 活动开始剩余时间（秒）
	 */
	public int OpenLeftTime
	{
		set { _openLeftTime = value; }
	    get { return _openLeftTime; }
	}
	
	/**
	 * 活动开始时间
	 */
	public string OpenTime
	{
		set { _openTime = value; }
	    get { return _openTime; }
	}
	
	/**
	 * 活动状态（0:活动未开启，1:活动进行中，2:活动已结束）
	 */
	public int State
	{
		set { _state = value; }
	    get { return _state; }
	}
	
	/**
	 * 答对数量超过本服玩家占比
	 */
	public int BeyondNum
	{
		set { _beyondNum = value; }
	    get { return _beyondNum; }
	}
	
	/**
	 * 题目ID
	 */
	public int QuestionId
	{
		set { _questionId = value; }
	    get { return _questionId; }
	}
	
	/**
	 * A选项支持率（百分比数值）
	 */
	public int SelectA
	{
		set { _selectA = value; }
	    get { return _selectA; }
	}
	
	/**
	 * B选项支持率（百分比数值）
	 */
	public int SelectB
	{
		set { _selectB = value; }
	    get { return _selectB; }
	}
	
	/**
	 * C选项支持率（百分比数值）
	 */
	public int SelectC
	{
		set { _selectC = value; }
	    get { return _selectC; }
	}
	
	/**
	 * D选项支持率（百分比数值）
	 */
	public int SelectD
	{
		set { _selectD = value; }
	    get { return _selectD; }
	}
	
	/**
	 * 正确选项
	 */
	public string Correct
	{
		set { _correct = value; }
	    get { return _correct; }
	}
	
	/**
	 * 第几轮
	 */
	public int Round
	{
		set { _round = value; }
	    get { return _round; }
	}
	
	/**
	 * 选择状态(0:未选，1:选了)
	 */
	public int ChoseState
	{
		set { _choseState = value; }
	    get { return _choseState; }
	}
	
	
	public override int GetId() 
	{
		return 808105;
	}
}