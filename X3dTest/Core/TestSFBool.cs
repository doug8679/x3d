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

            Assert.AreEqual(a, false);
            Assert.AreEqual(b, a);
            Assert.AreEqual(c, true);
            Assert.AreNotEqual(a, 1);
        }

        [TestMethod]
        public void BooleanCompatibility()
        {
            var a = new SFBool();
            var b = new SFBool(a);
            var c = new SFBool(true);

            Assert.IsTrue(false == a);
            Assert.IsTrue(false == b);
            Assert.IsTrue(true == c);
        }

        [TestMethod]
        public void BooleanCasting()
        {
            var a = new SFBool();
            bool v = a;
            SFBool w = v;

            Assert.IsTrue(a == v);
            Assert.IsTrue(v == w);
            Assert.AreEqual(w, a);
        }

        [TestMethod]
        public void StringConstruction()
        {
            var a = new SFBool();
            var b = new SFBool(true);

            Assert.AreEqual(a.ToString(), SFBool.FalseString);
            Assert.AreEqual(b.ToString(), SFBool.TrueString);
        }

        [TestMethod]
        public void HashCode()
        {
            var a = new SFBool();
            var b = new SFBool(true);

            Assert.AreEqual(a.GetHashCode(), false.GetHashCode());
            Assert.AreEqual(b.GetHashCode(), true.GetHashCode());
        }
    }
}