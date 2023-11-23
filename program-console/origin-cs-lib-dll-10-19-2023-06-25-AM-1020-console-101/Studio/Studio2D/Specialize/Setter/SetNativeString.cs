using Core;

using Core.DimensionTwoSecondSecondaryII.ConsoleLJ;

namespace Core
{
    using System;

    public partial class SpecializeConsoleLJ
    {
        public static void SetNativeString(String nativeString, Boolean hasNativeString)
        {
            ArchitectureConsoleLJOneFirst.NativeString = nativeString;

            ArchitectureConsoleLJOneFirst.HasNativeString = hasNativeString;

            return;
        }
    }
}
