namespace X3d.Core
{
    /// <summary>
    /// The SFVec2d field specifies a two-dimensional (2D) vector. The default
    /// value of an uninitialized SFVec2d field is (0 0).
    /// </summary>
    public class SFVec2d : X3DVec2Field<SFDouble>
    {
        public SFVec2d() : base(0, 0)
        {
        }

        public SFVec2d(SFDouble x, SFDouble y) : base(x, y)
        {
        }
    }
}