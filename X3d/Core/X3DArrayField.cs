namespace X3d.Core
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    /// <summary>
    /// X3DArrayField is the abstract field type from which all field types that
    /// can contain multiple values are derived. All fields derived from 
    /// X3DArrayField have names beginning with MF. MFxxxx fields may zero or 
    /// more values, each of which shall be of the type indicated by the
    /// corresponding SFxxxx field type. It is illegal for any MFxxxx field 
    /// to mix values of different SFxxxx field types.
    /// </summary>
    public abstract class X3DArrayField<SingleField> : List<SingleField>
        where SingleField : X3DField, new()
    {
        #region String Compatibility

        public override string ToString()
        {
            return string.Join(", ", this);
        }

        public virtual void FromString(string str)
        {
            var delimiter = new char[] { ',' };
            this.FromString(str.Split(delimiter));
        }

        protected void FromString(string[] tokens)
        {
            this.Clear();

            foreach (var token in tokens)
            {
                var obj = new SingleField();
                obj.FromString(token);

                this.Add(obj);
            }
        }

        #endregion
    }

    #region X3D Array Field Types

    [XmlType(TypeName = "MFBool")] 
    public class MFBool : X3DArrayField<SFBool>
    {
        #region String Compatibility

        public override void FromString(string str)
        {
            var delimiter = new char[] { ',', ' ' };
            this.FromString(str.Split(delimiter));
        }

        public static implicit operator MFBool(string str)
        {
            var obj = new MFBool();

            obj.FromString(str);

            return obj;
        }

        public static implicit operator string(MFBool obj)
        {
            return obj.ToString();
        }

        #endregion
    }

    [XmlType(TypeName = "MFColor")] 
    public class MFColor : X3DArrayField<SFColor>
    {
        #region String Compatibility

        public static implicit operator MFColor(string str)
        {
            var obj = new MFColor();

            obj.FromString(str);

            return obj;
        }

        public static implicit operator string(MFColor obj)
        {
            return obj.ToString();
        }

        #endregion
    }

    [XmlType(TypeName = "MFColorRGBA")] 
    public class MFColorRGBA : X3DArrayField<SFColorRGBA>
    {
        #region String Compatibility

        public static implicit operator MFColorRGBA(string str)
        {
            var obj = new MFColorRGBA();

            obj.FromString(str);

            return obj;
        }

        public static implicit operator string(MFColorRGBA obj)
        {
            return obj.ToString();
        }

        #endregion
    }

    [XmlType(TypeName = "MFDouble")] 
    public class MFDouble : X3DArrayField<SFDouble>
    {
        #region String Compatibility

        public override void FromString(string str)
        {
            var delimiter = new char[] { ',', ' ' };
            this.FromString(str.Split(delimiter));
        }

        public static implicit operator MFDouble(string str)
        {
            var obj = new MFDouble();

            obj.FromString(str);

            return obj;
        }

        public static implicit operator string(MFDouble obj)
        {
            return obj.ToString();
        }

        #endregion
    }

    [XmlType(TypeName = "MFFloat")]
    public class MFFloat : X3DArrayField<SFFloat>
    {
        #region String Compatibility

        public override void FromString(string str)
        {
            var delimiter = new char[] { ',', ' ' };
            this.FromString(str.Split(delimiter));
        }

        public static implicit operator MFFloat(string str)
        {
            var obj = new MFFloat();

            obj.FromString(str);

            return obj;
        }

        public static implicit operator string(MFFloat obj)
        {
            return obj.ToString();
        }

        #endregion
    }

    [XmlType(TypeName = "MFImage")]
    public class MFImage : X3DArrayField<SFImage>
    {
        #region String Compatibility

        public static implicit operator MFImage(string str)
        {
            var obj = new MFImage();

            obj.FromString(str);

            return obj;
        }

        public static implicit operator string(MFImage obj)
        {
            return obj.ToString();
        }

        #endregion
    }

    [XmlType(TypeName = "MFInt32")]
    public class MFInt32 : X3DArrayField<SFInt32>
    {
        #region String Compatibility

        public override void FromString(string str)
        {
            var delimiter = new char[] { ',', ' ' };
            this.FromString(str.Split(delimiter));
        }

        public static implicit operator MFInt32(string str)
        {
            var obj = new MFInt32();

            obj.FromString(str);

            return obj;
        }

        public static implicit operator string(MFInt32 obj)
        {
            return obj.ToString();
        }

        #endregion
    }

    [XmlType(TypeName = "MFMatrix3d")]
    public class MFMatrix3d : X3DArrayField<SFMatrix3d>
    {
        #region String Compatibility

        public static implicit operator MFMatrix3d(string str)
        {
            var obj = new MFMatrix3d();

            obj.FromString(str);

            return obj;
        }

        public static implicit operator string(MFMatrix3d obj)
        {
            return obj.ToString();
        }

        #endregion
    }

    [XmlType(TypeName = "MFMatrix3f")]
    public class MFMatrix3f : X3DArrayField<SFMatrix3f>
    {
        #region String Compatibility

        public static implicit operator MFMatrix3f(string str)
        {
            var obj = new MFMatrix3f();

            obj.FromString(str);

            return obj;
        }

        public static implicit operator string(MFMatrix3f obj)
        {
            return obj.ToString();
        }

        #endregion
    }

    [XmlType(TypeName = "MFMatrix4d")]
    public class MFMatrix4d : X3DArrayField<SFMatrix4d>
    {
        #region String Compatibility

        public static implicit operator MFMatrix4d(string str)
        {
            var obj = new MFMatrix4d();

            obj.FromString(str);

            return obj;
        }

        public static implicit operator string(MFMatrix4d obj)
        {
            return obj.ToString();
        }

        #endregion
    }

    [XmlType(TypeName = "MFMatrix4f")]
    public class MFMatrix4f : X3DArrayField<SFMatrix4f>
    {
        #region String Compatibility

        public static implicit operator MFMatrix4f(string str)
        {
            var obj = new MFMatrix4f();

            obj.FromString(str);

            return obj;
        }

        public static implicit operator string(MFMatrix4f obj)
        {
            return obj.ToString();
        }

        #endregion
    }

    [XmlType(TypeName = "MFNode")]
    public class MFNode : X3DArrayField<SFNode>
    {
        #region String Compatibility

        public override void FromString(string str)
        {
            var delimiter = new char[] { ',', ' ' };
            this.FromString(str.Split(delimiter));
        }

        public static implicit operator MFNode(string str)
        {
            var obj = new MFNode();

            obj.FromString(str);

            return obj;
        }

        public static implicit operator string(MFNode obj)
        {
            return obj.ToString();
        }

        #endregion
    }

    [XmlType(TypeName = "MFRotation")]
    public class MFRotation : X3DArrayField<SFRotation>
    {
        #region String Compatibility

        public static implicit operator MFRotation(string str)
        {
            var obj = new MFRotation();

            obj.FromString(str);

            return obj;
        }

        public static implicit operator string(MFRotation obj)
        {
            return obj.ToString();
        }

        #endregion
    }

    [XmlType(TypeName = "MFString")]
    public class MFString : X3DArrayField<SFString>
    {
        #region String Compatibility

        public static implicit operator MFString(string str)
        {
            var obj = new MFString();

            obj.FromString(str);

            return obj;
        }

        public static implicit operator string(MFString obj)
        {
            return obj.ToString();
        }

        #endregion
    }

    [XmlType(TypeName = "MFTime")]
    public class MFTime : X3DArrayField<SFTime>
    {
        #region String Compatibility

        public override void FromString(string str)
        {
            var delimiter = new char[] { ',', ' ' };
            this.FromString(str.Split(delimiter));
        }

        public static implicit operator MFTime(string str)
        {
            var obj = new MFTime();

            obj.FromString(str);

            return obj;
        }

        public static implicit operator string(MFTime obj)
        {
            return obj.ToString();
        }

        #endregion
    }

    [XmlType(TypeName = "MFVec2d")]
    public class MFVec2d : X3DArrayField<SFVec2d>
    {
        #region String Compatibility

        public static implicit operator MFVec2d(string str)
        {
            var obj = new MFVec2d();

            obj.FromString(str);

            return obj;
        }

        public static implicit operator string(MFVec2d obj)
        {
            return obj.ToString();
        }

        #endregion
    }

    [XmlType(TypeName = "MFVec2f")]
    public class MFVec2f : X3DArrayField<SFVec2f>
    {
        #region String Compatibility

        public static implicit operator MFVec2f(string str)
        {
            var obj = new MFVec2f();

            obj.FromString(str);

            return obj;
        }

        public static implicit operator string(MFVec2f obj)
        {
            return obj.ToString();
        }

        #endregion
    }

    [XmlType(TypeName = "MFVec3d")]
    public class MFVec3d : X3DArrayField<SFVec3d>
    {
        #region String Compatibility

        public static implicit operator MFVec3d(string str)
        {
            var obj = new MFVec3d();

            obj.FromString(str);

            return obj;
        }

        public static implicit operator string(MFVec3d obj)
        {
            return obj.ToString();
        }

        #endregion
    }

    [XmlType(TypeName = "MFVec3f")]
    public class MFVec3f : X3DArrayField<SFVec3f>
    {
        #region String Compatibility

        public static implicit operator MFVec3f(string str)
        {
            var obj = new MFVec3f();

            obj.FromString(str);

            return obj;
        }

        public static implicit operator string(MFVec3f obj)
        {
            return obj.ToString();
        }

        #endregion
    }

    [XmlType(TypeName = "MFVec4d")]
    public class MFVec4d : X3DArrayField<SFVec4d>
    {
        #region String Compatibility

        public static implicit operator MFVec4d(string str)
        {
            var obj = new MFVec4d();

            obj.FromString(str);

            return obj;
        }

        public static implicit operator string(MFVec4d obj)
        {
            return obj.ToString();
        }

        #endregion
    }

    [XmlType(TypeName = "MFVec4f")]
    public class MFVec4f : X3DArrayField<SFVec4f>
    {
        #region String Compatibility

        public static implicit operator MFVec4f(string str)
        {
            var obj = new MFVec4f();

            obj.FromString(str);

            return obj;
        }

        public static implicit operator string(MFVec4f obj)
        {
            return obj.ToString();
        }

        #endregion
    }

    #endregion
}
