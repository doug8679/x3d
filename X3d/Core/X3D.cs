﻿namespace X3d.Core
{
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "X3D", IsNullable = false)]
    public class X3D : SceneGraphStructureNodeType
    {
        [XmlElement(IsNullable = true, Order = 0)]
        public Head Head { get; set; }

        [XmlElement(IsNullable = false, Order = 1)]
        public Scene Scene { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public X3DVersion Version { get; set; }

        [XmlAttribute(AttributeName = "profile")]
        public ProfileNames Profile { get; set; }
    }
}