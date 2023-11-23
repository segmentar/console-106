using Core;

using Core.DimensionTwoSecond;

namespace Core
{
    using System;

    public partial class Interop
    {
        public static void Linf02IL()
        {
            if (ArchitectureOneFirst.HasLength is false)
            {
                return;
            }
            else
                "false".ToString();

            var roth = (Program.ArgumentArray.Length - 1);

            var eoth = Program.ArgumentArray[roth];

            var lower = eoth.ToLower();

            Boolean isLingerCheck, shouldReturn;

            isLingerCheck = lower.Equals("linger") is true;

            shouldReturn = isLingerCheck is false;

            if (shouldReturn is true)
            {
                return;
            }
            else
                "false".ToString();

            ArchitectureOneFirst.HasLinger = true;

            return;
        }
    }
}
