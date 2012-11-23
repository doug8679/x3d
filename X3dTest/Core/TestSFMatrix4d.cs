namespace X3dTest.Core
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using X3d.Core;

    /// <summary>
    /// <see cref="X3d.Core.SFMatrix4d" /> unit test cases
    /// </summary>
    [TestClass]
    public class TestSFMatrix4d
    {
        private const double EPSILON = 0.000000000001;

        [TestMethod]
        public void Constructors()
        {
            var mat = new SFMatrix4d();

            Assert.IsTrue(Math.Abs(mat.Elements[0, 0] - 1) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[0, 1] - 0) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[0, 2] - 0) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[0, 3] - 0) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[1, 0] - 0) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[1, 1] - 1) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[1, 2] - 0) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[1, 3] - 0) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[2, 0] - 0) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[2, 1] - 0) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[2, 2] - 1) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[2, 3] - 0) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[3, 0] - 0) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[3, 1] - 0) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[3, 2] - 0) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[3, 3] - 1) < EPSILON);

            var elements = new SFDouble[,] { { 1, 1, 1, 1 }, { 0, 0, 0, 0 }, { -1, -1, -1, -1 }, { 0, 0, 0, 0 } };
            mat = new SFMatrix4d(elements);

            Assert.IsTrue(Math.Abs(mat.Elements[0, 0] - 1) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[0, 1] - 1) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[0, 2] - 1) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[0, 3] - 1) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[1, 0] - 0) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[1, 1] - 0) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[1, 2] - 0) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[1, 3] - 0) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[2, 0] + 1) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[2, 1] + 1) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[2, 2] + 1) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[2, 3] + 1) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[3, 0] - 0) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[3, 1] - 0) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[3, 2] - 0) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[3, 3] - 0) < EPSILON);

            try
            {
                var element = new SFDouble[,] { { 1 }, { 0 } };
                new SFMatrix4d(element);
                Assert.Fail();
            }
            catch (ArgumentException)
            {
            }
        }

        [TestMethod]
        public void HashCode()
        {
            var mat1 = new SFMatrix4d();
            var mat2 = new SFMatrix4d();

            Assert.AreEqual(mat1.GetHashCode(), mat2.GetHashCode());

            var test = new SFDouble[,] { { 1, 1, 1, 1 }, { 0, 0, 0, 0 }, { -1, -1, -1, -1 }, { -1, -1, -1, -1 } };
            mat1 = new SFMatrix4d(test);
            mat2 = new SFMatrix4d(test);

            Assert.AreEqual(mat1.GetHashCode(), mat2.GetHashCode());
        }

        [TestMethod]
        public void Equals()
        {
            var mat1 = new SFMatrix4d();
            var mat2 = new SFMatrix4d();

            Assert.AreEqual(mat1, mat2);

            var test = new SFDouble[,] { { 1, 1, 1, 1 }, { 0, 0, 0, 0 }, { -1, -1, -1, -1 }, { -1, -1, -1, -1 } };
            mat1 = new SFMatrix4d(test);
            mat2 = new SFMatrix4d(test);

            Assert.AreEqual(mat1.GetHashCode(), mat2.GetHashCode());
        }

        [TestMethod]
        public void StringCompatibility()
        {
            var mat = new SFMatrix4d();
            var str = mat.ToString();

            Assert.AreEqual(mat.ToString(), "1 0 0 0 0 1 0 0 0 0 1 0 0 0 0 1");
        }
    }
}