using Core;

namespace Core
{
    using System;

    public partial class Host
    {
        public static Char SolidCharacter(Char Character_VALUE)
        {
            Char characterResult = default;

            Char character;

            if (Char.IsControl(Character_VALUE))
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
