using Core;

using Core.DimensionTwoSecond;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static void ProgramBindNameValueVoid(String name, String value)
        {
            String reflectString;

            reflectString = value;

            var reflect_CHARACTER = default(Char);

            try
            {
                reflect_CHARACTER = reflectString[0];
            }
            catch (Exception exception)
            {
                exception.ToString();
            }

            Boolean isEmptyCheck, isNotEmptyCheck;

            isEmptyCheck = reflectString.Equals(String.Empty) is true;

            isNotEmptyCheck = isEmptyCheck is false;

            switch (name)
            {
                case nameof(ArchitectureOneFirst.EscapeCharacter):
                    Specialize.SetEscapeCharacter(reflect_CHARACTER, isNotEmptyCheck);
                    break;

                case nameof(ArchitectureOneFirst.NativeString):
                    Specialize.SetNativeString(reflectString, isNotEmptyCheck);
                    break;

                case nameof(ArchitectureOneFirst.InputDirectory):
                    Specialize.SetInputDirectory(reflectString, isNotEmptyCheck);
                    break;

                case nameof(ArchitectureOneFirst.OutputDirectory):
                    Specialize.SetOutputDirectory(reflectString, isNotEmptyCheck);
                    break;

                case nameof(ArchitectureTwoSecond.ApplicationName):
                    ArchitectureTwoSecond.ApplicationName = reflectString;
                    break;

                case nameof(ArchitectureTwoSecond.ApplicationVersion):
                    ArchitectureTwoSecond.ApplicationVersion = reflectString;
                    break;

                case nameof(ArchitectureTwoSecond.ApplicationType):
                    Specialize.SetApplicationType(reflectString);
                    break;

                case nameof(ArchitectureTwoSecond.StudioType):
                    Specialize.SetStudioType(reflectString);
                    break;

                default:
                    break;
            }

            return;
        }
    }
}
