namespace X3d.Core
{
    using System;

    public enum X3DVersion
    {
        X3D_3_0,
        X3D_3_1,
        X3D_3_2
    }

    public static class X3DVersionConverter
    {
        public const string X3D_3_0 = "3.0";

        public const string X3D_3_1 = "3.1";

        public const string X3D_3_2 = "3.2";

        public static string ToString(X3DVersion value)
        {
            switch (value)
            {
                case X3DVersion.X3D_3_0:
                    return X3D_3_0;

                case X3DVersion.X3D_3_1:
                    return X3D_3_1;

                case X3DVersion.X3D_3_2:
                    return X3D_3_2;

                default:
                    throw new FormatException(string.Format("Invalid enumeration value : [{0}]", value));
            }
        }

        public static X3DVersion FromString(string value)
        {
            switch (value)
            {
                case X3D_3_0:
                    return X3DVersion.X3D_3_0;

                case X3D_3_1:
                    return X3DVersion.X3D_3_1;
                    
                case X3D_3_2:
                    return X3DVersion.X3D_3_2;

                default:
                    throw new FormatException(string.Format("Invalid string value : [{0}]", value));

            }
        }
    }
}
