namespace X3dTest.Core
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using X3d.Core;

    /// <summary>
    /// <see cref="X3d.Core.SFBool" /> unit test cases
    /// </summary>
    [TestClass]
    public class TestSFBool
    {
        [TestMethod]
        public void Constructor()
        {
            var a = new SFBool();
            var b = new SFBool(a);
            var c = new SFBool(true);

            Assert.AreEqual(false, (bool)a);
            Assert.AreEqual(false, (bool)b);
            Assert.AreEqual(true, (bool)c);
        }

        [TestMethod]
        public void BooleanCompatibility()
        {
            var a = new SFBool();
            var b = new SFBool(a);
            var c = new SFBool(true);
            
            Assert.AreEqual((SFBool)false, a);
            Assert.AreEqual((SFBool)false, b);
            Assert.AreEqual((SFBool)true, c);
        }
    }
}
