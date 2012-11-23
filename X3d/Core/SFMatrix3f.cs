namespace X3d.Core
{
    using System;

    /// <summary>
    /// The SFMatrix3f field specifies a 3×3 matrix of single-precision floating
    /// point numbers. Each floating point number is represented in the X3D file 
    /// as specified in the respective encoding. SFMatrix3f matrices are 
    /// organized in row-major fashion. The first row of the matrix stores 
    /// information for the x dimension, and the second for the y dimension. 
    /// Since these data types are commonly used for transformation matrices, 
    /// translation values are stored in the third row. The default value of an 
    /// uninitialized SFMatrix3f field is the identity matrix [1 0 0 0 1 0 0 0 1].
    /// </summary>
    public class SFMatrix3f : X3DMatrixField<SFFloat>
    {
        public static readonly SFMatrix3f Identity = new SFMatrix3f
        {
            Elements = new SFFloat[,] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } }
        };

        #region Constructors

        public SFMatrix3f()
        {
            this.Elements = Identity.Elements;
        }

        public SFMatrix3f(SFFloat[,] elements)
            : this()
        {
            if (elements.GetLength(0) != 3 && elements.GetLength(1) != 3)
            {
                throw new ArgumentException(string.Format("Given matrix size is not 3 x 3. Matrix size = [{0} x {1}]", elements.GetLength(0), elements.GetLength(1)));
            }

            this.Elements = elements;
        }

        #endregion
    }
}
