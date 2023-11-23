using Core;

namespace Core.DimensionTwoSecondSecondaryII.Interop
{
    using System;

    using System.Text;

    using System.Collections;

    public partial class InteropArchitecture
    {
        public static String[] ArgumentArray;

        public static Boolean HasLength;

        public static Boolean HasLinger;

        public static Boolean IsExternalCall;

        public static ArrayList ArgumentList;

        public static Boolean HasEscapeCharacter;

        public static Char EscapeCharacter;

        public static Boolean HasTerminatorCharacter;

        public static Char TerminatorCharacter;

        public static Boolean HasNativeString;

        public static String NativeString;

        public static Boolean HasSharedString;

        public static String SharedString;

        public static String InputDirectory;

        public static Boolean HasInputDirectory;

        public static Boolean HasValidInputDirectory;

        public static String OutputDirectory;

        public static Boolean HasOutputDirectory;

        public static Boolean HasValidOutputDirectory;

        public static String StudioDirectory;

        public static Boolean HasStudioDirectory;

        public static Boolean HasValidStudioDirectory;

        public static StringBuilder AutoCommandStringBuilder;

        static InteropArchitecture()
        {
            ArgumentArray = ConsoleLJDefaultArchitectureOneFirst.ArgumentArray;

            HasLength = ConsoleLJDefaultArchitectureOneFirst.HasArgumentLengthDefault;

            HasLinger = ConsoleLJDefaultArchitectureOneFirst.HasLingerDefault;

            IsExternalCall = ConsoleLJDefaultArchitectureOneFirst.IsExternalCallDefault;

            ArgumentList = ConsoleLJDefaultArchitectureOneFirst.ArgumentListDefault;

            HasEscapeCharacter = ConsoleLJDefaultArchitectureOneFirst.HasEscapeCharacterDefault;

            EscapeCharacter = ConsoleLJDefaultArchitectureOneFirst.EscapeCharacterDefault;

            HasTerminatorCharacter = ConsoleLJDefaultArchitectureOneFirst.HasTerminatorCharacterDefault;

            TerminatorCharacter = ConsoleLJDefaultArchitectureOneFirst.TerminatorCharacterDefault;

            HasNativeString = ConsoleLJDefaultArchitectureOneFirst.HasNativeStringDefault;

            NativeString = ConsoleLJDefaultArchitectureOneFirst.NativeStringDefault;

            HasSharedString = ConsoleLJDefaultArchitectureOneFirst.HasSharedStringDefault;

            SharedString = ConsoleLJDefaultArchitectureOneFirst.SharedStringDefault;

            InputDirectory = ConsoleLJDefaultArchitectureOneFirst.InputDirectoryDefault;

            HasInputDirectory = ConsoleLJDefaultArchitectureOneFirst.HasInputDirectoryDefault;

            HasValidInputDirectory = ConsoleLJDefaultArchitectureOneFirst.HasValidInputDirectoryDefault;

            OutputDirectory = ConsoleLJDefaultArchitectureOneFirst.OutputDirectoryDefault;

            HasOutputDirectory = ConsoleLJDefaultArchitectureOneFirst.HasOutputDirectoryDefault;

            HasValidOutputDirectory = ConsoleLJDefaultArchitectureOneFirst.HasValidOutputDirectoryDefault;

            AutoCommandStringBuilder = ConsoleLJDefaultArchitectureOneFirst.AutoCommandStringBuilderDefault;

            return;
        }
    }
}
