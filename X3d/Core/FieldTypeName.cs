namespace X3d.Core
{
    using System;

    public enum FieldTypeName
    {
        SFBool,
        MFBool,
        SFColor,
        MFColor,
        SFColorRGBA,
        MFColorRGBA,
        SFDouble,
        MFDouble,
        SFFloat,
        MFFloat,
        SFImage,
        MFImage,
        SFInt32,
        SFNode,
        MFNode,
        MFInt32,
        SFRotation,
        MFRotation,
        SFString,
        MFString,
        SFTime,
        MFTime,
        SFVec2d,
        MFVec2d,
        SFVec2f,
        MFVec2f,
        SFVec3d,
        MFVec3d,
        SFVec3f,
        MFVec3f,
        SFVec4d,
        MFVec4d,
        SFVec4f,
        MFVec4f,
        SFMatrix3d,
        MFMatrix3d,
        SFMatrix3f,
        MFMatrix3f,
        SFMatrix4d,
        MFMatrix4d,
        SFMatrix4f,
        MFMatrix4f,
    }

    public static class FieldTypeNameConverter
    {
        public static string ToString(FieldTypeName value)
        {
            return value.ToString();
        }

        public static FieldTypeName FromString(string value)
        {
            return (FieldTypeName)Enum.Parse(typeof(FieldTypeName), value);
        }
    }
}
