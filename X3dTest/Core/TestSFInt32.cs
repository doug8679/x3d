namespace X3dTest.Core
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Globalization;
    using X3d.Core;

    /// <summary>
    /// <see cref="X3d.Core.SFInt32" /> unit test cases
    /// </summary>
    [TestClass]
    public class TestSFInt32
    {
        [TestMethod]
        public void Constructor()
        {
            var a = new SFInt32();
            var b = new SFInt32(a);
            var c = new SFInt32(1);

            Assert.AreEqual(a, 0);
            Assert.AreEqual(b, a);
            Assert.AreEqual(c, 1);
            Assert.AreNotEqual(a, false);
        }

        [TestMethod]
        public void IntegerCompatibility()
        {
            var a = new SFInt32();
            var b = new SFInt32(a);
            var c = new SFInt32(1);

            Assert.IsTrue(0 == a);
            Assert.IsTrue(b == 0);
            Assert.IsTrue(1 == c);
        }

        [TestMethod]
        public void IntegerCasting()
        {
            var a = new SFInt32();
            var b = new SFInt32(a);
            var c = new SFInt32(1);

            int v = a;
            SFInt32 w = v;

            Assert.IsTrue(a == v);
            Assert.IsTrue(v == w);
            Assert.AreEqual(w, a);
        }

        [TestMethod]
        public void StringConstruction()
        {
            var a = new SFInt32();
            var b = new SFInt32(-1);

            Assert.AreEqual(a.ToString(), 0.ToString(CultureInfo.InvariantCulture));
            Assert.AreEqual(b.ToString(), (-1).ToString(CultureInfo.InvariantCulture));
        }

        [TestMethod]
        public void HashCode()
        {
            var a = new SFInt32();
            var b = new SFInt32(-1);

            Assert.AreEqual(a.GetHashCode(), 0.GetHashCode());
            Assert.AreEqual(b.GetHashCode(), (-1).GetHashCode());
        }
    }
}