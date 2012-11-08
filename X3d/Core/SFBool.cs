namespace X3d.Core
{
    /// <summary>
    /// The SFBool field specifies a single Boolean value. Each Boolean value 
    /// represents either TRUE or FALSE. How these values are represented is 
    /// encoding dependent.
    /// </summary>
    public class SFBool : X3DPrimitiveField<bool>
    {
        #region Constructors

        public SFBool()
        {
            this.Primitive = false;
        }
        
        public SFBool(bool value)
        {
            this.Primitive = value;
        }

        public SFBool(SFBool obj)
        {
            this.Primitive = obj.Primitive;
        }

        #endregion

        #region Boolean Compatibility

        public static implicit operator SFBool(bool value)
        {
            return new SFBool { Primitive = value };
        }

        public static implicit operator bool(SFBool obj)
        {
            return obj.Primitive;
        }

        #endregion
    }
}