namespace X3dTest.Core
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using X3d.Core;

    [TestClass]
    public class TestAccessTypeNamesConverter
    {
        [TestMethod]
        public void TestToString()
        {
            AccessTypeNames a = AccessTypeNames.InitializeOnly;

            Assert.AreEqual(AccessTypeNamesConverter.ToString(a), "InitializeOnly");

            a = AccessTypeNames.InputOnly;
            Assert.AreEqual(AccessTypeNamesConverter.ToString(a), "InputOnly");

            a = AccessTypeNames.OutputOnly;
            Assert.AreEqual(AccessTypeNamesConverter.ToString(a), "OutputOnly");

            a = AccessTypeNames.InputOutput;
            Assert.AreEqual(AccessTypeNamesConverter.ToString(a), "InputOutput");

            try
            {
                a = (AccessTypeNames)100;
                var b = AccessTypeNamesConverter.ToString(a);

                Assert.Fail();
            }
            catch(FormatException)
            {
            }
        }

        [TestMethod]
        public void TestFromString()
        {
            Assert.IsTrue(AccessTypeNames.InitializeOnly == 
                          AccessTypeNamesConverter.FromString("InitializeOnly"));

            Assert.IsTrue(AccessTypeNames.InputOnly == 
                          AccessTypeNamesConverter.FromString("InputOnly"));

            Assert.IsTrue(AccessTypeNames.OutputOnly == 
                          AccessTypeNamesConverter.FromString("OutputOnly"));

            Assert.IsTrue(AccessTypeNames.InputOutput == 
                          AccessTypeNamesConverter.FromString("InputOutput"));

            try
            {
                var a = AccessTypeNamesConverter.FromString("I");
                Assert.Fail();
            }
            catch(FormatException)
            {
            }
        }
    }
}
