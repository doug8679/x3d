namespace X3d.Core
{
    using System.Xml;

    /// <summary>
    /// This abstract node type is the base type for all nodes in the X3D system.
    /// </summary>
    public abstract class X3DNode
    {
        public const string ISElementName = "IS";

        public const string MetadataElementName = "metadata";

        public const string DEFAttributeName = "DEF";

        public const string USEAttributeName = "USE";

        public const string ContainerNameAttrubuteName = "containerField";

        protected X3DNode()
        {
            this.IS = null;
            this.Metadata = null;
            this.DEF = null;
            this.USE = null;
            this.ContainerField = null;
        }

        public IS IS { get; set; }

        public ChildContentModelCore Metadata { get; set; }

        public SFString DEF { get; set; }

        public SFString USE { get; set; }

        public SFString ContainerField { get; set; }

        protected virtual void WriteAttributes(XmlWriter writer)
        {
            if (this.DEF != null)
            {
                writer.WriteAttributeString(DEFAttributeName, this.DEF.ToString());
            }

            if (this.USE != null)
            {
                writer.WriteAttributeString(USEAttributeName, this.USE.ToString());
            }

            if (this.ContainerField != null)
            {
                writer.WriteAttributeString(ContainerNameAttrubuteName, this.ContainerField.ToString());
            }
        }

        protected virtual void WriteChildElements(XmlWriter writer)
        {
            if (this.IS != null)
            {
                this.IS.Write(writer);
            }

            if (this.Metadata != null)
            {
                ((X3DMetadataObject)this.Metadata).Write(writer);
            }
        }

        public virtual void Write(XmlWriter writer)
        {
            this.WriteAttributes(writer);
            this.WriteChildElements(writer);
        }
    }
}   
