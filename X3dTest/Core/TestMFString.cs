namespace X3dTest.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using X3d.Core;

    [TestClass]
    public class TestMFString
    {
        [TestMethod]
        public void FromString()
        {
            var obj = new MFString();

            obj.FromString("\"Hi Alex, how are you?\" \"It's a beautiful day, isn't it?\" \"Web3D is a awesome technology.\"");

            Assert.IsTrue(obj.Count == 3);
            Assert.IsTrue(obj[0].Equals(new SFString("Hi Alex, how are you?")));
            Assert.IsTrue(obj[1].Equals(new SFString("It's a beautiful day, isn't it?")));
            Assert.IsTrue(obj[2].Equals(new SFString("Web3D is a awesome technology.")));
        }
    }
}
