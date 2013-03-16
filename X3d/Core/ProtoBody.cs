namespace X3d.Core
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public class ProtoBody : SceneGraphStructureNodeType
    {
        public const string ElementName = "ProtoBody";

        public ProtoBody()
        {
            this.ChildNodes = new List<SceneGraphFragmentWithPrototypeDeclarationsContentModel>();
        }

        private List<SceneGraphFragmentWithPrototypeDeclarationsContentModel> childNodes;
        public List<SceneGraphFragmentWithPrototypeDeclarationsContentModel> ChildNodes 
        {
            get
            {
                return this.childNodes;
            }

            set
            {
                if (value == null)
                {
                    throw new FormatException();
                }

                this.childNodes = value;
            }
        }

        public void Write(XmlWriter writer)
        {
            writer.WriteStartElement(ElementName);   

            foreach (var item in this.ChildNodes)
            {
                ((X3DNode)item).Write(writer);
            }

            writer.WriteEndElement();
        }
    }
}
