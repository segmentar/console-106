using Core;

namespace Core
{
    using System;

    public partial class Specialize
    {
        public static void SetEscapeCharacter(Char escapeCharacter, Boolean hasEscapeCharacter)
        {
            ArchitecturePageOneFirst.EscapeCharacter = escapeCharacter;

            ArchitecturePageOneFirst.HasEscapeCharacter = hasEscapeCharacter;

            return;
        }
    }
}
