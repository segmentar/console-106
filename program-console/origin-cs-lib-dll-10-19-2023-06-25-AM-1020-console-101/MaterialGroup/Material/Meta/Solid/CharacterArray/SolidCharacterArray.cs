using Core;

namespace Core
{
    using System;

    internal partial class Material
    {
        internal static Char[] SolidCharacterArray(Char[] array_CHARACTER)
        {
            Char[] arrayResult = default;

            var indexer = 0;

            do
            {
                Boolean shouldBreakCheck;

                shouldBreakCheck = array_CHARACTER.Length.Equals(indexer) is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                Char character;

                character = array_CHARACTER[indexer];

                var result = SolidCharacter(character);

                array_CHARACTER[indexer] = result;

                indexer = indexer + 1;

                continue;

            } while (true);

            var array = array_CHARACTER;

            arrayResult = array;

            return arrayResult;
        }
    }
}
