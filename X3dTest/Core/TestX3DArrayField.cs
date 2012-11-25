namespace X3dTest.Core
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using X3d.Core;

    [TestClass]
    public class TestX3DArrayField
    {
        [TestMethod]
        public void StringCompatibility()
        {
            var a = new MFBool();

            a.Add(false);
            a.Add(true);

            var str = a.ToString();

            Assert.AreEqual(str, "false, true");
        }
    }
}
