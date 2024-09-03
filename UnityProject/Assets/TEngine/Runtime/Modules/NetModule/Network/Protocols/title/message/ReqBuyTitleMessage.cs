using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求购买称号 message
 */
public class ReqBuyTitleMessage : Message
{
    //称号id
    int _titleId;
    //价格类型 1：RMB ；2：魂玉
    int _priceType;

    /**
     * 序列化
     */
    public override void Serialize(Stream stream)
    {
        //称号id
        SerializeUtils.WriteInt(stream, _titleId);
        //价格类型 1：RMB ；2：魂玉
        SerializeUtils.WriteInt(stream, _priceType);
    }

    /**
     * 反序列化
     */
    public override void Deserialize(Stream stream)
    {
        //称号id
        _titleId = SerializeUtils.ReadInt(stream);
        //价格类型 1：RMB ；2：魂玉
        _priceType = SerializeUtils.ReadInt(stream);
    }

    /**
     * 称号id
     */
    public int TitleId
    {
        set { _titleId = value; }
        get { return _titleId; }
    }

    /**
     * 价格类型 1：RMB ；2：魂玉
     */
    public int PriceType
    {
        set { _priceType = value; }
        get { return _priceType; }
    }


    public override int GetId()
    {
        return 827104;
    }
}