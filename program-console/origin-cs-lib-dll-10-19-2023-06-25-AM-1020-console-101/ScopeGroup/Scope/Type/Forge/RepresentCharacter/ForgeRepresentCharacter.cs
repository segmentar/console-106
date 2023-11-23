using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static Char ForgeRepresentCharacter(Char value_CHARACTER)
        {
            Char characterResult = default;

            var Entity_EMPTY = Convert.ToChar(0);

            Boolean isEmptyContagentCheck;

            isEmptyContagentCheck = value_CHARACTER.Equals(Entity_EMPTY) is true;

            Char character;

            if (isEmptyContagentCheck)
            {
                var Entity_WHITE_SPACE = Convert.ToChar(32);

                character = Entity_WHITE_SPACE;
            }
            else
            {
                character = value_CHARACTER;
            }

            characterResult = character;

            return characterResult;
        }
    }
}
