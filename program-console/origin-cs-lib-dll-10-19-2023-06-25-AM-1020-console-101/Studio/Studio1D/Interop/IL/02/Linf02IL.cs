using Core;

using Core.DimensionTwoSecondSecondaryII.Interop;

namespace Core
{
    using System;

    public partial class Interop
    {
        public static void Linf02IL()
        {
            if (InteropArchitecture.HasLength is false)
            {
                return;
            }
            else
                "false".ToString();

            var aoth = InteropArchitecture.ArgumentArray.Length;

            var roth = (aoth - 1);

            var eoth = InteropArchitecture.ArgumentArray[roth];

            var lower = eoth.ToLower();

            var Linger_ENTITY = "linger";

            Boolean isLingerCheck, shouldReturnCheck;

            isLingerCheck = lower.Equals(Linger_ENTITY) is true;

            shouldReturnCheck = isLingerCheck is false;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            InteropArchitecture.HasLinger = true;

            return;
        }
    }
}
