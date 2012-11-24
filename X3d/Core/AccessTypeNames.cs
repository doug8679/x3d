namespace X3d.Core
{
    using System.Xml.Serialization;

    [XmlType(TypeName = "accessTypeNames")]
    public enum AccessTypeNames
    {
        [XmlEnum(Name = "InitializeOnly")]
        InitializeOnly,

        [XmlEnum(Name = "InputOnly")]
        InputOnly,

        [XmlEnum(Name = "OutputOnly")]
        OutputOnly,

        [XmlEnum(Name = "InputOutput")]
        InputOutput
    }
}
