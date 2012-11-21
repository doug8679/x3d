namespace X3dTest.Core
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using X3d.Core;

    [TestClass]
    public class TestSFVec4d
    {
        private const double EPSILON = 0.0000000000001;

        [TestMethod]
        public void Constructor()
        {
            var a = new SFVec4d();

            Assert.IsTrue(Math.Abs(a.X - 0.0) < EPSILON);
            Assert.IsTrue(Math.Abs(a.Y - 0.0) < EPSILON);
            Assert.IsTrue(Math.Abs(a.Z - 0.0) < EPSILON);
            Assert.IsTrue(Math.Abs(a.Homegeneous - 1.0) < EPSILON);

            var b = new SFVec4d(1, 1, 1, 0);

            Assert.IsTrue(Math.Abs(b.X - 1.0) < EPSILON);
            Assert.IsTrue(Math.Abs(b.Y - 1.0) < EPSILON);
            Assert.IsTrue(Math.Abs(b.Z - 1.0) < EPSILON);
            Assert.IsTrue(Math.Abs(b.Homegeneous - 0.0) < EPSILON);
        }

        [TestMethod]
        public void ElementAssignment()
        {
            var a = new SFVec4d();

            a.X = 1;
            a.Y = 1;
            a.Z = 1;
            a.Homegeneous = 0;

            Assert.IsTrue(Math.Abs(a.X - 1.0) < EPSILON);
            Assert.IsTrue(Math.Abs(a.Y - 1.0) < EPSILON);
            Assert.IsTrue(Math.Abs(a.Z - 1.0) < EPSILON);
            Assert.IsTrue(Math.Abs(a.Homegeneous - 0.0) < EPSILON);
        }

        [TestMethod]
        public void ObjectEquality()
        {
            var a = new SFVec4d(0.123456789, 0.987654321, 0.000000001, 0.111111111111);
            var b = new SFVec4d(0.123456789, 0.987654321, 0.000000001, 0.111111111111);
            var c = new SFVec4d(0.987654321, 0.123456789, 0.000000001, 0.111111111111);

            Assert.AreEqual(a, b);
            Assert.AreNotEqual(a, c);
            Assert.AreNotEqual(b, c);
            Assert.AreEqual(a, a);
            Assert.AreEqual(c, c);
        }

        [TestMethod]
        public void StringCompatibility()
        {
            const string s = "0.123456789 0.987654321 0.000000001 0.111111111111";
            var a = new SFVec4d(0.123456789, 0.987654321, 0.000000001, 0.111111111111);
            var t = a.ToString();

            Assert.AreEqual(s, a.ToString());
        }

        [TestMethod]
        public void HashCode()
        {
            var a = new SFVec4d();
            var b = new SFVec4d();

            Assert.AreEqual(a.GetHashCode(), b.GetHashCode());
        }
    }
}