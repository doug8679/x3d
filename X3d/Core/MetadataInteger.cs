namespace X3d.Core
{
    using System.Xml.Serialization;

    /// <summary>
    /// The metadata provided by this node is contained in the integers of 
    /// the value field.
    /// </summary>
    public class MetadataInteger 
        : X3DMetadataObject<MFInt32>, ChildContentModelCore
    {
        [XmlAttribute(AttributeName = ValueAttributeName)]
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
