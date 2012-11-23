namespace X3d.Core
{
    using System;
    using System.Xml.Serialization;

    /// <summary>
    /// The SFColor field specifies one RGB (red-green-blue) color triple.
    /// Each color is written to the X3D file as an RGB triple of floating
    /// point numbers in the range 0.0 to 1.0. The default value of an
    /// uninitialized SFColor field is (0 0 0).
    /// </summary>
    [XmlType(TypeName = "SFColor")]
    public class SFColor : SFVec3f
    {
        public SFColor()
            : base(0.0f, 0.0f, 0.0f)
        {
        }

        public SFColor(SFFloat red, SFFloat green, SFFloat blue)
            : base(ValidateValueRange(red), ValidateValueRange(green), ValidateValueRange(blue))
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