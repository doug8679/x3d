namespace X3d.Core
{
    /// <summary>
    /// X3DVectorField is the abstract field type from which all vector value field types are derived.
    /// </summary>
    public abstract class X3DVectorField : X3DField
    {
    }

    /// <summary>
    /// X3DVec2Field represents the second dimensional vector data structure.
    /// </summary>
    /// <typeparam name="TPrimitive">Vector element type</typeparam>
    public abstract class X3DVec2Field<TPrimitive> : X3DVectorField
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
    }
}
