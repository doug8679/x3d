namespace X3d.Core
{
    /// <summary>
    /// X3DPrimitiveField is the abstract field type from which all primitive
    /// single values field types are derived. <see cref="SFBool" />,
    /// <see cref="SFDouble" />, <see cref="SFFloat" /> and <see cref="SFInt32" />
    /// are primitive data field types.
    /// </summary>
    /// <typeparam name="TPrimitive">.NET Framework equivalant primitive data type</typeparam>
    public abstract class X3DPrimitiveField<TPrimitive> : X3DField
        where TPrimitive : struct
    {
        protected TPrimitive Primitive { get; set; }

        #region Object Equality

        public override int GetHashCode()
        {
            return this.Primitive.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is X3DPrimitiveField<TPrimitive>)
            {
                return this.Primitive.Equals(((X3DPrimitiveField<TPrimitive>)obj).Primitive);
            }
            else if (obj is TPrimitive)
            {
                return this.Primitive.Equals((TPrimitive)obj);
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region String Compatibility

        public override string ToString()
        {
            return this.Primitive.ToString();
        }

        #endregion
    }
}