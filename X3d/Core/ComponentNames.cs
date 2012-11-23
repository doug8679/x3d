namespace X3d.Core
{
    using System.Xml.Serialization;

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
