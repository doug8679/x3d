namespace X3d.Core
{
    using System;

    public enum ProfileNames
    {
        Core,
        Interchange,
        CADInterchange,
        Interactive,
        Immersive,
        MPEG4Interactive,
        Full
    }

    public static class ProfileNamesConverter
    {
        public const string Core = "Core";

        public const string Interchange = "Interchange";

        public const string CADInterchange = "CADInterchange";

        public const string Interactive = "Interactive";

        public const string Immersive = "Immersive";

        public const string MPEG4Interactive = "MPEG4Interactive";

        public const string Full = "Full";

        public static string ToString(ProfileNames value)
        {
            switch (value)
            {
                case ProfileNames.Core:
                    return Core;
                case ProfileNames.Interchange:
                    return Interchange;
                case ProfileNames.CADInterchange:
                    return CADInterchange;
                case ProfileNames.Interactive:
                    return Interactive;
                case ProfileNames.Immersive:
                    return Immersive;
                case ProfileNames.MPEG4Interactive:
                    return MPEG4Interactive;
                case ProfileNames.Full:
                    return Full;
                default:
                    throw new FormatException(string.Format("Invalid enumeration value : [{0}]", value));
            }
        }

        public static ProfileNames FromString(string value)
        {
            switch (value)
            {
                case Core:
                    return ProfileNames.Core;
                case Interchange:
                    return ProfileNames.Interchange;
                case CADInterchange:
                    return ProfileNames.CADInterchange;
                case Interactive:
                    return ProfileNames.Interactive;
                case Immersive:
                    return ProfileNames.Immersive;
                case MPEG4Interactive:
                    return ProfileNames.MPEG4Interactive;
                case Full:
                    return ProfileNames.Full;
                default:
                    throw new FormatException(string.Format("Invalid enumeration value : [{0}]", value));
            }
        }
    }
}
