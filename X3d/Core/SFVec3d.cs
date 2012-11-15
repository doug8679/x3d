namespace X3d.Core
{
    /// <summary>
    /// The SFVec3d field or event specifies a three-dimensional (3D) vector. 
    /// SFVec3d's are represented as a 3-tuple of double-precision floating 
    /// point values. The default value of an uninitialized SFVec3d field 
    /// is (0 0 0).
    /// </summary>
    public class SFVec3d : X3DVec3Field<SFDouble>
    {
        public SFVec3d() : base(0, 0, 0)
        {
        }

        public SFVec3d(SFDouble x, SFDouble y, SFDouble z) : base(x, y, z)
        {
        }
    }
}
