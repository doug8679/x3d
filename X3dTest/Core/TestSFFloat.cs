namespace X3dTest.Core
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Globalization;
    using X3d.Core;

    /// <summary>
    /// <see cref="X3d.Core.SFFloat" /> unit test cases
    /// </summary>
    [TestClass]
    public class TestSFFloat
    {
        [TestMethod]
        public void Constructor()
        {
            var a = new SFFloat();
            var b = new SFFloat(a);
            var c = new SFFloat(123456.123456f);

            Assert.AreEqual(a, 0);
            Assert.AreEqual(b, a);
            Assert.AreEqual(c, 123456.123456f);
            Assert.AreNotEqual(c, true);
        }

        [TestMethod]
        public void FloatCompatibility()
        {
            var a = new SFFloat();
            var b = new SFFloat(a);
            var c = new SFFloat(123456.123456f);

            Assert.IsTrue(0 == a);
            Assert.IsTrue(b == 0);
            Assert.IsTrue(Math.Abs(123456.123456f - c) < 0.0000001f);
        }

        [TestMethod]
        public void FloatCasting()
        {
            var a = new SFFloat();
            var b = new SFFloat(a);
            var c = new SFFloat(123456.123456f);

            float v = a;
            SFFloat w = v;

            Assert.IsTrue(Math.Abs(a - v) < 0.0000001f);
            Assert.IsTrue(Math.Abs(v - w) < 0.0000001f);
            Assert.AreEqual(w, a);
        }

        [TestMethod]
        public void StringCompatibility()
        {
            var a = new SFFloat();
            var b = new SFFloat(123456.123456f);

            Assert.AreEqual(a.ToString(), 0.0f.ToString(CultureInfo.InvariantCulture));
            Assert.AreEqual(b.ToString(), 123456.123456f.ToString(CultureInfo.InvariantCulture));
        }

        [TestMethod]
        public void HashCode()
        {
            var a = new SFFloat();
            var b = new SFFloat(123456.123456f);

            Assert.AreEqual(a.GetHashCode(), 0.0f.GetHashCode());
            Assert.AreEqual(b.GetHashCode(), 123456.123456f.GetHashCode());
        }
    }
}