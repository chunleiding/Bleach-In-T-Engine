using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * IOS???? message
 */
public class ReqRechargeIOSAppMessage : Message
{
    //IOS??????
    string _iOSAppReceipt;
    //
    int _iOSAppProductId;

    /**
     * 搴忓垪鍖?
     */
    public override void Serialize(Stream stream)
    {
        //IOS??????
        SerializeUtils.WriteString(stream, _iOSAppReceipt);
        //
        SerializeUtils.WriteInt(stream, _iOSAppProductId);
    }

    /**
     * 鍙嶅簭鍒楀寲
     */
    public override void Deserialize(Stream stream)
    {
        //IOS??????
        _iOSAppReceipt = SerializeUtils.ReadString(stream);
        //
        _iOSAppProductId = SerializeUtils.ReadInt(stream);
    }

    /**
     * IOS??????
     */
    public string IOSAppReceipt
    {
        set { _iOSAppReceipt = value; }
        get { return _iOSAppReceipt; }
    }

    /**
     * 
     */
    public int IOSAppProductId
    {
        set { _iOSAppProductId = value; }
        get { return _iOSAppProductId; }
    }


    public override int GetId()
    {
        return 312207;
    }
}