using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 邮件信息
 */
public class MailInfo : IMessageSerialize 
{
	//邮件id
	long _mailId;	
	//邮件发送日期
	long _sendTime;	
	//邮件有效的毫秒数
	long _validTime;	
	//邮件删除方式，0-读完不删除，1-读完删除
	int _deleteType;	
	//发送者名字
	string _senderName;	
	//邮件标题
	string _subject;	
	//邮件内容
	string _content;	
	//邮件参数
	List<string> _mailParams = new List<string>();
	//邮件附件
	List<ItemInfo> _attachInfo = new List<ItemInfo>();
	//邮件状态，0：未读 1：已读 2：已取
	int _status;	
	//是否需要解析（1：需要，0：不需要）
	int _needParse;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//邮件id
		SerializeUtils.WriteLong(stream, _mailId);
		//邮件发送日期
		SerializeUtils.WriteLong(stream, _sendTime);
		//邮件有效的毫秒数
		SerializeUtils.WriteLong(stream, _validTime);
		//邮件删除方式，0-读完不删除，1-读完删除
		SerializeUtils.WriteInt(stream, _deleteType);
		//发送者名字
		SerializeUtils.WriteString(stream, _senderName);
		//邮件标题
		SerializeUtils.WriteString(stream, _subject);
		//邮件内容
		SerializeUtils.WriteString(stream, _content);
		//邮件参数
		SerializeUtils.WriteShort(stream, (short)_mailParams.Count);

		foreach (var element in _mailParams)  
		{
			SerializeUtils.WriteString(stream, element);
		}
		//邮件附件
		SerializeUtils.WriteShort(stream, (short)_attachInfo.Count);

		foreach (var element in _attachInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//邮件状态，0：未读 1：已读 2：已取
		SerializeUtils.WriteInt(stream, _status);
		//是否需要解析（1：需要，0：不需要）
		SerializeUtils.WriteInt(stream, _needParse);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//邮件id
		_mailId = SerializeUtils.ReadLong(stream);
		//邮件发送日期
		_sendTime = SerializeUtils.ReadLong(stream);
		//邮件有效的毫秒数
		_validTime = SerializeUtils.ReadLong(stream);
		//邮件删除方式，0-读完不删除，1-读完删除
		_deleteType = SerializeUtils.ReadInt(stream);
		//发送者名字
		_senderName = SerializeUtils.ReadString(stream);
		//邮件标题
		_subject = SerializeUtils.ReadString(stream);
		//邮件内容
		_content = SerializeUtils.ReadString(stream);
		//邮件参数
		int _mailParams_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _mailParams_length; ++i) 
		{
			_mailParams.Add(SerializeUtils.ReadString(stream));
		}
		//邮件附件
		int _attachInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _attachInfo_length; ++i) 
		{
			_attachInfo.Add(SerializeUtils.ReadBean<ItemInfo>(stream));
		}
		//邮件状态，0：未读 1：已读 2：已取
		_status = SerializeUtils.ReadInt(stream);
		//是否需要解析（1：需要，0：不需要）
		_needParse = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 邮件id
	 */
	public long MailId
	{
		set { _mailId = value; }
	    get { return _mailId; }
	}
	
	/**
	 * 邮件发送日期
	 */
	public long SendTime
	{
		set { _sendTime = value; }
	    get { return _sendTime; }
	}
	
	/**
	 * 邮件有效的毫秒数
	 */
	public long ValidTime
	{
		set { _validTime = value; }
	    get { return _validTime; }
	}
	
	/**
	 * 邮件删除方式，0-读完不删除，1-读完删除
	 */
	public int DeleteType
	{
		set { _deleteType = value; }
	    get { return _deleteType; }
	}
	
	/**
	 * 发送者名字
	 */
	public string SenderName
	{
		set { _senderName = value; }
	    get { return _senderName; }
	}
	
	/**
	 * 邮件标题
	 */
	public string Subject
	{
		set { _subject = value; }
	    get { return _subject; }
	}
	
	/**
	 * 邮件内容
	 */
	public string Content
	{
		set { _content = value; }
	    get { return _content; }
	}
	
	/**
	 * get 邮件参数
	 * @return 
	 */
	public List<string> GetMailParams()
	{
		return _mailParams;
	}
	
	/**
	 * set 邮件参数
	 */
	public void SetMailParams(List<string> mailParams)
	{
		_mailParams = mailParams;
	}
	
	/**
	 * get 邮件附件
	 * @return 
	 */
	public List<ItemInfo> GetAttachInfo()
	{
		return _attachInfo;
	}
	
	/**
	 * set 邮件附件
	 */
	public void SetAttachInfo(List<ItemInfo> attachInfo)
	{
		_attachInfo = attachInfo;
	}
	
	/**
	 * 邮件状态，0：未读 1：已读 2：已取
	 */
	public int Status
	{
		set { _status = value; }
	    get { return _status; }
	}
	
	/**
	 * 是否需要解析（1：需要，0：不需要）
	 */
	public int NeedParse
	{
		set { _needParse = value; }
	    get { return _needParse; }
	}
	
}