using Core;

using Core.DimensionTwoSecondSecondaryII.ConsoleLJ;

namespace Core
{
    using System;

    public partial class Interop
    {
        public static void Chrf06IL()
        {
            if (ArchitectureConsoleLJOneFirst.HasLength is false)
            {
                return;
            }
            else
                "false".ToString();

            var oth_STRING = ArchitectureConsoleLJOneFirst.ArgumentArray[0];

            Boolean isLengthCheck, shouldReturn;

            isLengthCheck = oth_STRING.Length.Equals(1) is true;

            shouldReturn = isLengthCheck is false;

            if (shouldReturn is true)
            {
                return;
            }
            else
                "false".ToString();

            var oth_CHARACTER = oth_STRING[0];

            SpecializeConsoleLJ.SetEscapeCharacter(oth_CHARACTER, true);

            return;
        }
    }
}
