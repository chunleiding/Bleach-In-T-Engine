using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 十次一键特训 message
 */
public class ReqTenTimesSpecialTrainingMessage : Message
{
    //角色Id
    int _characterId;
    //特训buff
    int _buffId;

    /**
     * 序列化
     */
    public override void Serialize(Stream stream)
    {
        //角色Id
        SerializeUtils.WriteInt(stream, _characterId);
        //特训buff
        SerializeUtils.WriteInt(stream, _buffId);
    }

    /**
     * 反序列化
     */
    public override void Deserialize(Stream stream)
    {
        //角色Id
        _characterId = SerializeUtils.ReadInt(stream);
        //特训buff
        _buffId = SerializeUtils.ReadInt(stream);
    }

    /**
     * 角色Id
     */
    public int CharacterId
    {
        set { _characterId = value; }
        get { return _characterId; }
    }

    /**
     * 特训buff
     */
    public int BuffId
    {
        set { _buffId = value; }
        get { return _buffId; }
    }


    public override int GetId()
    {
        return 310206;
    }
}