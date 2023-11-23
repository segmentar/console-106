using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static Char[] SolidCharacterArray(Char[] array_CHARACTER)
        {
            Char[] arrayResult = default;

            var aoth = array_CHARACTER.Length;

            var array = new Char[aoth];

            var indexer = 0;

            do
            {
                Boolean shouldBreakCheck;

                shouldBreakCheck = aoth.Equals(indexer) is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                var item_CHARACTER = array_CHARACTER[indexer];

                var entry_CHARACTER = SolidCharacter(item_CHARACTER);

                array[indexer] = entry_CHARACTER;

                indexer = indexer + 1;

                continue;

            } while (true);

            arrayResult = array;

            return arrayResult;
        }
    }
}
