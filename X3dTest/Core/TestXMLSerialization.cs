namespace X3dTest.Core
{
    using System.IO;
    using System.Xml.Serialization;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using X3d.Core;

    [TestClass]
    public class TestXMLSerialization
    {
        [TestMethod]
        public void Serialization_SimplestX3D()
        {
            var x3d = new X3D();
            var serializer = new XmlSerializer(x3d.GetType());
            var ns = new XmlSerializerNamespaces();
            
            ns.Add(string.Empty, string.Empty);

            using (TextWriter textWriter = new StreamWriter(@"..\..\..\Sample\Core\simple.x3d"))
            {
                serializer.Serialize(textWriter, x3d, ns);
            }
        }
    }
}
