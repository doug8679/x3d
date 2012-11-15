namespace X3dTest.Core
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using X3d.Core;

    [TestClass]
    public class TestSFVec2d
    {
        private const double EPSILON = 0.0000000000001;

        [TestMethod]
        public void Constructor()
        {
            var a = new SFVec2d();

            Assert.IsTrue(Math.Abs(a.X - 0.0) < EPSILON);
            Assert.IsTrue(Math.Abs(a.Y - 0.0) < EPSILON);

            var b = new SFVec2d(1, 1);

            Assert.IsTrue(Math.Abs(b.X - 1.0) < EPSILON);
            Assert.IsTrue(Math.Abs(b.Y - 1.0) < EPSILON);
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
            var a = new SFVec2d(0.123456789, 0.987654321);
            var b = new SFVec2d(0.123456789, 0.987654321);
            var c = new SFVec2d(0.987654321, 0.123456789);

            Assert.AreEqual(a, b);
            Assert.AreNotEqual(a, c);
            Assert.AreNotEqual(b, c);
            Assert.AreEqual(a, a);
            Assert.AreEqual(c, c);
        }

        [TestMethod]
        public void StringCompatibility()
        {
            const string s1 = "0.123456789 0.987654321";
            var a = new SFVec2d(0.123456789, 0.987654321);
            
            Assert.AreEqual(s1, a.ToString());
        }
    }
}
