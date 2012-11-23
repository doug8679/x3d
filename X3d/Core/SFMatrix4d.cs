using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace X3d.Core
{
    /// <summary>
    /// The SFMatrix4d field specifies a 4×4 matrix of double-precision floating
    /// point numbers. Each floating point number is represented in the X3D file
    /// as specified in the respective encoding. SFMatrix4d matrices are 
    /// organized in row-major fashion. The first row of the matrix stores 
    /// information for the x dimension, the second for the y dimension, and 
    /// the third for the z dimension. Since these data types are commonly used 
    /// for transformation matrices, translation values are stored in the fourth 
    /// row. The default value of an uninitialized SFMatrix4d field is the 
    /// identity matrix [1 0 0 0 0 1 0 0 0 0 1 0 0 0 0 1]. 
    /// </summary>
    public class SFMatrix4d : X3DMatrixField<SFDouble>
    {
        public static readonly SFDouble[,] Identity = new SFDouble[,]
        {
            { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 }
        };

        #region Constructors

        public SFMatrix4d()
        {
            this.Elements = Identity;
        }

        public SFMatrix4d(SFDouble[,] elements)
            : this()
        {
            if (elements.GetLength(0) != 4 && elements.GetLength(1) != 4)
            {
                throw new ArgumentException(string.Format("Given matrix size is not 3 x 3. Matrix size = [{0} x {1}]", elements.GetLength(0), elements.GetLength(1)));
            }

            this.Elements = elements;
        }

        #endregion
    }
}
