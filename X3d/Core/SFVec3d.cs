namespace X3d.Core
{
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
