namespace X3dTest.Core
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
