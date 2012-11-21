namespace X3d.Core
{
    /// <summary>
    /// The SFVec4d field or event specifies a three-dimensional (3D)
    /// homogeneous vector. SFVec4d's s are represented as a 4-tuple of
    /// double-precision floating point values. The default value of an
    /// uninitialized SFVec4d field is (0 0 0 1).
    /// </summary>
    public class SFVec4d : X3DVec4Field<SFDouble>
    {
        public SFVec4d()
            : base(0, 0, 0, 1)
        {
        }

        public SFVec4d(SFDouble x, SFDouble y, SFDouble z, SFDouble h)
            : base(x, y, z, h)
        {
        }
    }
}