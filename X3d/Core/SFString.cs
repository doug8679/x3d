namespace X3d.Core
{
    /// <summary>
    /// The SFString field contain strings encoded with the UTF-8 universal
    /// character set. Any characters (including linefeeds and '#') may appear
    /// within the string. The default value of an uninitialized SFString
    /// outputOnly field is the empty string.
    /// </summary>
    public class SFString : X3DField
    {
        #region Constructors

        public SFString()
        {
            this.Data = string.Empty;
        }

        public SFString(string data)
        {
            this.Data = data;
        }

        public SFString(SFString obj)
        {
            this.Data = obj.Data;
        }

        #endregion Constructors

        private string Data { get; set; }

        #region Object Equality

        public override int GetHashCode()
        {
            return this.Data.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if ((obj as SFString) != null)
            {
                return this.Data.Equals(((SFString)obj).Data);
            }

            return (obj as string) != null && this.Data.Equals(obj);
        }

        #endregion Object Equality

        #region String Compatibility

        public override string ToString()
        {
            return this.Data;
        }

        public override void FromString(string str)
        {
            this.Data = str;
        }

        public static implicit operator SFString(string obj)
        {
            if (obj == null)
            {
                return null;
            }
            else
            {
                return new SFString(obj);    
            }
        }

        public static implicit operator string(SFString obj)
        {
            if (obj == null)
            {
                return null;
            }
            else
            {
                return obj.Data;    
            }
        }

        #endregion String Compatibility
    }
}