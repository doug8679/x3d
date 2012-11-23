namespace X3dTest.Core
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using X3d.Core;

    /// <summary>
    /// <see cref="X3d.Core.SFMatrix3f" /> unit test cases
    /// </summary>
    [TestClass]
    public class TestSFMatrix3f
    {
        private const float EPSILON = 0.000001f;

        [TestMethod]
        public void Constructors()
        {
            var mat = new SFMatrix3f();

            Assert.IsTrue(Math.Abs(mat.Elements[0, 0] - 1) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[0, 1] - 0) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[0, 2] - 0) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[1, 0] - 0) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[1, 1] - 1) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[1, 2] - 0) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[2, 0] - 0) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[2, 1] - 0) < EPSILON);
            Assert.IsTrue(Math.Abs(mat.Elements[2, 2] - 1) < EPSILON);

            var test = new SFFloat[,] { { 1, 1, 1 }, { 0, 0, 0 }, { -1, -1, -1 } };
            mat = new SFMatrix3f(test);

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
                var element = new SFFloat[,] { { 1 }, { 0 } };
                new SFMatrix3f(element);
                Assert.Fail();
            }
            catch (ArgumentException)
            {
            }
        }

        [TestMethod]
        public void HashCode()
        {
            var mat1 = new SFMatrix3f();
            var mat2 = new SFMatrix3f();

            Assert.AreEqual(mat1.GetHashCode(), mat2.GetHashCode());

            var test = new SFFloat[,] { { 1, 1, 1 }, { 0, 0, 0 }, { -1, -1, -1 } };
            mat1 = new SFMatrix3f(test);
            mat2 = new SFMatrix3f(test);

            Assert.AreEqual(mat1.GetHashCode(), mat2.GetHashCode());
        }

        [TestMethod]
        public void Equals()
        {
            var mat1 = new SFMatrix3f();
            var mat2 = new SFMatrix3f();

            Assert.AreEqual(mat1, mat2);

            var test = new SFFloat[,] { { 1, 1, 1 }, { 0, 0, 0 }, { -1, -1, -1 } };
            mat1 = new SFMatrix3f(test);
            mat2 = new SFMatrix3f(test);

            Assert.AreEqual(mat1.GetHashCode(), mat2.GetHashCode());
        }

        [TestMethod]
        public void StringCompatibility()
        {
            var mat = new SFMatrix3f();
            var str = mat.ToString();

            Assert.AreEqual(mat.ToString(), "1 0 0 0 1 0 0 0 1");
        }
    }
}
