namespace X3d.Core
{
    using System.Xml.Serialization;

    /// <summary>
    /// The SFVec2f field specifies a two-dimensional (2D) vector. SFVec2f
    /// elements are represented as a pair of single-precision floating point
    /// values. The default value of an uninitialized SFVec2f field is (0 0).
    /// </summary>
    [XmlType(TypeName = "SFVec2f")]
    public class SFVec2f : X3DVec2Field<SFFloat>
    {
        public SFVec2f()
            : base(0, 0)
        {
        }

        public SFVec2f(SFFloat x, SFFloat y)
            : base(x, y)
        {
        }
    }
}