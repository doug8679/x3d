namespace X3d.Core
{
    /// <summary>
    /// The SFRotation field specifies one arbitrary rotation. An SFRotation is
    /// written to the X3D file as four floating point values. The allowable 
    /// form for a floating point number is defined in the specific encoding. 
    /// The first three values specify a normalized rotation axis vector about 
    /// which the rotation takes place. The fourth value specifies the amount 
    /// of right-handed rotation about that axis in radians.
    /// </summary>
    public class SFRotation : SFVec3f
    {
        #region Constructors

        public SFRotation()
            : this(0, 0, 1, 0)
        {
        }

        public SFRotation(SFFloat x, SFFloat y, SFFloat z, SFFloat angel)
            : base(x, y, z)
        {
            this.Angle = new SFFloat(angel);
        }

        #endregion

        public SFFloat Angle { get; set; }

        #region Object Equality

        public override int GetHashCode()
        {
            var angel = this.Angle.GetHashCode() * HashTablePrimeNumbers[3];

            return base.GetHashCode() ^ angel;
        }

        public override bool Equals(object obj)
        {
            if (obj is SFRotation)
            {
                var casted = (SFRotation)obj;

                return this.X.Equals(casted.X)
                    && this.Y.Equals(casted.Y)
                    && this.Z.Equals(casted.Z)
                    && this.Angle.Equals(casted.Angle);
            }

            return false;
        }

        #endregion

        #region String Compatibility

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", this.X, this.Y, this.Z, this.Angle);
        }

        #endregion
    }
}
