using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 游戏设置信息 message
 */
public class ResPlayerSettingMessage : Message 
{
	//背景音乐(万分比分子)
	int _backgroundVolume;	
	//效果音量(万分比分子)
	int _effectVolume;	
	//显示推送，0显示1不显示
	int _sowNotification;	
	//操作模式，0划屏1摇杆
	int _controllMode;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//背景音乐(万分比分子)
		SerializeUtils.WriteInt(stream, _backgroundVolume);
		//效果音量(万分比分子)
		SerializeUtils.WriteInt(stream, _effectVolume);
		//显示推送，0显示1不显示
		SerializeUtils.WriteInt(stream, _sowNotification);
		//操作模式，0划屏1摇杆
		SerializeUtils.WriteInt(stream, _controllMode);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//背景音乐(万分比分子)
		_backgroundVolume = SerializeUtils.ReadInt(stream);
		//效果音量(万分比分子)
		_effectVolume = SerializeUtils.ReadInt(stream);
		//显示推送，0显示1不显示
		_sowNotification = SerializeUtils.ReadInt(stream);
		//操作模式，0划屏1摇杆
		_controllMode = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 背景音乐(万分比分子)
	 */
	public int BackgroundVolume
	{
		set { _backgroundVolume = value; }
	    get { return _backgroundVolume; }
	}
	
	/**
	 * 效果音量(万分比分子)
	 */
	public int EffectVolume
	{
		set { _effectVolume = value; }
	    get { return _effectVolume; }
	}
	
	/**
	 * 显示推送，0显示1不显示
	 */
	public int SowNotification
	{
		set { _sowNotification = value; }
	    get { return _sowNotification; }
	}
	
	/**
	 * 操作模式，0划屏1摇杆
	 */
	public int ControllMode
	{
		set { _controllMode = value; }
	    get { return _controllMode; }
	}
	
	
	public override int GetId() 
	{
		return 105209;
	}
}