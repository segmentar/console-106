using Core;

using Core.DimensionThreeThird;

namespace Core.DimensionTwoSecond
{
    using System;

    using System.Collections;

    internal static class ArchitectureOneFirst
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

        internal static String InputDirectory;

        internal static Boolean HasOutputDirectory;

        internal static String OutputDirectory;

        static ArchitectureOneFirst()
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

namespace Core.DimensionTwoSecond
{
    using System;

    using System.Text;

    internal static class ArchitectureTwoSecond
    {
        internal static Boolean HasVirtualFilesystem;

        internal static VirtualFilesystem VirtualFilesystem;

        internal static String ApplicationName;

        internal static String ApplicationVersion;

        internal static ProgramCode.ApplicationType ApplicationType;

        internal static ProgramCode.StudioType StudioType;

        internal static StringBuilder ClassStringBuilder;

        internal static StringBuilder ModuleStringBuilger;

        internal static StringBuilder IconStringBuilder;

        static ArchitectureTwoSecond()
        {
            HasVirtualFilesystem = ProgramDefaultArchitectureTwoSecond.HasVirtualFilesystemDefault;

            VirtualFilesystem = ProgramDefaultArchitectureTwoSecond.VirtualFilesystemDefault;

            ApplicationName = ProgramDefaultArchitectureTwoSecond.ApplicationNameDefault;

            ApplicationVersion = ProgramDefaultArchitectureTwoSecond.ApplicationVersionDefault;

            ApplicationType = ProgramDefaultArchitectureTwoSecond.ApplicationTypeDefault;

            StudioType = ProgramDefaultArchitectureTwoSecond.StudioTypeDefault;

            ClassStringBuilder = ProgramDefaultArchitectureTwoSecond.ClassStringBuilderDefault;

            ModuleStringBuilger = ProgramDefaultArchitectureTwoSecond.ModuleStringBuilgerDefault;

            IconStringBuilder = ProgramDefaultArchitectureTwoSecond.IconStringBuilderDefault;
        }
    }
}