using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 实时同步剩余血量
 */
public class SyncHp : IMessageSerialize 
{
	//剩余血量
	int _leftHp;	
	//角色id
	int _charId;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//剩余血量
		SerializeUtils.WriteInt(stream, _leftHp);
		//角色id
		SerializeUtils.WriteInt(stream, _charId);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//剩余血量
		_leftHp = SerializeUtils.ReadInt(stream);
		//角色id
		_charId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 剩余血量
	 */
	public int LeftHp
	{
		set { _leftHp = value; }
	    get { return _leftHp; }
	}
	
	/**
	 * 角色id
	 */
	public int CharId
	{
		set { _charId = value; }
	    get { return _charId; }
	}
	
}