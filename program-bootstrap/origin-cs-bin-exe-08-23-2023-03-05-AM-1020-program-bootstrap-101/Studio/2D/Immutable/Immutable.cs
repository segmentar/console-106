using Core;

namespace Core.DimensionTwoSecond
{
    using System;

    internal static class ImmutableOneFirst
    {
        internal static readonly String Title;

        internal static readonly String ProgramName;

        internal static readonly Random ProgramRandom;

        internal static readonly String SettingName;

        internal static readonly String SettingExtension;

        internal static readonly String WorkingDirectoryName;

        internal static readonly String WorknigDirectoryIdentity;

        static ImmutableOneFirst()
        {
            Title = ProgramDefaultImmutableOneFirst.TitleDefault;

            ProgramName = ProgramDefaultImmutableOneFirst.ProgramNameDefault;

            ProgramRandom = ProgramDefaultImmutableOneFirst.ProgramRandomDefault;

            SettingName = ProgramDefaultImmutableOneFirst.SettingNameDefault;

            SettingExtension = ProgramDefaultImmutableOneFirst.SettingExtensionDefault;

            WorkingDirectoryName = ProgramDefaultImmutableOneFirst.WorkingDirectoryNameDefault;

            WorknigDirectoryIdentity = ProgramDefaultImmutableOneFirst.WorknigDirectoryIdentityDefault;

            return;
        }
    }
}
