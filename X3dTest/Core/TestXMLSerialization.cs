namespace X3dTest.Core
{
    using System.IO;
    using System.Xml.Serialization;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using X3d.Core;

    [TestClass]
    public class TestXMLSerialization
    {
        private static void Serialize(string file, X3D x3d)
        {
            var serializer = new XmlSerializer(x3d.GetType());
            var ns = new XmlSerializerNamespaces();

            ns.Add(string.Empty, string.Empty);

            using (TextWriter textWriter = new StreamWriter(file))
            {
                serializer.Serialize(textWriter, x3d, ns);
            }
        }

        [TestMethod]
        public void Serialization_Simple()
        {
            const string file = @"..\..\..\Sample\Core\simple.x3d";
            
            var x3d = new X3D();
        
            Serialize(file, x3d);
        }

        [TestMethod]
        public void Serialization_EmptyHead()
        {
            const string file = @"..\..\..\Sample\Core\empty_head.x3d";

            var x3d = new X3D();
            x3d.Head = new Head();

            Serialize(file, x3d);
        }

        [TestMethod]
        public void Serialization_Components()
        {
            const string file = @"..\..\..\Sample\Core\components.x3d";

            var x3d = new X3D();
            var head = new Head();

            x3d.Head = head;

            head.Components.Add(new Component(ComponentNames.CADGeometry, 1));
            head.Components.Add(new Component(ComponentNames.Core, 1));
            head.Components.Add(new Component(ComponentNames.CubeMapTexturing, 1));
            head.Components.Add(new Component(ComponentNames.DIS, 1));
            head.Components.Add(new Component(ComponentNames.EnvironmentalEffects, 1));
            head.Components.Add(new Component(ComponentNames.EnvironmentalSensor, 1));
            head.Components.Add(new Component(ComponentNames.EventUtilities, 1));
            head.Components.Add(new Component(ComponentNames.Followers, 1));
            head.Components.Add(new Component(ComponentNames.Geometry2D, 1));
            head.Components.Add(new Component(ComponentNames.Geometry3D, 1));
            head.Components.Add(new Component(ComponentNames.Geospatial, 1));
            head.Components.Add(new Component(ComponentNames.Grouping, 1));
            head.Components.Add(new Component(ComponentNames.H_Anim, 1));
            head.Components.Add(new Component(ComponentNames.Interpolation, 1));
            head.Components.Add(new Component(ComponentNames.KeyDeviceSensor, 1));
            head.Components.Add(new Component(ComponentNames.Layering, 1));
            head.Components.Add(new Component(ComponentNames.Layout, 1));
            head.Components.Add(new Component(ComponentNames.Lighting, 1));
            head.Components.Add(new Component(ComponentNames.NURBS, 1));
            head.Components.Add(new Component(ComponentNames.Navigation, 1));
            head.Components.Add(new Component(ComponentNames.Networking, 1));
            head.Components.Add(new Component(ComponentNames.ParticleSystems, 1));
            head.Components.Add(new Component(ComponentNames.PickingSensor, 1));
            head.Components.Add(new Component(ComponentNames.PointingDeviceSensor, 1));
            head.Components.Add(new Component(ComponentNames.Rendering, 1));
            head.Components.Add(new Component(ComponentNames.RigidBodyPhysics, 1));
            head.Components.Add(new Component(ComponentNames.Scripting, 1));
            head.Components.Add(new Component(ComponentNames.Shaders, 1));
            head.Components.Add(new Component(ComponentNames.Shape, 1));
            head.Components.Add(new Component(ComponentNames.Sound, 1));
            head.Components.Add(new Component(ComponentNames.Text, 1));
            head.Components.Add(new Component(ComponentNames.Texturing, 1));
            head.Components.Add(new Component(ComponentNames.Texturing3D, 1));
            head.Components.Add(new Component(ComponentNames.Time, 1));

            Serialize(file, x3d);
        }
    }
}
