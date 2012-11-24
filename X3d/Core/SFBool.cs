namespace X3d.Core
{
    using System;
    using System.Xml.Serialization;

    /// <summary>
    /// The SFBool field specifies a single Boolean value. Each Boolean value
    /// represents either TRUE or FALSE. How these values are represented is
    /// encoding dependent.
    /// </summary>
    [XmlType(TypeName = "SFBool")]
    public class SFBool : X3DPrimitiveField<bool>
    {
        public static readonly string TrueString = "true";

        public static readonly string FalseString = "false";

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

        #endregion Constructors

        #region Boolean Compatibility

        public static implicit operator SFBool(bool value)
        {
            return new SFBool { Primitive = value };
        }

        public static implicit operator bool(SFBool obj)
        {
            return obj.Primitive;
        }

        #endregion Boolean Compatibility

        #region String Compatiblity

        public override string ToString()
        {
            return this.Primitive ? TrueString : FalseString;
        }

        public override void FromString(string str)
        {
            if (str.Equals(TrueString))
            {
                this.Primitive = true;
            }
            else if (str.Equals(FalseString))
            {
                this.Primitive = false;
            }
            else
            {
                throw new FormatException(string.Format("Invalid Boolean string [{0}]", str));
            }
        }

        #endregion
    }
}