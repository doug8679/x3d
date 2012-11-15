namespace X3d.Core
{
    /// <summary>
    /// The SFVec4f field or event specifies a three-dimensional (3D) 
    /// homogeneous vector. SFVec4f's s are represented as a 4-tuple of 
    /// single-precision floating point values. The default value of an 
    /// uninitialized SFVec4f field is (0 0 0 1). 
    /// </summary>
    public class SFVec4f : X3DVec4Field<SFFloat>
    {
        public SFVec4f() : base(0, 0, 0, 1)
        {
        }

        public SFVec4f(SFFloat x, SFFloat y, SFFloat z, SFFloat h) : base(x, y, z, h)
        {
        }
    }
}
