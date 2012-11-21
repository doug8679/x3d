namespace X3dTest.Core
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using X3d.Core;

    [TestClass]
    public class TestSFVec4f
    {
        private const float EPSILON = 0.0000001f;

        [TestMethod]
        public void Constructor()
        {
            var a = new SFVec4f();

            Assert.IsTrue(Math.Abs(a.X - 0.0f) < EPSILON);
            Assert.IsTrue(Math.Abs(a.Y - 0.0f) < EPSILON);
            Assert.IsTrue(Math.Abs(a.Z - 0.0f) < EPSILON);
            Assert.IsTrue(Math.Abs(a.Homegeneous - 1.0f) < EPSILON);

            var b = new SFVec4f(1, 1, 1, 0);

            Assert.IsTrue(Math.Abs(b.X - 1.0f) < EPSILON);
            Assert.IsTrue(Math.Abs(b.Y - 1.0f) < EPSILON);
            Assert.IsTrue(Math.Abs(b.Z - 1.0f) < EPSILON);
            Assert.IsTrue(Math.Abs(b.Homegeneous - 0.0f) < EPSILON);
        }

        [TestMethod]
        public void ElementAssignment()
        {
            var a = new SFVec4d();

            a.X = 1;
            a.Y = 1;
            a.Z = 1;
            a.Homegeneous = 0;

            Assert.IsTrue(Math.Abs(a.X - 1.0f) < EPSILON);
            Assert.IsTrue(Math.Abs(a.Y - 1.0f) < EPSILON);
            Assert.IsTrue(Math.Abs(a.Z - 1.0f) < EPSILON);
            Assert.IsTrue(Math.Abs(a.Homegeneous - 0.0f) < EPSILON);
        }

        [TestMethod]
        public void ObjectEquality()
        {
            var a = new SFVec4f(1234567.123456f, -1234567.987654f, 0.000001f, -0.111111f);
            var b = new SFVec4f(1234567.123456f, -1234567.987654f, 0.000001f, -0.111111f);
            var c = new SFVec4f(1234567.987654f, -1234567.123456f, 0.000001f, -0.111111f);

            Assert.AreEqual(a, b);
            Assert.AreNotEqual(a, c);
            Assert.AreNotEqual(b, c);
            Assert.AreEqual(a, a);
            Assert.AreEqual(c, c);

            Assert.AreNotEqual(c, false);
        }

        [TestMethod]
        public void StringCompatibility()
        {
            const string s = "123.123 -123.987 0.000001 -0.111111";
            var a = new SFVec4f(123.123f, -123.987f, 0.000001f, -0.111111f);
            var t = a.ToString();

            Assert.AreEqual(s, a.ToString());
        }

        [TestMethod]
        public void HashCode()
        {
            var a = new SFVec4f();
            var b = new SFVec4f();

            Assert.AreEqual(a.GetHashCode(), b.GetHashCode());
        }
    }
}