namespace X3d.Core
{
    using System.Xml.Serialization;

    [XmlType(TypeName = "x3dVersion")]
    public enum X3DVersion
    {
        [XmlEnum(Name = "3.0")]
        X3D_3_0,

        [XmlEnum(Name = "3.1")]
        X3D_3_1,

        [XmlEnum(Name = "3.2")]
        X3D_3_2
    }
}
