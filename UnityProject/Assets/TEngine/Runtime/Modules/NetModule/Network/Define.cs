using System;
using System.Text;

public enum NetState
{
    Disconnected = 0,   // Î´Á¬½Ó
    Connecting,
    Connected,
    Droped
}

public enum MessageSpecialFlag
{
    None = 0,
    Compressed = 1,
    Encrypted = 2
}

public struct BufferInfo
{
    public int bufferSize;
    public int readSize;
	public int specialFlag;
}

public class NetDefine
{
    public static int MAX_REVEIVE_BUFFER_LENGTH = 64 * 1024;    // 64k
    public static int MAX_SEND_BUFFER_LENGTH = 10240;           // 10K
}
