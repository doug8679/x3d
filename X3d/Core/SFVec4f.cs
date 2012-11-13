namespace X3d.Core
{
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
