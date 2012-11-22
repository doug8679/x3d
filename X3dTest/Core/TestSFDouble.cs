namespace X3dTest.Core
{
    using System;
    using System.Globalization;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using X3d.Core;

    /// <summary>
    /// <see cref="X3d.Core.SFDouble" /> unit test cases
    /// </summary>
    [TestClass]
    public class TestSFDouble
    {
        [TestMethod]
        public void Constructor()
        {
            var a = new SFDouble();
            var b = new SFDouble(a);
            var c = new SFDouble(123456.12345678901234);

            Assert.AreEqual(a, 0);
            Assert.AreEqual(b, a);
            Assert.AreEqual(c, 123456.12345678901234);
            Assert.AreNotEqual(c, true);
        }

        [TestMethod]
        public void DoubleCompatibility()
        {
            var a = new SFDouble();
            var b = new SFDouble(a);
            var c = new SFDouble(123456.12345678901234);

            Assert.IsTrue(0 == a);
            Assert.IsTrue(b == 0);
            Assert.IsTrue(Math.Abs(123456.12345678901234 - c) < 0.000000000000001);
        }

        [TestMethod]
        public void DoubleCasting()
        {
            var a = new SFDouble();
            double v = a;
            SFDouble w = v;

            Assert.IsTrue(Math.Abs(a - v) < 0.000000000000001);
            Assert.IsTrue(Math.Abs(v - w) < 0.000000000000001);
            Assert.AreEqual(w, a);
        }

        [TestMethod]
        public void StringCompatibility()
        {
            var a = new SFDouble();
            var b = new SFDouble(123456.12345678901234);

            Assert.AreEqual(a.ToString(), 0.0.ToString(CultureInfo.InvariantCulture));
            Assert.AreEqual(b.ToString(), 123456.12345678901234.ToString(CultureInfo.InvariantCulture));
        }

        [TestMethod]
        public void HashCode()
        {
            var a = new SFDouble();
            var b = new SFDouble(123456.12345678901234);

            Assert.AreEqual(a.GetHashCode(), 0.0.GetHashCode());
            Assert.AreEqual(b.GetHashCode(), 123456.12345678901234.GetHashCode());
        }
    }
}