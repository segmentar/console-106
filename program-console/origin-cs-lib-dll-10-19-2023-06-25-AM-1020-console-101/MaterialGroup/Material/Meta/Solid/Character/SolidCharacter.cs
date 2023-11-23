using Core;

namespace Core
{
    using System;

    internal partial class Material
    {
        internal static Char SolidCharacter(Char value_CHARACTER)
        {
            Char characterResult = default;

            Char character;

            if (Char.IsControl(value_CHARACTER))
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
