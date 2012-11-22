namespace X3d.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public enum SFImageComponentSize
    {
        Unknown = 0,
        Grayscale = 1,
        GrayscaleAlpha = 2,
        RGB = 3,
        RGBA = 4,
    }

    /// <summary>
    /// The SFImage field specifies a single uncompressed 2-dimensional pixel 
    /// image. SFImage fields contain three integers representing the width, 
    /// height and number of components in the image, followed by width × height
    /// hexadecimal or integer values representing the pixels in the image. 
    /// Pixel values are limited to 256 levels of intensity (i.e., 0-255 decimal
    /// or 0x00-0xFF hexadecimal). A one-component image specifies one-byte 
    /// hexadecimal or integer values representing the intensity of the image. 
    /// For example, 0xFF is full intensity in hexadecimal (255 in decimal), 
    /// 0x00 is no intensity (0 in decimal). A two-component image specifies 
    /// the intensity in the first (high) byte and the alpha opacity in the 
    /// second (low) byte. Pixels in a three-component image specify the red 
    /// component in the first (high) byte, followed by the green and blue 
    /// components (e.g., 0xFF0000 is red, 0x00FF00 is green, 0x0000FF is blue). 
    /// Four-component images specify the alpha opacity byte after red/green/blue
    /// (e.g., 0x0000FF80 is semi-transparent blue). A value of 0x00 is completely 
    /// transparent, 0xFF is completely opaque. Note that alpha equals 
    /// (1.0 - transparency), if alpha and transparency each range from 0.0 to 
    /// 1.0. Each pixel is read as a single unsigned number. For example, 
    /// a 3-component pixel with value 0x0000FF may also be written as 0xFF 
    /// (hexadecimal) or 255 (decimal). Pixels are specified from left to right, 
    /// bottom to top. The first hexadecimal value is the lower left pixel and 
    /// the last value is the upper right pixel. The default value of an SFImage
    /// outputOnly field is (0 0 0).
    /// </summary>
    public class SFImage : X3DField
    {
        #region Constructors

        public SFImage()
            : this(SFImageComponentSize.Unknown, 0, 0, null)
        {
        }

        /// <param name="componentSize">Component size</param>
        /// <param name="width">Image width</param>
        /// <param name="height">Image height</param>
        /// <param name="pixels">
        /// Pixels are represented as a 2D array. The first dimension represents
        /// the component type size and the second dimension contains pixel data.
        /// Note that the first element of the second dimension (intensity value)
        /// is XY(0,0) which is bottom left of the image not top left.
        /// </param>
        public SFImage(SFImageComponentSize componentSize, int width, int height, byte[,] pixels)
        {
            this.UpdateImage(componentSize, width, height, pixels);
        }

        #endregion

        #region Image Properties

        public SFImageComponentSize ComponentSize { get; private set; }

        public int Width { get; private set; }

        public int Height { get; private set; }

        public byte[,] Pixels { get; private set; }

        #endregion

        #region Image Data Management

        public void UpdateImage(SFImageComponentSize componentSize, int width, int height, byte[,] pixels)
        {
            this.ValidateImage(componentSize, width, height, pixels);

            this.ComponentSize = componentSize;
            this.Width = width;
            this.Height = height;
            this.Pixels = pixels;
        }

        private void ValidateImage(SFImageComponentSize componentSize, int width, int height, byte[,] pixels)
        {
            if (((int)componentSize != 0 && pixels == null)
             || ((int)componentSize != pixels.GetLength(0)))
            {
                throw new ArgumentException(string.Format("Component type and pixel data are mismatched. Component Format = {0} and Pixel Format = {1}", (int)componentSize, pixels.GetLength(0)));
            }
            else if ((width * height) != pixels.GetLength(1))
            {
                throw new ArgumentException(string.Format("Image size and pixel data size are mismatched. Component Format = {0} and Pixel Format = {1}", (int)componentSize, pixels.GetLength(0)));
            }
        }

        #endregion
    }
}