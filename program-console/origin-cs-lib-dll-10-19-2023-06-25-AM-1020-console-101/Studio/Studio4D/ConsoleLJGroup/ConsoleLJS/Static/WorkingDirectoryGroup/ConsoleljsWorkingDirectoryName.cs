using Core;

using Core.DimensionTwoSecondSecondaryII.ConsoleLJ;

namespace Core
{
    using System;

    public partial class ConsoleLJS
    {
        public static String WorkingDirectoryName()
        {
            String stringResult = default;

            var name = $"{ImmutableConsoleLJZeroTen.ProgramName}-{ImmutableConsoleLJZeroTen.WorkingDirectoryName}-{ImmutableConsoleLJZeroTen.WorkingDirectoryIdentity}";

            var lower = name.ToLower();

            var split = lower.Split();

            var join = String.Join('-'.ToString(), split);

            stringResult = join;

            return stringResult;
        }
    }
}
