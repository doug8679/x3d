namespace X3dTest.Core
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
