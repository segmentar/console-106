using Core;

namespace Core.DimensionTwoSecond
{
    using System;

    public static class ArchitectureOneFirst
    {
        public static String PathBootstrapOneFirst;

        public static String PathBootstrapTwoSecond;

        public static String PathProgramOneFirst;

        public static String PathProgramTwoSecond;

        public static String InputPathProgramOneFirst;

        public static String InputPathProgramTwoSecond;

        public static String OutputPathProgramOneFirst;

        public static String OutputPathProgramTwoSecond;

        static ArchitectureOneFirst()
        {
            PathBootstrapOneFirst = ProgramArchitectureDefaultPageOneFirst.PathBootstrapOneFirstDefault;

            PathBootstrapTwoSecond = ProgramArchitectureDefaultPageOneFirst.PathBootstrapTwoSecondDefault;

            PathProgramOneFirst = ProgramArchitectureDefaultPageOneFirst.PathToProgramOneFirstDefault;

            PathProgramTwoSecond = ProgramArchitectureDefaultPageOneFirst.PathToProgramTwoSecondDefault;

            InputPathProgramOneFirst = ProgramArchitectureDefaultPageOneFirst.InputPathProgramOneFirstDefault;

            InputPathProgramTwoSecond = ProgramArchitectureDefaultPageOneFirst.InputPathProgramTwoSecondDefault;

            OutputPathProgramOneFirst = ProgramArchitectureDefaultPageOneFirst.OutputPathProgramOneFirstDefault;

            OutputPathProgramTwoSecond = ProgramArchitectureDefaultPageOneFirst.OutputPathProgramTwoSecondDefault;

            return;
        }
    }
}
