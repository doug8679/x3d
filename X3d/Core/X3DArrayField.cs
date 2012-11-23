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

        #endregion
    }

    #region X3D Array Field Types

    [XmlType(TypeName = "MFBool")] 
    public class MFBool : X3DArrayField<SFBool> { }

    [XmlType(TypeName = "MFColor")] 
    public class MFColor : X3DArrayField<SFColor> { }

    [XmlType(TypeName = "MFColorRGBA")] 
    public class MFColorRGBA : X3DArrayField<SFColorRGBA> { }

    [XmlType(TypeName = "MFDouble")] 
    public class MFDouble : X3DArrayField<SFDouble> { }

    [XmlType(TypeName = "MFFloat")]
    public class MFFloat : X3DArrayField<SFFloat> { }

    [XmlType(TypeName = "MFImage")]
    public class MFImage : X3DArrayField<SFImage> { }

    [XmlType(TypeName = "MFInt32")]
    public class MFInt32 : X3DArrayField<SFInt32> { }

    [XmlType(TypeName = "MFMatrix3d")]
    public class MFMatrix3d : X3DArrayField<SFMatrix3d> { }

    [XmlType(TypeName = "MFMatrix3f")]
    public class MFMatrix3f : X3DArrayField<SFMatrix3f> { }

    [XmlType(TypeName = "MFMatrix4d")]
    public class MFMatrix4d : X3DArrayField<SFMatrix4d> { }

    [XmlType(TypeName = "MFMatrix4f")]
    public class MFMatrix4f : X3DArrayField<SFMatrix4f> { }

    [XmlType(TypeName = "MFNode")]
    public class MFNode : X3DArrayField<SFNode> { }

    [XmlType(TypeName = "MFRotation")]
    public class MFRotation : X3DArrayField<SFRotation> { }

    [XmlType(TypeName = "MFString")]
    public class MFString : X3DArrayField<SFString> { }

    [XmlType(TypeName = "MFTime")]
    public class MFTime : X3DArrayField<SFTime> { }

    [XmlType(TypeName = "MFVec2d")]
    public class MFVec2d : X3DArrayField<SFVec2d> { }

    [XmlType(TypeName = "MFVec2f")]
    public class MFVec2f : X3DArrayField<SFVec2f> { }

    [XmlType(TypeName = "MFVec3d")]
    public class MFVec3d : X3DArrayField<SFVec3d> { }

    [XmlType(TypeName = "MFVec3f")]
    public class MFVec3f : X3DArrayField<SFVec3f> { }

    [XmlType(TypeName = "MFVec4d")]
    public class MFVec4d : X3DArrayField<SFVec4d> { }

    [XmlType(TypeName = "MFVec4f")]
    public class MFVec4f : X3DArrayField<SFVec4f> { }

    #endregion
}
