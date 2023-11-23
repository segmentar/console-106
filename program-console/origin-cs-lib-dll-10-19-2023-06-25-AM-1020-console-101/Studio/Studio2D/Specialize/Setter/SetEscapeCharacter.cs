using Core;

using Core.DimensionTwoSecondSecondaryII.ConsoleLJ;

namespace Core
{
    using System;

    public partial class SpecializeConsoleLJ
    {
        public static void SetEscapeCharacter(Char escapeCharacter, Boolean hasEscapeCharacter)
        {
            ArchitectureConsoleLJOneFirst.EscapeCharacter = escapeCharacter;

            ArchitectureConsoleLJOneFirst.HasEscapeCharacter = hasEscapeCharacter;

            return;
        }
    }
}
