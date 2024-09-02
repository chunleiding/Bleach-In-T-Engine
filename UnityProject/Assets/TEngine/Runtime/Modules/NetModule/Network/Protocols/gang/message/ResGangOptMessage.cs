using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队操作返回 message
 */
public class ResGangOptMessage : Message 
{
	//操作
	byte _opt;	
	//返回值
	byte _ret;	
	//结果信息(json字符串)
	string _res;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//操作
		SerializeUtils.WriteByte(stream, _opt);
		//返回值
		SerializeUtils.WriteByte(stream, _ret);
		//结果信息(json字符串)
		SerializeUtils.WriteString(stream, _res);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//操作
		_opt = SerializeUtils.ReadByte(stream);
		//返回值
		_ret = SerializeUtils.ReadByte(stream);
		//结果信息(json字符串)
		_res = SerializeUtils.ReadString(stream);
	}
	
	/**
	 * 操作
	 */
	public byte Opt
	{
		set { _opt = value; }
	    get { return _opt; }
	}
	
	/**
	 * 返回值
	 */
	public byte Ret
	{
		set { _ret = value; }
	    get { return _ret; }
	}
	
	/**
	 * 结果信息(json字符串)
	 */
	public string Res
	{
		set { _res = value; }
	    get { return _res; }
	}
	
	
	public override int GetId() 
	{
		return 109106;
	}
}