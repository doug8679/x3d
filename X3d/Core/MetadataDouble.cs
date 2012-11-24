namespace X3d.Core
{
    using System.Xml.Serialization;

    /// <summary>
    /// The metadata provided by this node is contained in the double-precision 
    /// floating point numbers of the value field.
    /// </summary>
    [XmlType(TypeName = "MetadataDouble")]
    public class MetadataDouble : X3DMetadataObject<MFDouble>
    {
    }
}
