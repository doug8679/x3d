namespace X3dTest.Core
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using X3d.Core;

    /// <summary>
    /// <see cref="X3d.Core.SFMatrix3d" /> unit test cases
    /// </summary>
    [TestClass]
    public class TestSFMatrix3d
    {
        private const double EPSILON = 0.000000000001;

        [TestMethod]
        public void Constructors()
        {
            var mat = new SFMatrix3d();

            Assert.IsTrue(Math.Abs(mat.Elements[0, 0] - 1) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[0, 1] - 0) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[0, 2] - 0) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[1, 0] - 0) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[1, 1] - 1) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[1, 2] - 0) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[2, 0] - 0) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[2, 1] - 0) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[2, 2] - 1) < EPSILON);

            var test = new SFDouble[,] { { 1, 1, 1 }, { 0, 0, 0 }, { -1, -1, -1 } };
            mat = new SFMatrix3d(test);

            Assert.IsTrue(Math.Abs(mat.Elements[0, 0] - 1) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[0, 1] - 1) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[0, 2] - 1) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[1, 0] - 0) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[1, 1] - 0) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[1, 2] - 0) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[2, 0] + 1) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[2, 1] + 1) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[2, 2] + 1) < EPSILON);

            try
            {
                var element = new SFDouble[,] { { 1 }, { 0 } };
                new SFMatrix3d(element);
                Assert.Fail();
            }
            catch (ArgumentException)
            {
            }
        }

        [TestMethod]
        public void HashCode()
        {
            var mat1 = new SFMatrix3d();
            var mat2 = new SFMatrix3d();

            Assert.AreEqual(mat1.GetHashCode(), mat2.GetHashCode());

            var test = new SFDouble[,] { { 1, 1, 1 }, { 0, 0, 0 }, { -1, -1, -1 } };
            mat1 = new SFMatrix3d(test);
            mat2 = new SFMatrix3d(test);

            Assert.AreEqual(mat1.GetHashCode(), mat2.GetHashCode());
        }

        [TestMethod]
        public void Equals()
        {
            var mat1 = new SFMatrix3d();
            var mat2 = new SFMatrix3d();

            Assert.AreEqual(mat1, mat2);

            var test = new SFDouble[,] { { 1, 1, 1 }, { 0, 0, 0 }, { -1, -1, -1 } };
            mat1 = new SFMatrix3d(test);
            mat2 = new SFMatrix3d(test);

            Assert.AreEqual(mat1.GetHashCode(), mat2.GetHashCode());

            var a = new SFMatrix3d();
            var c = new SFMatrix4d();
            var t = new SFDouble[,] { { 1, 1, 1 }, { 0, 0, 0 }, { -1, -1, -1 } };
            var b = new SFMatrix3d(test);

            Assert.AreNotEqual(a, b);
            Assert.AreNotEqual(a, t);
            Assert.AreNotEqual(a, c);
        }

        [TestMethod]
        public void StringCompatibility()
        {
            var mat = new SFMatrix3d();
            var str = mat.ToString();

            Assert.AreEqual(mat.ToString(), "1 0 0 0 1 0 0 0 1");
        }
    }
}