namespace X3dTest.Core
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using X3d.Core;

    [TestClass]
    public class TestSFVec2f
    {
        private const float EPSILON = 0.0000001f;

        [TestMethod]
        public void Constructor()
        {
            var a = new SFVec2f();

            Assert.IsTrue(Math.Abs(a.X - 0.0f) < EPSILON);
            Assert.IsTrue(Math.Abs(a.Y - 0.0f) < EPSILON);

            var b = new SFVec2f(1, 1);

            Assert.IsTrue(Math.Abs(b.X - 1.0f) < EPSILON);
            Assert.IsTrue(Math.Abs(b.Y - 1.0f) < EPSILON);
        }

        [TestMethod]
        public void ElementAssignment()
        {
            var a = new SFVec2d();

            a.X = 1;
            a.Y = 1;

            Assert.IsTrue(Math.Abs(a.X - 1.0) < EPSILON);
            Assert.IsTrue(Math.Abs(a.Y - 1.0) < EPSILON);
        }

        [TestMethod]
        public void ObjectEquality()
        {
            var a = new SFVec2f(0.123456f, 0.987654f);
            var b = new SFVec2f(0.123456f, 0.987654f);
            var c = new SFVec2f(0.987654f, 0.123456f);

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
            const string s1 = "0.123456 0.987654";
            var a = new SFVec2f(0.123456f, 0.987654f);

            Assert.AreEqual(s1, a.ToString());
        }

        [TestMethod]
        public void HashCode()
        {
            var a = new SFVec2f();
            var b = new SFVec2f();

            Assert.AreEqual(a.GetHashCode(), b.GetHashCode());
        }
    }
}