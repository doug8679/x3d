namespace X3d.Core
{
    using System;

    /// <summary>
    /// The SFColorRGBA field specifies one RGBA (red-green-blue-alpha) color 
    /// quadruple that includes alpha (opacity) information. Each color is
    ///  written to the X3D file as an RGBA quadruple of floating point 
    /// numbers in the range 0.0 to 1.0. Alpha values range from 0.0 (fully 
    /// transparent) to 1.0 (fully opaque). The default value of an uninitialized
    /// SFColorRGBA field is (0 0 0 0).
    /// </summary>
    public class SFColorRGBA : SFVec4f
    {
        public SFColorRGBA() 
            : base(0, 0, 0, 0)
        {
        }

        public SFColorRGBA(SFFloat red, SFFloat green, SFFloat blue, SFFloat alpha)
            : base(ValidateValueRange(red), ValidateValueRange(green), ValidateValueRange(blue), ValidateValueRange(alpha))
        {
        }

        #region Color Component Properties

        public SFFloat Red
        {
            get
            {
                return this.X;
            }

            set
            {
                this.X = ValidateValueRange(value);
            }
        }

        public SFFloat Green
        {
            get
            {
                return this.Y;
            }

            set
            {
                this.Y = ValidateValueRange(value);
            }
        }

        public SFFloat Blue
        {
            get
            {
                return this.Z;
            }

            set
            {
                this.Z = ValidateValueRange(value);
            }
        }

        public SFFloat Alpha
        {
            get
            {
                return this.Homegeneous;
            }

            set
            {
                this.Homegeneous = ValidateValueRange(value);
            }
        }

        private static float ValidateValueRange(float value)
        {
            if (value < 0.0f || value > 1.0f)
            {
                throw new ArgumentOutOfRangeException(string.Format("SFColor Red component value range is from 0.0 to 1.0. Given value = {0}", value));
            }

            return value;
        }

        #endregion Color Component Properties
    }
}
