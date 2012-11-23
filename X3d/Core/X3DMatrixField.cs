namespace X3d.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class X3DMatrixField<TPrimitive> : X3DField
        where TPrimitive : X3DPrimitiveField, new()
    {
        #region Matrix Element Accessors

        public TPrimitive[,] Elements { get; protected set; }

        #endregion

        #region Object Equality

        public override int GetHashCode()
        {
            var hash = this.Elements[0, 0].GetHashCode();

            for (var row = 0; row < this.Elements.GetLength(0); row++)
            {
                for (var col = 0; col < this.Elements.GetLength(1); col++)
                {
                    if (row == 0 && col == 0)
                    {
                        continue;
                    }

                    hash ^= this.Elements[row, col].GetHashCode();
                }
            }

            return hash;
        }

        public override bool Equals(object obj)
        {
            if (obj is X3DMatrixField<TPrimitive>)
            {
                var casted = (X3DMatrixField<TPrimitive>)obj;

                if (this.Elements.GetLength(0) == casted.Elements.GetLength(0))
                {
                    for (var row = 0; row < this.Elements.GetLength(0); row++)
                    {
                        for (var col = 0; col < this.Elements.GetLength(1); col++)
                        {
                            if (this.Elements[row, col] != casted.Elements[row, col])
                            {
                                return false;
                            }
                        }
                    }

                    return true;
                }
            }

            return false;
        }

        #endregion

        #region String Compatibility

        public override string ToString()
        {
            var builder = new StringBuilder();

            for (var row = 0; row < this.Elements.GetLength(0); row++)
            {
                for (var col = 0; col < this.Elements.GetLength(1); col++)
                {
                    builder.Append(this.Elements[row, col]);
                }
            }

            return builder.ToString();
        }

        #endregion
    }
}
