namespace X3dTest.Core
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using X3d.Core;

    /// <summary>
    /// <see cref="X3d.Core.SFImage" /> unit test cases
    /// </summary>
    [TestClass]
    public class TestSFImage
    {
        #region Test Image Generation

        private static SFImage GenerateTestImage(SFImageComponentSize size)
        {
            if (size == SFImageComponentSize.Unknown)
            {
                return new SFImage();
            }

            const int width = 100;
            const int height = 100;
            var components = (int)size;
            var pixels = new byte[components, (width * height)];

            for (var component = 0; component < components; component++)
            {
                for (var pos = 0; pos < (width * height); pos++)
                {
                    pixels[component, pos] = (byte)(pos % 255);
                }
            }

            return new SFImage(size, width, height, pixels);
        }

        #endregion

        [TestMethod]
        public void Constructor()
        {
            var image1 = new SFImage();

            Assert.AreEqual(image1.ComponentSize, SFImageComponentSize.Unknown);
            Assert.AreEqual(image1.Width, 0);
            Assert.AreEqual(image1.Height, 0);
            Assert.AreEqual(image1.Pixels, null);

            var image2 = GenerateTestImage(SFImageComponentSize.Grayscale);

            Assert.AreEqual(image2.ComponentSize, SFImageComponentSize.Grayscale);
            Assert.AreEqual(image2.Width, 100);
            Assert.AreEqual(image2.Height, 100);
            Assert.IsTrue(image2.Pixels != null);
        }

        [TestMethod]
        public void ValidateImage()
        {
            try
            {
                var pixels = new byte[,] { { 1, 2, 3, 4 } };
                new SFImage(SFImageComponentSize.Unknown, 2, 2, pixels);
                Assert.Fail();
            }
            catch (ArgumentException)
            {
            }

            try
            {
                new SFImage(SFImageComponentSize.Grayscale, 2, 2, null);
                Assert.Fail();
            }
            catch (ArgumentException)
            {
            }

            try
            {
                var pixels = new byte[,] { { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };
                new SFImage(SFImageComponentSize.Grayscale, 2, 2, pixels);
                Assert.Fail();
            }
            catch (ArgumentException)
            {
            }

            try
            {
                var pixels = new byte[,] { { 1, 2, 3, 4 } };
                new SFImage(SFImageComponentSize.Grayscale, 4, 4, pixels);
                Assert.Fail();
            }
            catch (ArgumentException)
            {
            }
        }

        [TestMethod]
        public void TestToString()
        {
            var image1 = new SFImage();

            Assert.AreEqual(image1.ToString(), "0 0 0");

            var pixels = new byte[,] { { 0xFF } };
            image1 = new SFImage(SFImageComponentSize.Grayscale, 1, 1, pixels);

            var str = image1.ToString();

            Assert.AreEqual(str, "1 1 1 0xFF");

            pixels = new byte[,] { { 0xFF }, { 0xFF } };
            image1 = new SFImage(SFImageComponentSize.GrayscaleAlpha, 1, 1, pixels);

            Assert.AreEqual(image1.ToString(), "2 1 1 0xFFFF");

            pixels = new byte[,] { { 0xFF, 0xAA }, { 0xFF, 0xAA }, { 0xFF, 0xAA } };
            image1 = new SFImage(SFImageComponentSize.RGB, 1, 2, pixels);

            Assert.AreEqual(image1.ToString(), "3 1 2 0xFFFFFF 0xAAAAAA");

            pixels = new byte[,] { { 0xFF, 0xAA }, { 0xFF, 0xAA }, { 0xFF, 0xAA }, { 0xFF, 0xAA } };
            image1 = new SFImage(SFImageComponentSize.RGBA, 2, 1, pixels);

            Assert.AreEqual(image1.ToString(), "4 2 1 0xFFFFFFFF 0xAAAAAAAA");
        }
    }
}
