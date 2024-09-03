using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 游戏设置信息 message
 */
public class ReqPlayerSettingMessage : Message 
{
	//操作：0请求数据，1数据改变通知服务器
	int _operation;	
	//背景音乐（万分比分子）
	int _backgroundVolume;	
	//效果音量（万分比分子）
	int _effectVolume;	
	//显示推送：0显示，1不显示
	int _showNotification;	
	//操作模式：0划屏，1摇杆
	int _controllMode;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//操作：0请求数据，1数据改变通知服务器
		SerializeUtils.WriteInt(stream, _operation);
		//背景音乐（万分比分子）
		SerializeUtils.WriteInt(stream, _backgroundVolume);
		//效果音量（万分比分子）
		SerializeUtils.WriteInt(stream, _effectVolume);
		//显示推送：0显示，1不显示
		SerializeUtils.WriteInt(stream, _showNotification);
		//操作模式：0划屏，1摇杆
		SerializeUtils.WriteInt(stream, _controllMode);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//操作：0请求数据，1数据改变通知服务器
		_operation = SerializeUtils.ReadInt(stream);
		//背景音乐（万分比分子）
		_backgroundVolume = SerializeUtils.ReadInt(stream);
		//效果音量（万分比分子）
		_effectVolume = SerializeUtils.ReadInt(stream);
		//显示推送：0显示，1不显示
		_showNotification = SerializeUtils.ReadInt(stream);
		//操作模式：0划屏，1摇杆
		_controllMode = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 操作：0请求数据，1数据改变通知服务器
	 */
	public int Operation
	{
		set { _operation = value; }
	    get { return _operation; }
	}
	
	/**
	 * 背景音乐（万分比分子）
	 */
	public int BackgroundVolume
	{
		set { _backgroundVolume = value; }
	    get { return _backgroundVolume; }
	}
	
	/**
	 * 效果音量（万分比分子）
	 */
	public int EffectVolume
	{
		set { _effectVolume = value; }
	    get { return _effectVolume; }
	}
	
	/**
	 * 显示推送：0显示，1不显示
	 */
	public int ShowNotification
	{
		set { _showNotification = value; }
	    get { return _showNotification; }
	}
	
	/**
	 * 操作模式：0划屏，1摇杆
	 */
	public int ControllMode
	{
		set { _controllMode = value; }
	    get { return _controllMode; }
	}
	
	
	public override int GetId() 
	{
		return 105208;
	}
}