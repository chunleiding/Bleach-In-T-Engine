using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 节日称号信息
 */
public class SpecialTitleInfo : IMessageSerialize
{
    //称号id
    int _titleId;
    //称号价格
    int _price;
    //货币类型 1：RMB；2：魂玉
    int _priceType;
    //充值商品表里的商品id
    int _commodityId;

    /**
     * 序列化
     */
    public void Serialize(Stream stream)
    {
        //称号id
        SerializeUtils.WriteInt(stream, _titleId);
        //称号价格
        SerializeUtils.WriteInt(stream, _price);
        //货币类型 1：RMB；2：魂玉
        SerializeUtils.WriteInt(stream, _priceType);
        //充值商品表里的商品id
        SerializeUtils.WriteInt(stream, _commodityId);
    }

    /**
     * 反序列化
     */
    public void Deserialize(Stream stream)
    {
        //称号id
        _titleId = SerializeUtils.ReadInt(stream);
        //称号价格
        _price = SerializeUtils.ReadInt(stream);
        //货币类型 1：RMB；2：魂玉
        _priceType = SerializeUtils.ReadInt(stream);
        //充值商品表里的商品id
        _commodityId = SerializeUtils.ReadInt(stream);
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
     * 称号价格
     */
    public int Price
    {
        set { _price = value; }
        get { return _price; }
    }

    /**
     * 货币类型 1：RMB；2：魂玉
     */
    public int PriceType
    {
        set { _priceType = value; }
        get { return _priceType; }
    }

    /**
     * 充值商品表里的商品id
     */
    public int CommodityId
    {
        set { _commodityId = value; }
        get { return _commodityId; }
    }

}