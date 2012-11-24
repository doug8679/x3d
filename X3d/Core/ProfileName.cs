namespace X3d.Core
{
    using System.Xml.Serialization;

    [XmlType(TypeName = "profileNames")]
    public enum ProfileNames
    {
        [XmlEnum(Name = "Core")]
        Core,

        [XmlEnum(Name = "Interchange")]
        Interchange,

        [XmlEnum(Name = "CADInterchange")]
        CADInterchange,

        [XmlEnum(Name = "Interactive")]
        Interactive,

        [XmlEnum(Name = "Immersive")]
        Immersive,

        [XmlEnum(Name = "MPEG4Interactive")]
        MPEG4Interactive,

        [XmlEnum(Name = "Full")]
        Full
    }
}
