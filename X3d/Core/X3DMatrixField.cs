namespace X3d.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// X3DMatrix3Field represents 3 x 3 matrix of X3DVec3Field
    /// </summary>
    public abstract class X3DMatrix3Field<TPrimitive> : X3DField
        where TPrimitive : X3DPrimitiveField, new()
    {
    }
}
