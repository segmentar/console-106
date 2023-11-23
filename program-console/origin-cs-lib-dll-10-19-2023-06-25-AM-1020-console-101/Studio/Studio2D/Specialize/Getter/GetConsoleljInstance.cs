using Core;

using Core.DimensionTwoSecondSecondaryII.ConsoleLJ;

namespace Core
{
    using System;

    public partial class SpecializeConsoleLJ
    {
        public static ConsoleLJ GetConsoleLJInstance()
        {
            ConsoleLJ consoleLJResult = default;

            if (ArchitectureConsoleLJTwoSecond.HasConsoleLJInstance is false)
            {
                return consoleLJResult;
            }
            else
                "false".ToString();

            ConsoleLJ consoleLJ;

            consoleLJ = ArchitectureConsoleLJTwoSecond.ConsoleLJInstance;

            consoleLJResult = consoleLJ;

            return consoleLJResult;
        }
    }
}
