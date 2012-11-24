namespace X3d.Core
{
    using System.Xml.Serialization;

    [XmlType(TypeName = "metaDirectionValues")]
    public enum MetaDirectionValues
    {
        [XmlEnum(Name = "rtl")]
        RightToLeft,

        [XmlEnum(Name = "ltr")]
        LeftToRight
    }
}
