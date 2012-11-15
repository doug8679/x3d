namespace X3d.Core
{
    /// <summary>
    /// X3DVec2Field represents the second dimensional vector data structure.
    /// </summary>
    /// <typeparam name="TPrimitive">Vector element type</typeparam>
    public abstract class X3DVec2Field<TPrimitive> : X3DField
        where TPrimitive : X3DPrimitiveField, new()
    {
        #region Constructors

        protected X3DVec2Field()
        {
            this.Elements = new TPrimitive[2];
        }

        protected X3DVec2Field(TPrimitive x, TPrimitive y) : this()
        {
            this.Elements[0] = x;
            this.Elements[1] = y;
        }

        #endregion

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

        #endregion

        #region Object Equality

        public override int GetHashCode()
        {
            return this.Elements.GetHashCode();
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

        #endregion

        #region String Compatibility

        public override string ToString()
        {
            return string.Format("{0} {1}", this.X.ToString(), this.Y.ToString());
        }

        #endregion

    }

    public abstract class X3DVec3Field<TPrimitive> : X3DVec2Field<TPrimitive>
        where TPrimitive : X3DPrimitiveField, new()
    {
        #region Constructors

        protected X3DVec3Field()
        {
            this.Elements = new TPrimitive[3];
        }

        protected X3DVec3Field(TPrimitive x, TPrimitive y, TPrimitive z) : this()
        {
            this.Elements[0] = x;
            this.Elements[1] = y;
            this.Elements[2] = z;
        }

        #endregion

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

        #endregion

        #region Object Equality

        public override int GetHashCode()
        {
            return this.Elements.GetHashCode();
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

        #endregion

        #region String Compatibility

        public override string ToString()
        {
            var x = this.X.ToString();
            var y = this.Y.ToString();
            var z = this.Z.ToString();

            return string.Format("{0} {1} {2}", 
                                 this.X.ToString(), 
                                 this.Y.ToString(),
                                 this.Z.ToString());
        }

        #endregion
    }

    public abstract class X3DVec4Field<TPrimitive> : X3DVec3Field<TPrimitive>
        where TPrimitive : X3DPrimitiveField, new()
    {
        #region Constructors

        protected X3DVec4Field()
        {
            this.Elements = new TPrimitive[4];
        }

        protected X3DVec4Field(TPrimitive x, TPrimitive y, TPrimitive z, TPrimitive h) : this()
        {
            this.Elements[0] = x;
            this.Elements[1] = y;
            this.Elements[2] = z;
            this.Elements[3] = h;
        }

        #endregion

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

        #endregion

        #region Object Equality

        public override int GetHashCode()
        {
            return this.Elements.GetHashCode();
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

        #endregion

        #region String Compatibility

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}",
                                 this.X.ToString(),
                                 this.Y.ToString(),
                                 this.Z.ToString(),
                                 this.Homegeneous.ToString());
        }

        #endregion
    }
}
