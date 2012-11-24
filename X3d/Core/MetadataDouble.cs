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
        [XmlAttribute(AttributeName = "value")]
        public string ValueString
        {
            get
            {
                if (this.Value.Count > 0)
                {
                    return this.Value.ToString();
                }
                else
                {
                    return null;
                }
            }

            set
            {
                this.Value.FromString(value);
            }
        }

        public override void WriteXmlAttributes(System.Xml.XmlWriter writer)
        {
            base.WriteXmlAttributes(writer);

            if (this.Value != null && this.Value.Count > 0)
            {
                writer.WriteAttributeString(ValueAttributeName, ValueString);
            }
        }
    }
}
