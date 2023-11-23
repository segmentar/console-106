using Core;

namespace Core.DimensionTwoSecond
{
    using System;

    public partial class Specialize
    {
        public static void SetEscapeCharacter(Char escapeCharacter, Boolean hasEscapeCharacter)
        {
            ArchitectureOneFirst.EscapeCharacter = escapeCharacter;

            ArchitectureOneFirst.HasEscapeCharacter = hasEscapeCharacter;

            return;
        }
    }
}
