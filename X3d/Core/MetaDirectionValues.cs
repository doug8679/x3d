namespace X3d.Core
{
    using System;
    using System.Xml.Serialization;

    [XmlType(TypeName = "metaDirectionValues")]
    public enum MetaDirectionValues
    {
        [XmlEnum(Name = "rtl")]
        RightToLeft,

        [XmlEnum(Name = "ltr")]
        LeftToRight
    }

    public static class MetaDirectionValuesConverter
    {
        public static readonly string RightToLeftString = "rtl";
        public static readonly string LeftToRightString = "ltr";

        public static MetaDirectionValues? FromString(string str)
        {
            if (str == null)
            {
                return null;
            }

            if (str.Equals(RightToLeftString))
            {
                return MetaDirectionValues.RightToLeft;
            }
            else if (str.Equals(RightToLeftString))
            {
                return MetaDirectionValues.LeftToRight;
            }
            else
            {
                throw new FormatException(string.Format("Not a valid MetaDirectionValues string [{0}]", str));
            }
        }

        public static string ToString(MetaDirectionValues? value)
        {
            if (value == null)
            {
                return null;
            }

            switch (value)
            {
                case MetaDirectionValues.RightToLeft:
                    return RightToLeftString;

                case MetaDirectionValues.LeftToRight:
                    return LeftToRightString;

                default:
                    throw new FormatException(string.Format("Invalid enumeration value [{0}]", value));
            }
        }
    }
}
