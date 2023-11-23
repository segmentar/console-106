using Core;

namespace Core
{
    using System;

    public partial class Specialize
    {
        public static void SetNativeString(String nativeString, Boolean hasNativeString)
        {
            ArchitecturePageOneFirst.NativeString = nativeString;

            ArchitecturePageOneFirst.HasNativeString = hasNativeString;

            return;
        }
    }
}
