using Core;

using Core.DimensionTwoSecondSecondaryII.Interop;

namespace Core
{
    using System;

    public partial class Interop
    {
        public static void Lenf01IL()
        {
            Boolean hasLengthContagentCheck;

            hasLengthContagentCheck = InteropArchitecture.ArgumentArray.Length.Equals(0) is false;

            if (hasLengthContagentCheck)
            {
                InteropArchitecture.HasLength = true;
            }
            else
            {
                InteropArchitecture.HasLength = false;
            }

            return;
        }
    }
}
