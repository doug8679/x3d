namespace X3d.Core
{
    public class SFVec4d : X3DVec4Field<SFDouble>
    {
        public SFVec4d() : base(0, 0, 0, 1)
        {
        }

        public SFVec4d(SFDouble x, SFDouble y, SFDouble z, SFDouble h) : base(x, y, z, h)
        {
        }
    }
}
