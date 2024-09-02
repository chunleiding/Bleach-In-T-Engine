using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading;
using UnityEngine;


public class TcpConnect
{
    const int TCP_CONNECT_TIMEOUT = 5 * 1000;

    // Event
    public event Action<Stream> ReceiveMsgEvent;

    Socket _socket;
    bool _noDelay = false;
    //当前网络状态
    int _curNetState = (int)NetState.Disconnected;

    //buf的大小
    byte[] _tcpHeadBuffer = new byte[4];
    byte[] _receiveBuffer = new byte[NetDefine.MAX_REVEIVE_BUFFER_LENGTH];
    BufferInfo _bufferInfo = new BufferInfo();
    MemoryStream _receiveStream;
    MemoryStream _uncompressedStream;

    byte[] _sendBuffer = new byte[NetDefine.MAX_SEND_BUFFER_LENGTH];
    MemoryStream _sendStream;
    byte[] _encryptionKey = new byte[1] { 0 }; 

    int _sendMsgCount = 0;
    int _receivedMsgCount = 0;


    /// <summary>
    /// Enable or disable the Nagle's buffering algorithm (aka NO_DELAY flag).
    /// Enabling this flag will improve latency at the cost of increased bandwidth.
    /// http://en.wikipedia.org/wiki/Nagle's_algorithm
    /// </summary>
    public bool NoDelay
    {
        get
        {
            return _noDelay;
        }
        set
        {
            if (_noDelay != value)
            {
                _noDelay = value;
#if !UNITY_WINRT
                _socket.SetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.NoDelay, _noDelay);
#endif
            }
        }
    }

    public int ReceivedMessageCount
    {
        get { return _receivedMsgCount; }
    }

    //属性
    public NetState CurNetState
    {
        get { return (NetState)_curNetState; }
        private set
        {
            Interlocked.Exchange(ref _curNetState, (int)value);
            Debug.Log("TcpConnect.CurNetState: " + (NetState)_curNetState);
        }
    }

    public bool IsConnected
    {
        get
        {
            return _socket.Connected;
        }
    }

    public byte[] EncryptionKey
    {
        set { _encryptionKey = value; }
    }

    public TcpConnect()
    {
        _sendStream = new MemoryStream(_sendBuffer);
        _receiveStream = new MemoryStream(_receiveBuffer);
        _uncompressedStream = new MemoryStream();
    }


    void NetDrop(string error = "")
    {
        CurNetState = NetState.Droped;
        Debug.LogWarning(string.Format("Network dropped, error: {0}", error));
    }

    public void TcpKeepAliveTimeout()
    {
        NetDrop("KeepAlive Test timeout!");
    }

    public void StartConnect(string _serverDomainName, int _serverPort)
    {
        if (CurNetState == NetState.Connecting || CurNetState == NetState.Connected)
        {
            Debug.LogWarning("Tcp is already connected");
            return;
        }

        CurNetState = NetState.Connecting;

        _sendMsgCount = 0;
        _receivedMsgCount = 0;

        try
        {
            IPAddress[] address = Dns.GetHostAddresses(_serverDomainName);
            if (address[0].AddressFamily == AddressFamily.InterNetworkV6)
                _socket = new Socket(AddressFamily.InterNetworkV6, SocketType.Stream, ProtocolType.Tcp);
            else
                _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            NoDelay = true;

            var ar = _socket.BeginConnect(address[0], _serverPort, new AsyncCallback(OnConnect), _socket);

            ThreadPool.RegisterWaitForSingleObject(ar.AsyncWaitHandle, new WaitOrTimerCallback(BeginConnentTimeOut), _socket, TCP_CONNECT_TIMEOUT, true);
            //Debug.Log("连接服务器 " + m_ServerIpAdd + "端口" + m_nServerPort);
        }
        catch (System.Exception ex)
        {
            NetDrop(ex.Message);
        }
    }

    void BeginConnentTimeOut(object state, bool isTimedOut)
    {
        if (isTimedOut)
        {
            // TODO:
            NetDrop("Tcp connect timeout!");
        }
    }

    public void CloseConnect()
    {
        try
        {
            if (_socket != null
                && CurNetState != NetState.Disconnected)
            {
                CurNetState = NetState.Disconnected;

                if (_socket.Connected) _socket.Shutdown(SocketShutdown.Both);
                _socket.Close();
                _socket = null;
            }
        }
        catch (System.Exception ex)
        {
            NetDrop(ex.Message);
        }
    }

    private void OnConnect(IAsyncResult result)
    {
        Socket sock = (Socket)result.AsyncState;

        // Windows handles async sockets differently than other platforms, it seems.
        // If a socket is closed, OnConnect() is never called on Windows.
        // On the mac it does get called, however, and if the socket is used here
        // then a null exception gets thrown because the socket is not usable by this point.
        if (sock == null) return;

        try
        {
            _socket.EndConnect(result);

            CurNetState = NetState.Connected;
            //Debug.Log(string.Format("Tcp client connected, {0}, {1}", _serverIpAdd.ToString(), _serverPort));

            ReceiveHead();
        }
        catch (System.Exception ex)
        {
            NetDrop(ex.Message);
        }
    }

    private void ReceiveHead()
    {
        if (CurNetState != NetState.Connected)
            return;

        try
        {
            _bufferInfo.bufferSize = _tcpHeadBuffer.Length;
            _bufferInfo.readSize = 0;

            _socket.BeginReceive(_tcpHeadBuffer, 0, _bufferInfo.bufferSize, SocketFlags.None,
                                new AsyncCallback(OnReceiveHead), _socket);

            //if (Global.LOG) Debug.Log(string.Format("Begin receive message head: {0}:{1}.", DateTime.Now.Second, DateTime.Now.Millisecond));
        }
        catch (System.Exception)
        {
            NetDrop("Receive message head failed");
        }
    }

    private void OnReceiveHead(IAsyncResult result)
    {
        if (CurNetState != NetState.Connected)
            return;

        try
        {
            var readSize = _socket.EndReceive(result);
            _bufferInfo.readSize += readSize;

            //if (Global.LOG) Debug.Log(string.Format("End receive message head: read size: {0}, toal read size {1}, buffer size {2}, {3}:{4}.",
            //    readSize, _bufferInfo.readSize, _bufferInfo.bufferSize, DateTime.Now.Second, DateTime.Now.Millisecond));
        }
        catch (System.Exception e)
        {
            NetDrop(e.Message);
            return;
        }

        if (_bufferInfo.readSize < _bufferInfo.bufferSize)
        {
            try
            {
                _socket.BeginReceive(_receiveBuffer, _bufferInfo.readSize, _bufferInfo.bufferSize - _bufferInfo.readSize,
                    SocketFlags.None, new AsyncCallback(OnReceiveHead), _socket);

                //if (Global.LOG) Debug.Log(string.Format("Begin receive message head: {0}:{1}.", DateTime.Now.Second, DateTime.Now.Millisecond));
            }
            catch (System.Exception)
            {
                NetDrop("Receive message head failed");
            }
        }
        else
        {
            int msgSize = SerializeUtils.ReadInt(_tcpHeadBuffer);

            //     ff  			ffffff
            // 是否压缩(0,1)     长度
            int flag = ((msgSize >> 24) & 0xff);
            msgSize = (msgSize & 0x00ffffff);

            _bufferInfo.bufferSize = msgSize;
            _bufferInfo.readSize = 0;
            _bufferInfo.specialFlag = flag;

            if (msgSize > 0 && msgSize < NetDefine.MAX_REVEIVE_BUFFER_LENGTH)
            {
                try
                {
                    _socket.BeginReceive(_receiveBuffer, 0, _bufferInfo.bufferSize,
                        SocketFlags.None, new AsyncCallback(OnReceive), _socket);

                    //if (Global.LOG) Debug.Log(string.Format("Begin receive message: {0}:{1}.", DateTime.Now.Second, DateTime.Now.Millisecond));
                }
                catch (System.Exception)
                {
                    NetDrop("Receive message failed");
                }
            }
            else
            {
                NetDrop(string.Format("Invalid Message size: {0}!", msgSize));
            }
        }
    }

    private void OnReceive(IAsyncResult result)
    {
        if (CurNetState != NetState.Connected)
            return;

        try
        {
            var readSize = _socket.EndReceive(result);
            _bufferInfo.readSize += readSize;

            //if (Global.LOG) Debug.Log(string.Format("End receive message: read size: {0}, toal read size {1}, buffer size {2}, {3}:{4}.",
            //    readSize, _bufferInfo.readSize, _bufferInfo.bufferSize, DateTime.Now.Second, DateTime.Now.Millisecond));
        }
        catch (System.Exception e)
        {
            NetDrop(e.Message);
            return;
        }

        if (_bufferInfo.readSize < _bufferInfo.bufferSize)
        {
            try
            {
                _socket.BeginReceive(_receiveBuffer, _bufferInfo.readSize, _bufferInfo.bufferSize - _bufferInfo.readSize,
                    SocketFlags.None, new AsyncCallback(OnReceive), _socket);

                //if (Global.LOG) Debug.Log(string.Format("Begin receive message: {0}:{1}.", DateTime.Now.Second, DateTime.Now.Millisecond));
            }
            catch (System.Exception)
            {
                NetDrop("Receive message failed");
            }
        }
        else
        {
            _receiveStream.Position = 0;

            var msgStream = _receiveStream;

			if ((_bufferInfo.specialFlag & (int)MessageSpecialFlag.Encrypted) != 0) // 解密
			{
				EncryptDecrypt(_receiveBuffer, _bufferInfo.bufferSize, sizeof(int), _encryptionKey);
			}

			if ((_bufferInfo.specialFlag & (int)MessageSpecialFlag.Compressed) != 0) // 解压
            {
                DotNetZlib.UnCompress(_receiveBuffer, _bufferInfo.bufferSize, _uncompressedStream);
                msgStream = _uncompressedStream;
            }

            // TODO:
            if (ReceiveMsgEvent != null)
            {
                ReceiveMsgEvent(msgStream);
            }

            Interlocked.Increment(ref _receivedMsgCount);

            ReceiveHead();
        }
    }

    public void SendMessage(Message message, bool enableEncryption)
    {
        if (CurNetState != NetState.Connected)
        {
            Debug.LogWarning(string.Format("Send message {0} failed, tcp not connected!", message.GetType()));
            return;
        }

        // TODO:
        _sendStream.SetLength(0);
        _sendStream.Position = 0;

        SerializeUtils.WriteInt(_sendStream, 0);
        SerializeUtils.WriteInt(_sendStream, 0);
        SerializeUtils.WriteInt(_sendStream, 0);
        SerializeUtils.WriteInt(_sendStream, 0); // 无用字段
        message.Serialize(_sendStream);

        int msgLength = (int)_sendStream.Length - sizeof(int);
        // verify code.
        int magicValue = ((~_sendMsgCount & (msgLength)) | (_sendMsgCount & ~(msgLength)));
        magicValue = ((~magicValue & (1 << 9)) | (magicValue & ~(1 << 9)));

        int msgID = message.GetId();

        // ff  			    ffffff
        // 特殊标志位        长度
        var flag = (enableEncryption ? (int)MessageSpecialFlag.Encrypted : (int)MessageSpecialFlag.None) << 24;
        msgLength |= flag;

        _sendStream.Position = 0;
        SerializeUtils.WriteInt(_sendStream, msgLength);
        SerializeUtils.WriteInt(_sendStream, magicValue);
        SerializeUtils.WriteInt(_sendStream, msgID);

        var data = _sendStream.ToArray();
        var dataLength = data.Length;
        if (dataLength >= NetDefine.MAX_SEND_BUFFER_LENGTH)
        {
            Debug.LogWarning("Message size exceed the MAX_SEND_BUFFER_LENGTH!");
            return;
        }

        if (enableEncryption)
        {
			EncryptDecrypt(data, dataLength, 4 * sizeof(int), _encryptionKey);
        }

        SendMessage(data, dataLength);

        _sendMsgCount++;
    }

	private void EncryptDecrypt(byte[] data, int dataLength, int startPos, byte[] key)
	{
		var keyLength = key.Length;
		var keyPos = 0;
		for (var i = startPos; i < dataLength; ++i)
		{
			data[i] = (byte)(data[i] ^ key[keyPos++ % keyLength]);
		}
	}

    private void SendMessage(byte[] data, int length)
    {
        try
        {
            _socket.BeginSend(data, 0, length, SocketFlags.None, OnSend, null);
        }
        catch (System.Exception e)
        {
            NetDrop(e.Message);
        }
    }

    private void OnSend(IAsyncResult result)
    {
        if (CurNetState != NetState.Connected)
            return;

        var bytes = 0;
        try
        {
            bytes = _socket.EndSend(result);
            if (bytes == 0)
            {
                NetDrop("Failed to send msg.");
            }

            //if (Global.LOG) Debug.Log("Finish send msg.");
        }
        catch (System.Exception e)
        {
            NetDrop(e.Message);
        }
    }
}
