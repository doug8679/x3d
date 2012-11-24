namespace X3d.Core
{
    using System;
    using System.Xml.Serialization;

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
    [XmlType(TypeName = "SFMatrix3d")]
    public class SFMatrix3d : X3DMatrixField<SFDouble>
    {
        public static readonly SFDouble[,] Identity = new SFDouble[,]
        {
            { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 }
        };

        #region Constructors

        public SFMatrix3d()
        {
            this.Elements = Identity;
        }

        public SFMatrix3d(SFDouble[,] elements)
            : this()
        {
            if (elements.GetLength(0) != 3 && elements.GetLength(1) != 3)
            {
                throw new ArgumentException(string.Format("Given matrix size is not 3 x 3. Matrix size = [{0} x {1}]", elements.GetLength(0), elements.GetLength(1)));
            }

            this.Elements = elements;
        }

        #endregion Constructors
    }
}