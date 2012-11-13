namespace X3d.Core
{
    public class SFVec3f : X3DVec3Field<SFFloat>
    {
        public SFVec3f() : base(0, 0, 0)
        {
        }

        public SFVec3f(SFFloat x, SFFloat y, SFFloat z) : base(x, y, z)
        {
        }
    }
}
