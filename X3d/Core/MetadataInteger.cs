namespace X3d.Core
{
    using System.Xml;

    /// <summary>
    /// The metadata provided by this node is contained in the integers of 
    /// the value field.
    /// </summary>
    public class MetadataInteger : X3DMetadataObject<MFInt32>, ChildContentModelCore
    {
        public const string ElementName = "MetadataInteger";

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
