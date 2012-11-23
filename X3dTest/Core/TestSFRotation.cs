namespace X3dTest.Core
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using X3d.Core;

    [TestClass]
    public class TestSFRotation
    {
        private const float EPSILON = 0.0000001f;

        [TestMethod]
        public void Constructor()
        {
            var a = new SFRotation();

            Assert.IsTrue(Math.Abs(a.X - 0.0f) < EPSILON);
            Assert.IsTrue(Math.Abs(a.Y - 0.0f) < EPSILON);
            Assert.IsTrue(Math.Abs(a.Z - 1.0f) < EPSILON);
            Assert.IsTrue(Math.Abs(a.Angle - 0.0f) < EPSILON);

            var b = new SFRotation(1, 1, 1, 1);

            Assert.IsTrue(Math.Abs(b.X - 1.0f) < EPSILON);
            Assert.IsTrue(Math.Abs(b.Y - 1.0f) < EPSILON);
            Assert.IsTrue(Math.Abs(b.Z - 1.0f) < EPSILON);
            Assert.IsTrue(Math.Abs(b.Angle - 1.0f) < EPSILON);
        }

        [TestMethod]
        public void ElementAssignment()
        {
            var a = new SFRotation();

            a.X = 1;
            a.Y = 1;
            a.Z = 1;
            a.Angle = 1;

            Assert.IsTrue(Math.Abs(a.X - 1.0f) < EPSILON);
            Assert.IsTrue(Math.Abs(a.Y - 1.0f) < EPSILON);
            Assert.IsTrue(Math.Abs(a.Z - 1.0f) < EPSILON);
            Assert.IsTrue(Math.Abs(a.Angle - 1.0f) < EPSILON);
        }

        [TestMethod]
        public void ObjectEquality()
        {
            var a = new SFRotation(0.456789f, 0.654321f, 0.000001f, 1.0f);
            var b = new SFRotation(0.456789f, 0.654321f, 0.000001f, 1.0f);
            var c = new SFRotation(0.654321f, 0.456789f, 0.000001f, 1.0f);

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
            const string s = "0.456789 0.654321 0.000001 1.123456";
            var a = new SFRotation(0.456789f, 0.654321f, 0.000001f, 1.123456f);

            Assert.AreEqual(s, a.ToString());
        }

        [TestMethod]
        public void HashCode()
        {
            var a = new SFRotation();
            var b = new SFRotation();

            Assert.AreEqual(a.GetHashCode(), b.GetHashCode());
        }
    }
}
