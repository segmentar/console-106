using Core;

using Core.DimensionThreeThird;

namespace Core
{
    using System;

    using System.Collections;

    internal partial class ProgramDefaultArchitectureOneFirst
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

        internal static String InputDirectoryDefault;

        internal static Boolean HasOutputDirectoryDefault;

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

    using System.Text;

    internal partial class ProgramDefaultArchitectureTwoSecond
    {
        internal static Boolean HasVirtualFilesystemDefault;

        internal static VirtualFilesystem VirtualFilesystemDefault;

        internal static String ApplicationNameDefault;

        internal static String ApplicationVersionDefault;

        internal static ProgramCode.ApplicationType ApplicationTypeDefault;

        internal static ProgramCode.StudioType StudioTypeDefault;

        internal static StringBuilder ClassStringBuilderDefault;

        internal static StringBuilder ModuleStringBuilgerDefault;

        internal static StringBuilder IconStringBuilderDefault;

        static ProgramDefaultArchitectureTwoSecond()
        {
            HasVirtualFilesystemDefault = default(Boolean);

            VirtualFilesystemDefault = default(VirtualFilesystem);

            ApplicationNameDefault = "Sample";

            ApplicationVersionDefault = "101";

            ApplicationTypeDefault = ProgramCode.ApplicationType.Unset;

            StudioTypeDefault = ProgramCode.StudioType.Unset;

            ClassStringBuilderDefault = new StringBuilder("Classification list" + ':');

            ModuleStringBuilgerDefault = new StringBuilder("Modulation list" + ':');

            IconStringBuilderDefault = new StringBuilder("Icon list" + ':');

            return;
        }
    }
}

namespace Core
{
    using System;

    using System.IO;

    using System.Reflection;

    internal partial class ProgramDefaultImmutableOneFirst
    {
        internal static String TitleDefault;

        internal static String ProgramNameDefault;

        internal static Random ProgramRandomDefault;

        internal static String SettingNameDefault;

        internal static String SettingExtensionDefault;

        internal static String WorkingDirectoryNameDefault;

        internal static String WorknigDirectoryIdentityDefault;

        static ProgramDefaultImmutableOneFirst()
        {
            TitleDefault = Assembly.GetExecutingAssembly().GetName().Name;

            ProgramNameDefault = Assembly.GetEntryAssembly().GetName().Name;

            ProgramRandomDefault = new Random(DateTime.Now.Millisecond);

            SettingNameDefault = "Setting";

            SettingExtensionDefault = "txt";

            WorkingDirectoryNameDefault = "Working Directory";

            WorknigDirectoryIdentityDefault = Path.GetRandomFileName();

            return;
        }
    }
}