using Core;

namespace Core
{
    using System;

    internal static class Immutable
    {
        internal static String ProgramName;

        internal static String WorkingDirectoryName;

        internal static String WorkingDirectoryIdentity;

        internal static String SettingName;

        internal static String SettingExtension;

        static Immutable()
        {
            ProgramName = ProgramDefaultImmutablePageTwoSecond.ProgramNameDefault;

            WorkingDirectoryName = ProgramDefaultImmutablePageTwoSecond.WorkingDirectoryNameDefault;

            WorkingDirectoryIdentity = ProgramDefaultImmutablePageTwoSecond.WorkingDirectoryIdentityDefault;

            SettingName = ProgramDefaultImmutablePageTwoSecond.SettingNameDefault;

            SettingExtension = ProgramDefaultImmutablePageTwoSecond.SettingExtensionDefault;

            return;
        }
    }
}
