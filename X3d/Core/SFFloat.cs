namespace X3d.Core
{
    using System.Xml.Serialization;

    /// <summary>
    /// The SFFloat field specifies one single-precision floating point number.
    /// Implementation of these fields is targeted at the single precision
    /// floating point capabilities of processors. However, it is allowable to
    /// implement this field using fixed point numbering provided at least six
    /// decimal digits of precision are maintained and that exponents have
    /// range of at least [-12, 12] for both positive and negative numbers.
    /// The default value of an uninitialized SFFloat field is 0.0.
    /// </summary>
    [XmlType(TypeName = "SFFloat")]
    public class SFFloat : X3DPrimitiveField<float>
    {
        #region Constructors

        public SFFloat()
        {
            Primitive = 0.0f;
        }

        public SFFloat(float value)
        {
            Primitive = value;
        }

        public SFFloat(SFFloat obj)
        {
            Primitive = obj.Primitive;
        }

        #endregion Constructors

        #region Integer Compatibility

        public static implicit operator SFFloat(float value)
        {
            return new SFFloat { Primitive = value };
        }

        public static implicit operator float(SFFloat obj)
        {
            return obj.Primitive;
        }

        #endregion Integer Compatibility

        #region String Compatibility

        public override string ToString()
        {
            return Primitive.ToString("0.000000").TrimEnd('0').TrimEnd('.');
        }

        public override void FromString(string str)
        {
            this.Primitive = float.Parse(str);
        }

        #endregion String Compatibility
    }
}