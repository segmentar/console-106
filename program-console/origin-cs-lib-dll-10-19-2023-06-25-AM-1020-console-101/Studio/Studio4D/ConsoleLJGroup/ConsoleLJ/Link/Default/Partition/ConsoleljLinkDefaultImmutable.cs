using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Reflection;

    public partial class ConsoleLJDefaultImmutableZeroTen
    {
        public static String ProgramNameDefault;

        public static String ErrorMessageDefault;

        public static String NotationDirectoryDefault;

        public static String NotationBackDefault;

        public static String NotationFileDefault;

        public static String SettingNameDefault;

        public static String SettingExtensionDefault;

        public static String WorkingDirectoryNameDefault;

        public static String WorkingDirectoryIdentityDefault;

        public static String InputFileNameDefault;

        public static String InputExtensionDefault;

        public static String OutputFileNameDefault;

        public static String OutputExtensionDefault;

        static ConsoleLJDefaultImmutableZeroTen()
        {
            ProgramNameDefault = Assembly.GetEntryAssembly().GetName().Name;

            ErrorMessageDefault = "This object just so happened to be a default" + ' ' + '.' + ' ' + ":(";

            NotationDirectoryDefault = "...";

            NotationBackDefault = "..";

            NotationFileDefault = ".";

            SettingNameDefault = "Setting";

            SettingExtensionDefault = "txt";

            WorkingDirectoryNameDefault = "Working Directory";

            WorkingDirectoryIdentityDefault = Path.GetRandomFileName();

            InputFileNameDefault = "Input";

            InputExtensionDefault = "package";

            OutputFileNameDefault = "Output";

            OutputExtensionDefault = "package";

            return;
        }
    }
}