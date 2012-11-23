namespace X3d.Core
{
    /// <summary>
    /// The SFInt32 field specifies one 32-bit integer. The default value
    /// of an uninitialized SFInt32 field is 0.
    /// </summary>
    public class SFInt32 : X3DPrimitiveField<int>
    {
        #region Constructors

        public SFInt32()
        {
            this.Primitive = 0;
        }

        public SFInt32(int value)
        {
            this.Primitive = value;
        }

        public SFInt32(SFInt32 obj)
        {
            this.Primitive = obj.Primitive;
        }

        #endregion Constructors

        #region Integer Compatibility

        public static implicit operator SFInt32(int value)
        {
            return new SFInt32 { Primitive = value };
        }

        public static implicit operator int(SFInt32 obj)
        {
            return obj.Primitive;
        }

        #endregion Integer Compatibility
    }
}