namespace X3dTest.Core
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using X3d.Core;

    /// <summary>
    /// <see cref="X3DMetadataObject" /> unit test cases
    /// </summary>
    [TestClass]
    public class TestMetadataObjects
    {
        [TestMethod]
        public void MetadataDouble()
        {
            var obj = new MetadataDouble();

            Assert.AreEqual(obj.ContainerField, "metadata");
            Assert.AreEqual(obj.Name, string.Empty);
            Assert.AreEqual(obj.Reference, string.Empty);
        }

        [TestMethod]
        public void MetadataFloat()
        {
            var obj = new MetadataFloat();

            Assert.AreEqual(obj.ContainerField, "metadata");
            Assert.AreEqual(obj.Name, string.Empty);
            Assert.AreEqual(obj.Reference, string.Empty);
        }

        [TestMethod]
        public void MetadataInteger()
        {
            var obj = new MetadataInteger();

            Assert.AreEqual(obj.ContainerField, "metadata");
            Assert.AreEqual(obj.Name, string.Empty);
            Assert.AreEqual(obj.Reference, string.Empty);
        }

        [TestMethod]
        public void MetadataSet()
        {
            var obj = new MetadataSet();

            Assert.AreEqual(obj.ContainerField, "metadata");
            Assert.AreEqual(obj.Name, string.Empty);
            Assert.AreEqual(obj.Reference, string.Empty);
        }

        [TestMethod]
        public void MetadataString()
        {
            var obj = new MetadataString();

            Assert.AreEqual(obj.ContainerField, "metadata");
            Assert.AreEqual(obj.Name, string.Empty);
            Assert.AreEqual(obj.Reference, string.Empty);
        }
    }
}
