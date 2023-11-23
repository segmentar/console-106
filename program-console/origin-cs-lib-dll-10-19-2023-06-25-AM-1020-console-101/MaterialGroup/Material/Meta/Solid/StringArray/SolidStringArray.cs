using Core;

namespace Core
{
    using System;

    internal partial class Material
    {
        public static String[] SolidStringArray(String[] String_ARRAY)
        {
            String[] arrayResult = default;

            var aoth = String_ARRAY.Length;

            var array = new String[aoth];

            var indexer = 0;

            while (true)
            {
                Boolean shouldBreakCheck;

                shouldBreakCheck = aoth.Equals(indexer) is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                var item_STRING = String_ARRAY[indexer];

                var entry_STRING = SolidString(item_STRING);

                array[indexer] = entry_STRING;

                indexer = indexer + 1;

                continue;
            }

            arrayResult = array;

            return arrayResult;
        }
    }
}
