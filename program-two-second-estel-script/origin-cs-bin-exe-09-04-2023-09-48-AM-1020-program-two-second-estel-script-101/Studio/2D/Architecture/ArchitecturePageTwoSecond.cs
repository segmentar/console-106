using Core;

namespace Core
{
    using System;

    using System.Collections;

    internal static class ArchitecturePageOneFirst
    {
        internal static Boolean HasLength;

        internal static Boolean HasLinger;

        internal static Boolean IsExternalCall;

        internal static ArrayList ArgumentList;

        internal static Boolean HasEscapeCharacter;

        internal static Char EscapeCharacter;

        internal static Boolean HasNativeString;

        internal static String NativeString;

        internal static Boolean HasInputDirectory;

        internal static Boolean HasOutputDirectory;

        internal static String InputDirectory;

        internal static String OutputDirectory;

        static ArchitecturePageOneFirst()
        {
            HasLength = ProgramDefaultArchitectureOneFirst.HasLengthDefault;

            HasLinger = ProgramDefaultArchitectureOneFirst.HasLingerDefault;

            IsExternalCall = ProgramDefaultArchitectureOneFirst.IsExternalCallDefault;

            ArgumentList = ProgramDefaultArchitectureOneFirst.ArgumentListDefault;

            HasEscapeCharacter = ProgramDefaultArchitectureOneFirst.HasEscapeCharacterDefault;

            EscapeCharacter = ProgramDefaultArchitectureOneFirst.EscapeCharacterDefault;

            HasNativeString = ProgramDefaultArchitectureOneFirst.HasNativeStringDefault;

            NativeString = ProgramDefaultArchitectureOneFirst.NativeStringDefault;

            HasInputDirectory = ProgramDefaultArchitectureOneFirst.HasInputDirectoryDefault;

            InputDirectory = ProgramDefaultArchitectureOneFirst.InputDirectoryDefault;

            HasOutputDirectory = ProgramDefaultArchitectureOneFirst.HasOutputDirectoryDefault;

            OutputDirectory = ProgramDefaultArchitectureOneFirst.OutputDirectoryDefault;

            return;
        }
    }
}

namespace Core
{
    using System;

    using System.Text;

    internal static class ArchitecturePageTwoSecond
    {
        internal static String Extension;

        internal static Encoding StringCodec;

        static ArchitecturePageTwoSecond()
        {
            Extension = "sample";

            StringCodec = Encoding.Default;

            return;
        }
    }
}
