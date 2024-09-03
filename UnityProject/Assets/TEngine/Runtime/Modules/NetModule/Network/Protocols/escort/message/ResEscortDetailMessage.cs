using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 接受护送界面信息 message
 */
public class ResEscortDetailMessage : Message 
{
	//护送主界面信息
	EscortMainDetailInfo _escortInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//护送主界面信息
		SerializeUtils.WriteBean(stream, _escortInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//护送主界面信息
		_escortInfo = SerializeUtils.ReadBean<EscortMainDetailInfo>(stream);
	}
	
	/**
	 * 护送主界面信息
	 */
	public EscortMainDetailInfo EscortInfo
	{
		set { _escortInfo = value; }
	    get { return _escortInfo; }
	}
	
	
	public override int GetId() 
	{
		return 810111;
	}
}