using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJDefaultArchitectureZeroTen
    {
        public static Boolean PropagateDebugDefault;

        static ConsoleLJDefaultArchitectureZeroTen()
        {
            PropagateDebugDefault = default(Boolean);

            return;
        }
    }
}

namespace Core
{
    using System;

    using System.Text;

    using System.Collections;

    public partial class ConsoleLJDefaultArchitectureOneFirst
    {
        public static String[] ArgumentArray;

        public static Boolean HasArgumentLengthDefault;

        public static Boolean HasLingerDefault;

        public static Boolean IsExternalCallDefault;

        public static ArrayList ArgumentListDefault;

        public static Boolean HasEscapeCharacterDefault;

        public static Char EscapeCharacterDefault;

        public static Boolean HasTerminatorCharacterDefault;

        public static Char TerminatorCharacterDefault;

        public static Boolean HasNativeStringDefault;

        public static String NativeStringDefault;

        public static Boolean HasSharedStringDefault;

        public static String SharedStringDefault;

        public static String InputDirectoryDefault;

        public static Boolean HasInputDirectoryDefault;

        public static Boolean HasValidInputDirectoryDefault;

        public static String OutputDirectoryDefault;

        public static Boolean HasOutputDirectoryDefault;

        public static Boolean HasValidOutputDirectoryDefault;

        public static StringBuilder AutoCommandStringBuilderDefault;

        static ConsoleLJDefaultArchitectureOneFirst()
        {
            ArgumentArray = default(String[]);

            HasArgumentLengthDefault = default(Boolean);

            HasLingerDefault = default(Boolean);

            IsExternalCallDefault = default(Boolean);

            ArgumentListDefault = default(ArrayList);

            HasEscapeCharacterDefault = default(Boolean);

            EscapeCharacterDefault = default(Char);

            HasTerminatorCharacterDefault = default(Boolean);

            TerminatorCharacterDefault = default(Char);

            HasNativeStringDefault = default(Boolean);

            NativeStringDefault = default(String);

            HasSharedStringDefault = default(Boolean);

            SharedStringDefault = default(String);

            InputDirectoryDefault = default(String);

            HasInputDirectoryDefault = default(Boolean);

            HasValidInputDirectoryDefault = default(Boolean);

            OutputDirectoryDefault = default(String);

            HasOutputDirectoryDefault = default(Boolean);

            HasValidOutputDirectoryDefault = default(Boolean);

            AutoCommandStringBuilderDefault = new StringBuilder("Auto Command" + ':' + '\n');

            return;
        }
    }
}

namespace Core
{
    using System;

    public partial class ConsoleLJDefaultArchitectureTwoSecond
    {
        public static ConsoleLJ ConsoleLJInstanceDefault;

        public static Boolean HasConsoleLJInstanceDefault;

        static ConsoleLJDefaultArchitectureTwoSecond()
        {
            ConsoleLJInstanceDefault = default(ConsoleLJ);

            HasConsoleLJInstanceDefault = default(Boolean);

            return;
        }
    }
}