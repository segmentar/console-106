using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public static Char[] SolidCharacterArray(Char[] Character_ARRAY)
        {
            Char[] arrayResult = default;

            var indexer = 0;

            do
            {
                Boolean shouldBreakCheck;

                shouldBreakCheck = Character_ARRAY.Length.Equals(indexer) is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                var item_CHARACTER = Character_ARRAY[indexer];

                var entry_CHARACTER = SolidCharacter(item_CHARACTER);

                Character_ARRAY[indexer] = entry_CHARACTER;

                indexer = indexer + 1;

                continue;

            } while (true);

            arrayResult = Character_ARRAY;

            return arrayResult;
        }
    }
}
