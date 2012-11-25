namespace X3d.Core
{
    using System.Xml;

    /// <summary>
    /// The metadata provided by this node is contained in the strings of 
    /// the value field.
    /// </summary>
    public class MetadataString : X3DMetadataObject<MFString>, ChildContentModelCore
    {
        public const string ElementName = "MetadataString";

        protected override void WriteAttributes(XmlWriter writer)
        {
            base.WriteAttributes(writer);

            if (this.Value.Count > 0)
            {
                writer.WriteAttributeString(ValueAttributeName, this.Value.ToString());
            }
        }

        public override void Write(XmlWriter writer)
        {
            writer.WriteStartElement(ElementName);

            base.Write(writer);

            writer.WriteEndElement();
        }
    }
}
