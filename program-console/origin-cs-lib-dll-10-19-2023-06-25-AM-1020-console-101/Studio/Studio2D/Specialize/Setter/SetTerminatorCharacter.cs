using Core;

using Core.DimensionTwoSecondSecondaryII.ConsoleLJ;

namespace Core
{
    using System;

    public partial class SpecializeConsoleLJ
    {
        public static void SetTerminatorCharacter(Char terminatorCharacter, Boolean hasTerminatorCharacter)
        {
            ArchitectureConsoleLJOneFirst.TerminatorCharacter = terminatorCharacter;

            ArchitectureConsoleLJOneFirst.HasTerminatorCharacter = hasTerminatorCharacter;

            return;
        }
    }
}
