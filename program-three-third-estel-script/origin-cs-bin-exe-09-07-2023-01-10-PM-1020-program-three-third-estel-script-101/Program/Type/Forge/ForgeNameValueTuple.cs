using Core;

using Core.DimensionTwoSecond;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static Tuple<String, Object>[] ForgeNameValueArray()
        {
            Tuple<String, Object>[] arrayResult = default;

            var array = new Tuple<String, Object>[] {

                new Tuple<String, Object>(nameof(ArchitectureOneFirst.PathBootstrapOneFirst), ArchitectureOneFirst.PathBootstrapOneFirst),
                new Tuple<String, Object>(nameof(ArchitectureOneFirst.PathBootstrapTwoSecond), ArchitectureOneFirst.PathBootstrapTwoSecond),
                new Tuple<String, Object>(nameof(ArchitectureOneFirst.PathProgramOneFirst), ArchitectureOneFirst.PathProgramOneFirst),
                new Tuple<String, Object>(nameof(ArchitectureOneFirst.PathProgramTwoSecond), ArchitectureOneFirst.PathProgramTwoSecond),
                new Tuple<String, Object>(nameof(ArchitectureOneFirst.InputPathProgramOneFirst), ArchitectureOneFirst.InputPathProgramOneFirst),
                new Tuple<String, Object>(nameof(ArchitectureOneFirst.InputPathProgramTwoSecond), ArchitectureOneFirst.InputPathProgramTwoSecond),
                new Tuple<String, Object>(nameof(ArchitectureOneFirst.OutputPathProgramOneFirst), ArchitectureOneFirst.OutputPathProgramOneFirst),
                new Tuple<String, Object>(nameof(ArchitectureOneFirst.OutputPathProgramTwoSecond), ArchitectureOneFirst.OutputPathProgramTwoSecond)
            };

            arrayResult = array;

            return arrayResult;
        }
    }
}
