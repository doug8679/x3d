namespace X3dTest.Core
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using X3d.Core;

    /// <summary>
    /// <see cref="X3d.Core.SFTime" /> unit test cases
    /// </summary>
    [TestClass]
    public class TestSFTime
    {
        [TestMethod]
        public void Constructor()
        {
            var a = new SFTime();
            var b = new SFTime(a);
            var c = new SFTime(123456.12345678901234);

            Assert.IsTrue(Math.Abs(a + 1.0) < 0.000000000000001);
            Assert.AreEqual(b, a);
            Assert.AreEqual(c, 123456.12345678901234);
            Assert.AreNotEqual(c, true);
        }
    }
}
