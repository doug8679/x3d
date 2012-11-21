namespace X3dTest.Core
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using X3d.Core;

    /// <summary>
    /// <see cref="X3d.Core.SFColor" /> unit test cases
    /// </summary>
    [TestClass]
    public class TestSFColor
    {
        [TestMethod]
        public void Constructor()
        {
            var a = new SFColor();
            var b = new SFColor(1.0f, 1.0f, 1.0f);

            Assert.AreEqual(a.Red, 0.0f);
            Assert.AreEqual(a.Green, 0.0f);
            Assert.AreEqual(a.Blue, 0.0f);

            Assert.AreEqual(b.Red, 1.0f);
            Assert.AreEqual(b.Green, 1.0f);
            Assert.AreEqual(b.Blue, 1.0f);
        }

        [TestMethod]
        public void ConstructorException()
        {
            try
            {
                var a = new SFColor(1.01f, 0.0f, 0.0f);
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException)
            {
            }

            try
            {
                var a = new SFColor(-0.01f, 0.0f, 0.0f);
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException)
            {
            }
        }

        [TestMethod]
        public void RedComponent()
        {
            var a = new SFColor();

            a.Red = 1.0f;

            Assert.AreEqual(a.Red, 1.0f);

            try
            {
                a.Red = 1.1f;
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException)
            {
            }

            try
            {
                a.Red = -0.001f;
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException)
            {
            }
        }

        [TestMethod]
        public void GreenComponent()
        {
            var a = new SFColor();

            a.Green = 1.0f;

            Assert.AreEqual(a.Green, 1.0f);

            try
            {
                a.Green = 1.1f;
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException)
            {
            }

            try
            {
                a.Green = -0.001f;
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException)
            {
            }
        }

        [TestMethod]
        public void BlueComponent()
        {
            var a = new SFColor();

            a.Blue = 1.0f;

            Assert.AreEqual(a.Blue, 1.0f);

            try
            {
                a.Blue = 1.1f;
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException)
            {
            }

            try
            {
                a.Blue = -0.001f;
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException)
            {
            }
        }
    }
}
