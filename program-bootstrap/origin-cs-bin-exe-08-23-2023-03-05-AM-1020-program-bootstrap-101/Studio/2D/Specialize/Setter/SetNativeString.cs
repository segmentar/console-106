using Core;

namespace Core.DimensionTwoSecond
{
    using System;

    public partial class Specialize
    {
        public static void SetNativeString(String nativeString, Boolean hasNativeString)
        {
            ArchitectureOneFirst.NativeString = nativeString;

            ArchitectureOneFirst.HasNativeString = hasNativeString;

            return;
        }
    }
}
