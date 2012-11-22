namespace X3d.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// The SFMatrix3d field specifies a 3×3 matrix of double-precision floating
    /// point numbers. Each floating point number is represented in the X3D file
    /// as specified in the respective encoding. SFMatrix3d matrices are organized
    /// in row-major fashion. The first row of the matrix stores information for
    /// the x dimension, and the second for the  y dimension. Since these data 
    /// types are commonly used for transformation matrices, translation values are 
    /// stored in the third row. The default value of an uninitialized SFMatrix3d 
    /// field is the identity matrix [1 0 0 0 1 0 0 0 1].
    /// </summary>
    public class SFMatrix3d
    {
    }
}
