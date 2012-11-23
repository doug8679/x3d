namespace X3d.Core
{
    using System;
    using System.Collections.Generic;
    using System.Xml;
    using System.Xml.Serialization;

    [XmlType(TypeName = "SceneGraphStructureNodeType")]
    public class SceneGraphStructureNodeType
    {
    }

    [XmlType(TypeName = "x3dVersion")]
    public enum X3DVersion
    {
        [XmlEnum(Name = "3.0")]
        X3D_3_0,

        [XmlEnum(Name = "3.1")]
        X3D_3_1,

        [XmlEnum(Name = "3.2")]
        X3D_3_2
    }

    [XmlType(TypeName = "profileNames")]
    public enum ProfileNames
    {
        [XmlEnum(Name = "Core")]
        Core,

        [XmlEnum(Name = "Interchange")]
        Interchange,

        [XmlEnum(Name = "CADInterchange")]
        CADInterchange,

        [XmlEnum(Name = "Interactive")]
        Interactive,

        [XmlEnum(Name = "Immersive")]
        Immersive,

        [XmlEnum(Name = "MPEG4Interactive")]
        MPEG4Interactive,

        [XmlEnum(Name = "Full")]
        Full
    }

    [XmlRoot(ElementName = "X3D", IsNullable = false)]
    public class X3D : SceneGraphStructureNodeType
    {
        [XmlElement(IsNullable = true, Order = 0)]
        public Head Head { get; set; }

        [XmlElement(IsNullable = false, Order = 1)]
        public Scene Scene { get; set; }

        [XmlAttribute]
        public X3DVersion Version { get; set; }

        [XmlAttribute]
        public ProfileNames Profile { get; set; }
    }

    [XmlType(TypeName = "head")]
    public class Head : SceneGraphStructureNodeType
    {
        [XmlElement(IsNullable = true, Order = 0)]
        public List<Component> Components { get; set; }

        [XmlElement(IsNullable = true, Order = 1)]
        public List<Meta> Meta { get; set; }
    }

    [XmlType(TypeName = "Scene")]
    public class Scene : SceneGraphStructureNodeType
    {
        // TODO : Implement this
    }

    [XmlType(TypeName = "component")]
    public class Component
    {
        [XmlAttribute(AttributeName = "name")]
        public ComponentNames Name { get; set; }

        private SFInt32 level;

        [XmlAttribute(AttributeName = "level")]
        public SFInt32 Level
        {
            get
            {
                return this.level;
            }
            
            set
            {
                if (value < 1 || value > 5)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Level can be between 1 and 5. Value = {0}", value));
                }

                this.level = value;
            }
        }
    }

    [XmlType(TypeName = "meta")]
    public class Meta
    {
        [XmlAttribute(AttributeName = "name")]
        public SFString Name { get; set; }

        [XmlAttribute(AttributeName = "content")]
        public SFString Content { get; set; }

        [XmlAttribute(AttributeName = "dir")]
        public MetaDirectionValues Direction { get; set; }

        [XmlAttribute(AttributeName = "http-equiv")]
        public SFString HttpEquivalant { get; set; }

        [XmlAttribute(AttributeName = "lang")]
        public SFString Language { get; set; }

        [XmlAttribute(AttributeName = "scheme")]
        public SFString Scheme { get; set; }
    }

    [XmlType(TypeName = "metaDirectionValues")]
    public enum MetaDirectionValues
    {
        [XmlEnum(Name = "rtl")]
        RightToLeft,

        [XmlEnum(Name = "ltr")]
        LeftToRight
    }

    [XmlType(TypeName = "componentNames")]
    public enum ComponentNames
    {
        [XmlEnum(Name = "Core")]
        Core,

        [XmlEnum(Name = "CADGeometry")]
        CADGeometry,

        [XmlEnum(Name = "CubeMapTexturing")]
        CubeMapTexturing,

        [XmlEnum(Name = "DIS")]
        DIS,

        [XmlEnum(Name = "EnvironmentalEffects")]
        EnvironmentalEffects,

        [XmlEnum(Name = "EnvironmentalSensor")]
        EnvironmentalSensor,

        [XmlEnum(Name = "EventUtilities")]
        EventUtilities,

        [XmlEnum(Name = "Followers")]
        Followers,

        [XmlEnum(Name = "Geometry2D")]
        Geometry2D,

        [XmlEnum(Name = "Geometry3D")]
        Geometry3D,

        [XmlEnum(Name = "Geospatial")]
        Geospatial,

        [XmlEnum(Name = "Grouping")]
        Grouping,

        [XmlEnum(Name = "H-Anim")]
        H_Anim,

        [XmlEnum(Name = "Interpolation")]
        Interpolation,

        [XmlEnum(Name = "KeyDeviceSensor")]
        KeyDeviceSensor,

        [XmlEnum(Name = "Layering")]
        Layering,

        [XmlEnum(Name = "Layout")]
        Layout,

        [XmlEnum(Name = "Lighting")]
        Lighting,

        [XmlEnum(Name = "Navigation")]
        Navigation,

        [XmlEnum(Name = "Networking")]
        Networking,

        [XmlEnum(Name = "NURBS")]
        NURBS,

        [XmlEnum(Name = "ParticleSystems")]
        ParticleSystems,

        [XmlEnum(Name = "PickingSensor")]
        PickingSensor,

        [XmlEnum(Name = "PointingDeviceSensor")]
        PointingDeviceSensor,

        [XmlEnum(Name = "Rendering")]
        Rendering,

        [XmlEnum(Name = "RigidBodyPhysics")]
        RigidBodyPhysics,

        [XmlEnum(Name = "Scripting")]
        Scripting,

        [XmlEnum(Name = "Shaders")]
        Shaders,

        [XmlEnum(Name = "Shape")]
        Shape,

        [XmlEnum(Name = "Sound")]
        Sound,

        [XmlEnum(Name = "Text")]
        Text,

        [XmlEnum(Name = "Texturing")]
        Texturing,

        [XmlEnum(Name = "Texturing3D")]
        Texturing3D,

        [XmlEnum(Name = "Time")]
        Time
    }
}