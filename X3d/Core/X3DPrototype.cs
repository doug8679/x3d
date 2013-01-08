namespace X3d.Core
{
    using System;
    using System.Xml;

    public abstract class X3DPrototype : SceneGraphStructureNodeType
    {
        public const string NameAttributeName = "name";

        protected X3DPrototype()
        {
            this.name = string.Empty;
        }

        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == null)
                {
                    throw new FormatException();
                }

                this.name = value;
            }
        }

        protected virtual void WriteAttributes(XmlWriter writer)
        {
            writer.WriteAttributeString(NameAttributeName, this.Name);
        }

        protected virtual void WriteChildElements(XmlWriter writer)
        {
        }

        public virtual void Write(XmlWriter writer)
        {
            this.WriteAttributes(writer);
            this.WriteChildElements(writer);
        }
    }
}
