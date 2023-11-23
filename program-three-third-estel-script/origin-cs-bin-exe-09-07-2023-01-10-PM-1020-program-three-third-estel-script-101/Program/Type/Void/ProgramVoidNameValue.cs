using Core;

using Core.DimensionTwoSecond;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static void ProgramNameValueVoid(String name, String value)
        {
            String reflectString;

            reflectString = value;

            switch (name)
            {
                case nameof(ArchitectureOneFirst.PathBootstrapOneFirst):
                    ArchitectureOneFirst.PathBootstrapOneFirst = reflectString;
                    break;

                case nameof(ArchitectureOneFirst.PathProgramOneFirst):
                    ArchitectureOneFirst.PathProgramOneFirst = reflectString;
                    break;

                case nameof(ArchitectureOneFirst.PathProgramTwoSecond):
                    ArchitectureOneFirst.PathProgramTwoSecond = reflectString;
                    break;

                case nameof(ArchitectureOneFirst.InputPathProgramOneFirst):
                    ArchitectureOneFirst.InputPathProgramOneFirst = reflectString;
                    break;

                case nameof(ArchitectureOneFirst.InputPathProgramTwoSecond):
                    ArchitectureOneFirst.InputPathProgramTwoSecond = reflectString;
                    break;

                case nameof(ArchitectureOneFirst.OutputPathProgramOneFirst):
                    ArchitectureOneFirst.OutputPathProgramOneFirst = reflectString;
                    break;

                case nameof(ArchitectureOneFirst.OutputPathProgramTwoSecond):
                    ArchitectureOneFirst.OutputPathProgramTwoSecond = reflectString;
                    break;

                default:
                    break;
            }

            return;
        }
    }
}
