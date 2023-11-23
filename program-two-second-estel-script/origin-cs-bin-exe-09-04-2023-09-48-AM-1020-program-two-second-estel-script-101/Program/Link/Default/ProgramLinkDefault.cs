using Core;

namespace Core
{
    using System;

    using System.Collections;

    internal static class ProgramDefaultArchitectureOneFirst
    {
        internal static Boolean HasLengthDefault;

        internal static Boolean HasLingerDefault;

        internal static Boolean IsExternalCallDefault;

        internal static ArrayList ArgumentListDefault;

        internal static Boolean HasEscapeCharacterDefault;

        internal static Char EscapeCharacterDefault;

        internal static Boolean HasNativeStringDefault;

        internal static String NativeStringDefault;

        internal static Boolean HasInputDirectoryDefault;

        internal static Boolean HasOutputDirectoryDefault;

        internal static String InputDirectoryDefault;

        internal static String OutputDirectoryDefault;

        static ProgramDefaultArchitectureOneFirst()
        {
            HasLengthDefault = default(Boolean);

            HasLingerDefault = default(Boolean);

            IsExternalCallDefault = default(Boolean);

            ArgumentListDefault = default(ArrayList);

            HasEscapeCharacterDefault = default(Boolean);

            EscapeCharacterDefault = default(Char);

            HasNativeStringDefault = default(Boolean);

            NativeStringDefault = default(String);

            HasInputDirectoryDefault = default(Boolean);

            InputDirectoryDefault = default(String);

            HasOutputDirectoryDefault = default(Boolean);

            OutputDirectoryDefault = default(String);

            return;
        }
    }
}

namespace Core
{
    using System;

    using System.IO;

    using System.Reflection;

    internal static class ProgramDefaultImmutablePageTwoSecond
    {
        internal static String ProgramNameDefault;

        internal static String WorkingDirectoryNameDefault;

        internal static String WorkingDirectoryIdentityDefault;

        internal static String SettingNameDefault;

        internal static String SettingExtensionDefault;
    
        static ProgramDefaultImmutablePageTwoSecond()
        {
            SettingNameDefault = "Setting";

            SettingExtensionDefault = "txt";

            ProgramNameDefault = Assembly.GetEntryAssembly().GetName().Name;

            WorkingDirectoryNameDefault = "Working Directory";

            WorkingDirectoryIdentityDefault = Path.GetRandomFileName();

            return;
        }
    }
}