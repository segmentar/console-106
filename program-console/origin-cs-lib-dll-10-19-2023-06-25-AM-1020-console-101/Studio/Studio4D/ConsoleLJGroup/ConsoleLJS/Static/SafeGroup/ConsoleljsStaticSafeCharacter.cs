using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJS
    {
        public static Char SafeCharacter(Char item_CHARACTER)
        {
            Char characterResult = default;

            Char character;

            if (Char.IsControl(item_CHARACTER))
            {
                var entity_WHITE_SPACE = Convert.ToChar(32);

                character = entity_WHITE_SPACE;
            }
            else
            {
                character = item_CHARACTER;
            }

            characterResult = character;

            return characterResult;
        }
    }
}
