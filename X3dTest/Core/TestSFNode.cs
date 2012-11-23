namespace X3dTest.Core
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using X3d.Core;

    [TestClass]
    public class TestSFNode
    {
        [TestMethod]
        public void Constructors()
        {
            var node = new SFNode();

            Assert.AreEqual(node.ToString(), "NULL");

            node = new SFNode("foo");

            Assert.AreEqual(node.ToString(), "foo");

            node = new SFNode(new SFNode("bar"));

            Assert.AreEqual(node.ToString(), "bar");
        }
    }
}