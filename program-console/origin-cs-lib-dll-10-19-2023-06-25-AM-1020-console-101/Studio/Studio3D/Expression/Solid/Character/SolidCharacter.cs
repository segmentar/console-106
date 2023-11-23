using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public static Char SolidCharacter(Char Character_ITEM)
        {
            Char characterResult = default;

            Char character;

            if (Char.IsControl(Character_ITEM))
            {
                var Entity_WHITE_SPACE = Convert.ToChar(32);

                character = Entity_WHITE_SPACE;
            }
            else
            {
                character = Character_ITEM;
            }

            characterResult = character;

            return characterResult;
        }
    }
}
