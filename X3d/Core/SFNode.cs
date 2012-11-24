namespace X3d.Core
{
    using System.Xml.Serialization;

    /// <summary>
    /// The SFNode field specifies an X3D node. The default value of
    /// an uninitialized. SFNode field is NULL.
    /// Although X3D specification describes this field type as a
    /// kind of referencing type, it is a SFString sub class because
    /// when this is used in the XML document, a value of a SFNode
    /// attribute in a X3D node is a reference key string value.
    /// This field type itself does not need to have a reference
    /// look up feature which makes this type as a sub type of
    /// SFString field.
    /// </summary>
    [XmlType(TypeName = "SFNode")]
    public class SFNode : SFString
    {
        public const string Null = "NULL";

        #region Constructors

        public SFNode()
            : base(Null)
        {
        }

        public SFNode(string nodeName)
            : base(nodeName)
        {
        }

        public SFNode(SFNode obj)
            : base((string)obj)
        {
        }

        #endregion Constructors
    }
}