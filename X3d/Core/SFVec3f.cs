namespace X3d.Core
{
    using System.Xml.Serialization;

    /// <summary>
    /// The SFVec3f field or event specifies a three-dimensional (3D) vector.
    /// SFVec3f's are represented as a 3-tuple of single-precision floating
    /// point values. The default value of an uninitialized SFVec3f field
    /// is (0 0 0).
    /// </summary>
    [XmlType(TypeName = "SFVec3f")]
    public class SFVec3f : X3DVec3Field<SFFloat>
    {
        public SFVec3f()
            : base(0, 0, 0)
        {
        }

        public SFVec3f(SFFloat x, SFFloat y, SFFloat z)
            : base(x, y, z)
        {
        }
    }
}