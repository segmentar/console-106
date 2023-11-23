using Core;

using Core.DimensionTwoSecondSecondaryII.ConsoleLJ;

namespace Core
{
    using System;

    public partial class SpecializeConsoleLJ
    {
        public static void SetSharedString(String sharedString, Boolean hasSharedString)
        {
            ArchitectureConsoleLJOneFirst.SharedString = sharedString;

            ArchitectureConsoleLJOneFirst.HasSharedString = hasSharedString;

            return;
        }
    }
}
