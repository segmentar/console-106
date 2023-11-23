using Core;

using Core.DimensionTwoSecond;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static String ForgeWorkingDirectoryName()
        {
            String stringResult = default;

            var path_NAME_working_directory = $"{ImmutableOneFirst.ProgramName}-{ImmutableOneFirst.WorkingDirectoryName}-{ImmutableOneFirst.WorknigDirectoryIdentity}";

            var whitespace = Convert.ToChar(32);

            var dash = Convert.ToChar(45);

            var replace = path_NAME_working_directory.Replace(whitespace, dash);

            var lower = replace.ToLower();

            var result = lower;

            stringResult = result;
            
            return stringResult;
        }
    }
}
