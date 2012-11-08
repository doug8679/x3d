namespace X3d.Core
{
    using System;

    /// <summary>
    /// X3DPrimitiveField is the abstract field type from which all primitive
    /// single values field types are derived. <see cref="SFBool"/>, 
    /// <see cref="SFDouble"/>, <see cref="SFFloat"/> and <see cref="SFInt32"/>
    /// are primitive data field types. 
    /// </summary>
    /// <typeparam name="TPrimitive">
    /// .NET Framework equivalant primitive data type
    /// </typeparam>
    public abstract class X3DPrimitiveField<TPrimitive> : X3DField
        where TPrimitive : struct, IComparable<TPrimitive>
    {
        protected TPrimitive Primitive { get; set; }

        #region Object Equality

        public override int GetHashCode()
        {
            return this.Primitive.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return (obj is X3DPrimitiveField<TPrimitive>) && this.Equals((X3DPrimitiveField<TPrimitive>)obj);
        }

        private bool Equals(X3DPrimitiveField<TPrimitive> obj)
        {
            return this.Primitive.Equals(obj.Primitive);
        }

        #endregion
    }
}
