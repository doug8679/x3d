namespace X3d.Core
{
    using System;

    public enum AccessTypeNames
    {
        InitializeOnly,
        InputOnly,
        OutputOnly,
        InputOutput
    }

    public static class AccessTypeNamesConverter
    {
        public const string InitializeOnly = "InitializeOnly";

        public const string InputOnly = "InputOnly";

        public const string OutputOnly = "OutputOnly";

        public const string InputOutput = "InputOutput";

        public static string ToString(AccessTypeNames value)
        {
            switch (value)
            {
                case AccessTypeNames.InitializeOnly:
                    return InitializeOnly;
                case AccessTypeNames.InputOnly:
                    return InputOnly;
                case AccessTypeNames.OutputOnly:
                    return OutputOnly;
                case AccessTypeNames.InputOutput:
                    return InputOutput;
                default:
                    throw new FormatException();
            }
        }

        public static AccessTypeNames FromString(string value)
        {
            switch (value)
            {
                case InitializeOnly:
                    return AccessTypeNames.InitializeOnly;
                case InputOnly:
                    return AccessTypeNames.InputOnly;
                case OutputOnly:
                    return AccessTypeNames.OutputOnly;
                case InputOutput:
                    return AccessTypeNames.InputOutput;
                default:
                    throw new FormatException();
            }
        }
    }
}
