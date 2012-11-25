namespace X3d.Core
{
    using System;

    public enum ComponentNames
    {
        Core,
        CADGeometry,
        CubeMapTexturing,
        DIS,
        EnvironmentalEffects,
        EnvironmentalSensor,
        EventUtilities,
        Followers,
        Geometry2D,
        Geometry3D,
        Geospatial,
        Grouping,
        H_Anim,
        Interpolation,
        KeyDeviceSensor,
        Layering,
        Layout,
        Lighting,
        Navigation,
        Networking,
        NURBS,
        ParticleSystems,
        PickingSensor,
        PointingDeviceSensor,
        Rendering,
        RigidBodyPhysics,
        Scripting,
        Shaders,
        Shape,
        Sound,
        Text,
        Texturing,
        Texturing3D,
        Time
    }

    public static class ComponentNamesConverter
    {
        public const string Core = "Core";
        public const string CADGeometry = "CADGeometry";
        public const string CubeMapTexturing = "CubeMapTexturing";
        public const string DIS = "DIS";
        public const string EnvironmentalEffects = "EnvironmentalEffects";
        public const string EnvironmentalSensor = "EnvironmentalSensor";
        public const string EventUtilities = "EventUtilities";
        public const string Followers = "Followers";
        public const string Geometry2D = "Geometry2D";
        public const string Geometry3D = "Geometry3D";
        public const string Geospatial = "Geospatial";
        public const string Grouping = "Grouping";
        public const string H_Anim = "H_Anim";
        public const string Interpolation = "Interpolation";
        public const string KeyDeviceSensor = "KeyDeviceSensor";
        public const string Layering = "Layering";
        public const string Layout = "Layout";
        public const string Lighting = "Lighting";
        public const string Navigation = "Navigation";
        public const string Networking = "Networking";
        public const string NURBS = "NURBS";
        public const string ParticleSystems = "ParticleSystems";
        public const string PickingSensor = "PickingSensor";
        public const string PointingDeviceSensor = "PointingDeviceSensor";
        public const string Rendering = "Rendering";
        public const string RigidBodyPhysics = "RigidBodyPhysics";
        public const string Scripting = "Scripting";
        public const string Shaders = "Shaders";
        public const string Shape = "Shape";
        public const string Sound = "Sound";
        public const string Text = "Text";
        public const string Texturing = "Texturing";
        public const string Texturing3D = "Texturing3D";
        public const string Time = "Time";

        public static string ToString(ComponentNames value)
        {
            switch (value)
            {
                case ComponentNames.Core: return Core;
                case ComponentNames.CADGeometry: return CADGeometry;
                case ComponentNames.CubeMapTexturing: return CubeMapTexturing;
                case ComponentNames.DIS: return DIS;
                case ComponentNames.EnvironmentalEffects: return EnvironmentalEffects;
                case ComponentNames.EnvironmentalSensor: return EnvironmentalSensor;
                case ComponentNames.EventUtilities: return EventUtilities;
                case ComponentNames.Followers: return Followers;
                case ComponentNames.Geometry2D: return Geometry2D;
                case ComponentNames.Geometry3D: return Geometry3D;
                case ComponentNames.Geospatial: return Geospatial;
                case ComponentNames.Grouping: return Grouping;
                case ComponentNames.H_Anim: return H_Anim;
                case ComponentNames.Interpolation: return Interpolation;
                case ComponentNames.KeyDeviceSensor: return KeyDeviceSensor;
                case ComponentNames.Layering: return Layering;
                case ComponentNames.Layout: return Layout;
                case ComponentNames.Lighting: return Lighting;
                case ComponentNames.Navigation: return Navigation;
                case ComponentNames.Networking: return Networking;
                case ComponentNames.NURBS: return NURBS;
                case ComponentNames.ParticleSystems: return ParticleSystems;
                case ComponentNames.PickingSensor: return PickingSensor;
                case ComponentNames.PointingDeviceSensor: return PointingDeviceSensor;
                case ComponentNames.Rendering: return Rendering;
                case ComponentNames.RigidBodyPhysics: return RigidBodyPhysics;
                case ComponentNames.Scripting: return Scripting;
                case ComponentNames.Shaders: return Shaders;
                case ComponentNames.Shape: return Shape;
                case ComponentNames.Sound: return Sound;
                case ComponentNames.Text: return Text;
                case ComponentNames.Texturing: return Texturing;
                case ComponentNames.Texturing3D: return Texturing3D;
                case ComponentNames.Time: return Time;
                default: throw new FormatException();
            }
        }

        public static ComponentNames FromString(string value)
        {
            switch (value)
            {
                case Core: return ComponentNames.Core;
                case CADGeometry: return ComponentNames.CADGeometry;
                case CubeMapTexturing: return ComponentNames.CubeMapTexturing;
                case DIS: return ComponentNames.DIS;
                case EnvironmentalEffects: return ComponentNames.EnvironmentalEffects;
                case EnvironmentalSensor: return ComponentNames.EnvironmentalSensor;
                case EventUtilities: return ComponentNames.EventUtilities;
                case Followers: return ComponentNames.Followers;
                case Geometry2D: return ComponentNames.Geometry2D;
                case Geometry3D: return ComponentNames.Geometry3D;
                case Geospatial: return ComponentNames.Geospatial;
                case Grouping: return ComponentNames.Grouping;
                case H_Anim: return ComponentNames.H_Anim;
                case Interpolation: return ComponentNames.Interpolation;
                case KeyDeviceSensor: return ComponentNames.KeyDeviceSensor;
                case Layering: return ComponentNames.Layering;
                case Layout: return ComponentNames.Layout;
                case Lighting: return ComponentNames.Lighting;
                case Navigation: return ComponentNames.Navigation;
                case Networking: return ComponentNames.Networking;
                case NURBS: return ComponentNames.NURBS;
                case ParticleSystems: return ComponentNames.ParticleSystems;
                case PickingSensor: return ComponentNames.PickingSensor;
                case PointingDeviceSensor: return ComponentNames.PointingDeviceSensor;
                case Rendering: return ComponentNames.Rendering;
                case RigidBodyPhysics: return ComponentNames.RigidBodyPhysics;
                case Scripting: return ComponentNames.Scripting;
                case Shaders: return ComponentNames.Shaders;
                case Shape: return ComponentNames.Shape;
                case Sound: return ComponentNames.Sound;
                case Text: return ComponentNames.Text;
                case Texturing: return ComponentNames.Texturing;
                case Texturing3D: return ComponentNames.Texturing3D;
                case Time: return ComponentNames.Time;
                default: throw new FormatException();
            }
        }
    }
}