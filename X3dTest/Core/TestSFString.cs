namespace X3dTest.Core
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using X3d.Core;

    /// <summary>
    /// <see cref="X3d.Core.SFString"/> unit test cases
    /// </summary>
    [TestClass]
    public class TestSFString
    {
        [TestMethod]
        public void Constructor()
        {
            SFString a = "hello";
            var b = new SFString();
            var c = new SFString("hello");
            var d = new SFString(c);

            Assert.AreEqual(a, c);
            Assert.AreEqual(a, d);
            Assert.AreNotEqual(a, b);
        }

        [TestMethod]
        public void StringCompatibility()
        {
            SFString a = "X3D";
            var b = a;
            SFString c = b;

            Assert.IsTrue(a == b);
            Assert.IsTrue(b == c);
            Assert.IsTrue(c == a);
        }

        [TestMethod]
        public void Equality()
        {
            SFString a = "test";
            const int B = 0;

            Assert.AreEqual(a, a);
            Assert.AreNotEqual(a, B);
        }

        [TestMethod]
        public void StringConstruction()
        {
            SFString a = "hello";
            string b = a;

            Assert.AreEqual(a.ToString(), b);
            Assert.AreEqual(a, a.ToString());
        }

        [TestMethod]
        public void HashCode()
        {
            SFString a = "hello";
            SFString b = "hello";
            const string C = "hello";

            Assert.AreEqual(a.GetHashCode(), b.GetHashCode());
            Assert.AreEqual(a.GetHashCode(), C.GetHashCode());
            Assert.AreEqual(b.GetHashCode(), C.GetHashCode());
        }
    }
}