namespace X3d.Core
{
    /// <summary>
    /// The SFTime field specifies a single time value. Time values are
    /// specified as a double-precision floating point number. The
    /// allowable form for a double precision floating point number
    /// is defined in the specific encoding. Time values are specified
    /// as the number of seconds from a specific time origin. Typically,
    /// SFTime fields represent the number of seconds since Jan 1, 1970,
    /// 00:00:00 GMT. The default value of an uninitialized SFTime field
    /// is -1.
    /// </summary>
    public class SFTime : SFDouble
    {
        #region Constructors

        public SFTime()
            : this(-1.0)
        {
        }

        public SFTime(double value)
        {
            this.Primitive = value;
        }

        public SFTime(SFTime obj)
        {
            this.Primitive = obj.Primitive;
        }

        #endregion Constructors
    }
}