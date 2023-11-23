using Core;

namespace Core
{
    using System;

    internal partial class Material
    {
        internal static Char RepresentCharacter(Char Character_VALUE)
        {
            Char characterResult = default;

            var Entity_EMPTY = Convert.ToChar(0);

            Boolean isEmptyContagentCheck;

            isEmptyContagentCheck = Character_VALUE.Equals(Entity_EMPTY) is true;

            Char character;

            if (isEmptyContagentCheck)
            {
                var Entity_WHITE_SPACE = Convert.ToChar(32);

                character = Entity_WHITE_SPACE;
            }
            else
            {
                character = Character_VALUE;
            }

            characterResult = character;
            
            return characterResult;
        }
    }
}
