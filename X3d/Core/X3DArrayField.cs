namespace X3d.Core
{
    using System.Collections.Generic;

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

    public class MFBool : X3DArrayField<SFBool> { }
    public class MFColor : X3DArrayField<SFColor> { }
    public class MFColorRGBA : X3DArrayField<SFColorRGBA> { }
    public class MFDouble : X3DArrayField<SFDouble> { }
    public class MFFloat : X3DArrayField<SFFloat> { }
    public class MFImage : X3DArrayField<SFImage> { }
    public class MFInt32 : X3DArrayField<SFInt32> { }
    public class MFMatrix3d : X3DArrayField<SFMatrix3d> { }
    public class MFMatrix3f : X3DArrayField<SFMatrix3f> { }
    public class MFMatrix4d : X3DArrayField<SFMatrix4d> { }
    public class MFMatrix4f : X3DArrayField<SFMatrix4f> { }
    public class MFNode : X3DArrayField<SFNode> { }
    public class MFRotation : X3DArrayField<SFRotation> { }
    public class MFString : X3DArrayField<SFString> { }
    public class MFTime : X3DArrayField<SFTime> { }
    public class MFVec2d : X3DArrayField<SFVec2d> { }
    public class MFVec2f : X3DArrayField<SFVec2f> { }
    public class MFVec3d : X3DArrayField<SFVec3d> { }
    public class MFVec3f : X3DArrayField<SFVec3f> { }
    public class MFVec4d : X3DArrayField<SFVec4d> { }
    public class MFVec4f : X3DArrayField<SFVec4f> { }

    #endregion
}
