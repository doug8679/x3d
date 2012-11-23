namespace X3d.Core
{
    /// <summary>
    /// The SFDouble field specifies one double-precision floating point number.
    /// Implementation of these fields is targeted at the double precision
    /// floating point capabilities of processors. However, it is allowable to
    /// implement this field using fixed point numbering provided at least 14
    /// decimal digits of precision are maintained and that exponents have
    /// range of at least [-12, 12] for both positive and negative numbers.
    /// The default value of an uninitialized SFDouble field is 0.0.
    /// </summary>
    public class SFDouble : X3DPrimitiveField<double>
    {
        #region Constructors

        public SFDouble()
            : this(0.0)
        {
        }

        public SFDouble(double value)
        {
            this.Primitive = value;
        }

        public SFDouble(SFDouble obj)
        {
            this.Primitive = obj.Primitive;
        }

        #endregion Constructors

        #region Double Compatibility

        public static implicit operator SFDouble(double value)
        {
            return new SFDouble { Primitive = value };
        }

        public static implicit operator double(SFDouble obj)
        {
            return obj.Primitive;
        }

        #endregion Double Compatibility

        #region String Compatibility

        public override string ToString()
        {
            return this.Primitive.ToString("0.000000000000").TrimEnd('0').TrimEnd('.');
        }

        #endregion String Compatibility
    }
}