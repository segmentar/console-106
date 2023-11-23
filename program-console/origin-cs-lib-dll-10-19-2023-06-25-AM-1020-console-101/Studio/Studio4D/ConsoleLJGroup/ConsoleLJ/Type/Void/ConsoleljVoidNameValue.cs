using Core;

using Core.DimensionTwoSecondSecondaryII.ConsoleLJ;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public static void ConsoleLJNameValueVoid(String name, String value)
        {
            String reflectString;

            reflectString = value;

            Boolean isEmptyCheck, isNotEmptyCheck;

            isEmptyCheck = reflectString.Equals(String.Empty) is true;

            isNotEmptyCheck = isEmptyCheck is false;

            var reflect_CHARACTER = default(Char);

            try
            {
                var oth = reflectString[0];

                reflect_CHARACTER = oth;
            }
            catch (Exception exception)
            {
                exception.ToString();
            }

            switch (name)
            {
                case nameof(ArchitectureConsoleLJOneFirst.EscapeCharacter):
                    SpecializeConsoleLJ.SetEscapeCharacter(reflect_CHARACTER, isNotEmptyCheck);
                    break;

                case nameof(ArchitectureConsoleLJOneFirst.TerminatorCharacter):
                    SpecializeConsoleLJ.SetTerminatorCharacter(reflect_CHARACTER, isNotEmptyCheck);
                    break;

                case nameof(ArchitectureConsoleLJOneFirst.NativeString):
                    SpecializeConsoleLJ.SetNativeString(reflectString, isNotEmptyCheck);
                    break;

                case nameof(ArchitectureConsoleLJOneFirst.SharedString):
                    SpecializeConsoleLJ.SetNativeString(reflectString, isNotEmptyCheck);
                    break;

                case nameof(ArchitectureConsoleLJOneFirst.InputDirectory):
                    SpecializeConsoleLJ.SetInputDirectory(reflectString, isNotEmptyCheck);
                    break;

                case nameof(ArchitectureConsoleLJOneFirst.OutputDirectory):
                    SpecializeConsoleLJ.SetOutputDirectory(reflectString, isNotEmptyCheck);
                    break;

                default:
                    SpecializeConsoleLJ.ValueConsoleLJAddAutoCall(reflectString);
                    break;
            }

            return;
        }
    }
}
