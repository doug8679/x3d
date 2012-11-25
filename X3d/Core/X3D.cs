namespace X3d.Core
{
    using System;
    using System.Xml;

    public class X3D : SceneGraphStructureNodeType
    {
        public const string ElementName = "X3D";

        public const string VersionAttributeName = "version";

        public const string ProfileAttributeName = "profile";

        public X3D()
        {
            this.Head = null;
            this.Scene = new Scene();
            this.Version = X3DVersion.X3D_3_2;
            this.Profile = ProfileNames.Core;
        }

        public Head Head { get; set; }

        private Scene scene;
        public Scene Scene
        {
            get
            {
                return this.scene;
            }

            set
            {
                if (value == null)
                {
                    throw new NullReferenceException();
                }

                this.scene = value;
            }
        } 
        

        public X3DVersion Version { get; set; }

        public ProfileNames Profile { get; set; }

        public void Write(XmlWriter writer)
        {
            writer.WriteStartElement(ElementName);

            if (this.Head != null)
            {
                this.Head.Write(writer);
            }

            this.Scene.Write(writer);

            writer.WriteAttributeString(VersionAttributeName, 
                                        X3DVersionConverter.ToString(this.Version));

            writer.WriteAttributeString(ProfileAttributeName,
                                        ProfileNamesConverter.ToString(this.Profile));

            writer.WriteEndElement();
        }
    }
}
