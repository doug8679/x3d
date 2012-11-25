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

        [TestMethod]
        public void Serialization_Meta()
        {
            const string file = @"..\..\..\Sample\Core\meta.x3d";

            var x3d = new X3D();
            var head = new Head();

            x3d.Head = head;

            var meta1 = new Meta();
            var meta2 = new Meta();
            var meta3 = new Meta();
            var meta4 = new Meta();

            meta1.Name = "library";
            meta2.Name = "author";
            meta3.Name = "name";

            meta1.Content = "X3D.NET";
            meta2.Content = "Alexander Dong Back Kim";
            meta3.Content = "content";

            meta3.Direction = MetaDirectionValues.RightToLeft;
            meta3.HttpEquivalant = "http-equiv";
            meta3.Language = "lang";
            meta3.Scheme = "scheme";

            x3d.Head.Meta.Add(meta1);
            x3d.Head.Meta.Add(meta2);
            x3d.Head.Meta.Add(meta3);
            x3d.Head.Meta.Add(meta4);

            Serialize(file, x3d);
        }

        [TestMethod]
        public void Serialization_MetaDataObjects()
        {
            const string file = @"..\..\..\Sample\Core\metadata.x3d";

            var x3d = new X3D();
            var scene = x3d.Scene;

            var meta1 = new MetadataDouble();
            var meta2 = new MetadataFloat();
            var meta3 = new MetadataInteger();
            var meta4 = new MetadataSet();
            var meta5 = new MetadataString();

            meta1.Name = "double";
            meta1.Value = "1 1 1 1 1";
            meta1.Reference = "reference";
            
            scene.ChildNodes.Add(meta1);
            scene.ChildNodes.Add(meta2);
            scene.ChildNodes.Add(meta3);
            scene.ChildNodes.Add(meta4);
            scene.ChildNodes.Add(meta5);

            var submeta1 = new MetadataDouble();
            var submeta2 = new MetadataFloat();
            var submeta3 = new MetadataInteger();
            var submeta4 = new MetadataString();

            meta4.Value.Add(submeta1);
            meta4.Value.Add(submeta2);
            meta4.Value.Add(submeta3);
            meta4.Value.Add(submeta4);
            
            Serialize(file, x3d);
        }

        [TestMethod]
        public void Serialization_WorldInfo()
        {
            const string file = @"..\..\..\Sample\Core\WorldInfo.x3d";

            var x3d = new X3D();

            var wi1 = new WorldInfo();

            var wi2 = new WorldInfo();
            wi2.Title = "Hello";

            var wi3 = new WorldInfo();
            wi3.Metadata = new MetadataDouble();
            wi3.ContainerField = "Test";

            var wi4 = new WorldInfo();
            wi4.Info = "\"A\" \"B\" \"C\"";

            var wi5 = new WorldInfo();
            wi5.DEF = "HelloWorld";

            x3d.Scene.ChildNodes.Add(wi1);
            x3d.Scene.ChildNodes.Add(wi2);
            x3d.Scene.ChildNodes.Add(wi3);
            x3d.Scene.ChildNodes.Add(wi4);
            x3d.Scene.ChildNodes.Add(wi5);

            Serialize(file, x3d);
        }
    }
}
