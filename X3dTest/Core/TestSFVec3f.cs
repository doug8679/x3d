namespace X3dTest.Core
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using X3d.Core;

    [TestClass]
    public class TestSFVec3f
    {
        private const float EPSILON = 0.0000001f;

        [TestMethod]
        public void Constructor()
        {
            var a = new SFVec3f();

            Assert.IsTrue(Math.Abs(a.X - 0.0f) < EPSILON);
            Assert.IsTrue(Math.Abs(a.Y - 0.0f) < EPSILON);
            Assert.IsTrue(Math.Abs(a.Z - 0.0f) < EPSILON);

            var b = new SFVec3f(1, 1, 1);

            Assert.IsTrue(Math.Abs(b.X - 1.0f) < EPSILON);
            Assert.IsTrue(Math.Abs(b.Y - 1.0f) < EPSILON);
            Assert.IsTrue(Math.Abs(b.Z - 1.0f) < EPSILON);
        }

        [TestMethod]
        public void ElementAssignment()
        {
            var a = new SFVec3f();

            a.X = 1;
            a.Y = 1;
            a.Z = 1;

            Assert.IsTrue(Math.Abs(a.X - 1.0f) < EPSILON);
            Assert.IsTrue(Math.Abs(a.Y - 1.0f) < EPSILON);
            Assert.IsTrue(Math.Abs(a.Z - 1.0f) < EPSILON);
        }

        [TestMethod]
        public void ObjectEquality()
        {
            var a = new SFVec3f(0.456789f, 0.654321f, 0.000001f);
            var b = new SFVec3f(0.456789f, 0.654321f, 0.000001f);
            var c = new SFVec3f(0.654321f, 0.456789f, 0.000001f);

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
            const string s = "0.456789 0.654321 0.000001";
            var a = new SFVec3d(0.456789, 0.654321, 0.000001);

            Assert.AreEqual(s, a.ToString());
        }

        [TestMethod]
        public void HashCode()
        {
            var a = new SFVec3f();
            var b = new SFVec3f();

            Assert.AreEqual(a.GetHashCode(), b.GetHashCode());
        }
    }
}