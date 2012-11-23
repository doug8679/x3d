namespace X3d.Core
{
    using System;

    /// <summary>
    /// The SFMatrix4f field specifies a 4x4 matrix of single-precision floating
    /// point numbers. Each floating point number is represented in the X3D file
    /// as specified in the respective encoding. SFMatrix4f matrices are
    /// organized in row-major fashion. The first row of the matrix stores
    /// information for the x dimension, the second for the y dimension, and
    /// the third for the z dimension. Since these data types are commonly used
    /// for transformation matrices, translation values are stored in the fourth
    /// row. The default value of an uninitialized SFMatrix4f field is the
    /// identity matrix [1 0 0 0 0 1 0 0 0 0 1 0 0 0 0 1].
    /// </summary>
    public class SFMatrix4f : X3DMatrixField<SFFloat>
    {
        public static readonly SFFloat[,] Identity = new SFFloat[,]
        {
            { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 }
        };

        #region Constructors

        public SFMatrix4f()
        {
            this.Elements = Identity;
        }

        public SFMatrix4f(SFFloat[,] elements)
            : this()
        {
            if (elements.GetLength(0) != 4 && elements.GetLength(1) != 4)
            {
                throw new ArgumentException(string.Format("Given matrix size is not 3 x 3. Matrix size = [{0} x {1}]", elements.GetLength(0), elements.GetLength(1)));
            }

            this.Elements = elements;
        }

        #endregion Constructors
    }
}