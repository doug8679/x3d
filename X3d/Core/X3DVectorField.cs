﻿namespace X3d.Core
{
    /// <summary>
    /// X3DVec2Field represents the second dimensional vector data structure.
    /// </summary>
    /// <typeparam name="TPrimitive">Vector element type</typeparam>
    public abstract class X3DVec2Field<TPrimitive> : X3DField
        where TPrimitive : X3DPrimitiveField, new()
    {
        protected readonly int[] HashTablePrimeNumbers = new int[] { 73856093, 19349663, 83492791, 39916801 };

        #region Constructors

        protected X3DVec2Field()
        {
            this.Elements = new TPrimitive[2];
        }

        protected X3DVec2Field(TPrimitive x, TPrimitive y)
            : this()
        {
            this.Elements[0] = x;
            this.Elements[1] = y;
        }

        #endregion Constructors

        #region Vector Element Accessors

        public TPrimitive[] Elements { get; set; }

        public TPrimitive X
        {
            get
            {
                return this.Elements[0];
            }
            set
            {
                this.Elements[0] = value;
            }
        }

        public TPrimitive Y
        {
            get
            {
                return this.Elements[1];
            }
            set
            {
                this.Elements[1] = value;
            }
        }

        #endregion Vector Element Accessors

        #region Object Equality

        public override int GetHashCode()
        {
            var xHash = this.X.GetHashCode() * HashTablePrimeNumbers[0];
            var yHash = this.Y.GetHashCode() * HashTablePrimeNumbers[1];

            return (xHash ^ yHash);
        }

        public override bool Equals(object obj)
        {
            if (obj is X3DVec2Field<TPrimitive>)
            {
                var casted = (X3DVec2Field<TPrimitive>)obj;

                return this.X.Equals(casted.X) && this.Y.Equals(casted.Y);
            }

            return false;
        }

        #endregion Object Equality

        #region String Compatibility

        public override string ToString()
        {
            return string.Format("{0} {1}", this.X, this.Y);
        }

        #endregion String Compatibility
    }

    public abstract class X3DVec3Field<TPrimitive> : X3DVec2Field<TPrimitive>
        where TPrimitive : X3DPrimitiveField, new()
    {
        #region Constructors

        protected X3DVec3Field()
        {
            this.Elements = new TPrimitive[3];
        }

        protected X3DVec3Field(TPrimitive x, TPrimitive y, TPrimitive z)
            : this()
        {
            this.Elements[0] = x;
            this.Elements[1] = y;
            this.Elements[2] = z;
        }

        #endregion Constructors

        #region Vector Element Accessors

        public TPrimitive Z
        {
            get
            {
                return this.Elements[2];
            }
            set
            {
                this.Elements[2] = value;
            }
        }

        #endregion Vector Element Accessors

        #region Object Equality

        public override int GetHashCode()
        {
            var zHash = this.Z.GetHashCode() * HashTablePrimeNumbers[2];

            return (base.GetHashCode() ^ zHash);
        }

        public override bool Equals(object obj)
        {
            if (obj is X3DVec3Field<TPrimitive>)
            {
                var casted = (X3DVec3Field<TPrimitive>)obj;

                return this.X.Equals(casted.X)
                    && this.Y.Equals(casted.Y)
                    && this.Z.Equals(casted.Z);
            }

            return false;
        }

        #endregion Object Equality

        #region String Compatibility

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.X, this.Y, this.Z);
        }

        #endregion String Compatibility
    }

    public abstract class X3DVec4Field<TPrimitive> : X3DVec3Field<TPrimitive>
        where TPrimitive : X3DPrimitiveField, new()
    {
        #region Constructors

        protected X3DVec4Field()
        {
            this.Elements = new TPrimitive[4];
        }

        protected X3DVec4Field(TPrimitive x, TPrimitive y, TPrimitive z, TPrimitive h)
            : this()
        {
            this.Elements[0] = x;
            this.Elements[1] = y;
            this.Elements[2] = z;
            this.Elements[3] = h;
        }

        #endregion Constructors

        #region Vector Element Accessors

        public TPrimitive Homegeneous
        {
            get
            {
                return this.Elements[3];
            }

            set
            {
                this.Elements[3] = value;
            }
        }

        #endregion Vector Element Accessors

        #region Object Equality

        public override int GetHashCode()
        {
            var hHash = this.Homegeneous.GetHashCode() * HashTablePrimeNumbers[3];

            return (base.GetHashCode() ^ hHash);
        }

        public override bool Equals(object obj)
        {
            if (obj is X3DVec4Field<TPrimitive>)
            {
                var casted = (X3DVec4Field<TPrimitive>)obj;

                return this.X.Equals(casted.X)
                    && this.Y.Equals(casted.Y)
                    && this.Z.Equals(casted.Z)
                    && this.Homegeneous.Equals(casted.Homegeneous);
            }

            return false;
        }

        #endregion Object Equality

        #region String Compatibility

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", this.X, this.Y, this.Z, this.Homegeneous);
        }

        #endregion String Compatibility
    }
}