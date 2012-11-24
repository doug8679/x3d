namespace X3dTest.Core
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using X3d.Core;

    /// <summary>
    /// <see cref="X3d.Core.Component" /> unit test cases
    /// </summary>
    [TestClass]
    public class TestComponent
    {
        [TestMethod]
        public void Level()
        {
            var obj = new Component(ComponentNames.Core, 1);

            obj.Level = 1;
            Assert.AreEqual(obj.Level, 1);

            obj.Level = 2;
            Assert.AreEqual(obj.Level, 2);

            obj.Level = 3;
            Assert.AreEqual(obj.Level, 3);

            obj.Level = 4;
            Assert.AreEqual(obj.Level, 4);

            obj.Level = 5;
            Assert.AreEqual(obj.Level, 5);

            try
            {
                obj.Level = 0;
                Assert.Fail();
            }
            catch (ArgumentException)
            {
            }

            try
            {
                obj.Level = 6;
                Assert.Fail();
            }
            catch (ArgumentException)
            {
            }
        }
    }
}
