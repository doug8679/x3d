namespace X3d.Core
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public class Head : SceneGraphStructureNodeType
    {
        public const string ElementName = "head";

        public Head()
        {
            this.Components = new List<Component>();
            this.Meta = new List<Meta>();
        }

        private List<Component> components;
        public List<Component> Components 
        {
            get
            {
                return this.components;
            }

            set
            {
                if (value == null)
                {
                    throw new NullReferenceException();
                }

                this.components = value;
            }
        }

        private List<Meta> meta;
        public List<Meta> Meta
        {
            get
            {
                return this.meta;
            }

            set
            {
                if (value == null)
                {
                    throw new NullReferenceException();
                }

                this.meta = value;
            }
        }

        public void Write(XmlWriter writer)
        {
            writer.WriteStartElement(ElementName);

            foreach (var item in components)
            {
                item.Write(writer);
            }

            foreach (var item in meta)
            {
                item.Write(writer);
            }

            writer.WriteEndElement();
        }
    }
}
