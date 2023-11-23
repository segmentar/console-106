using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJS
    {
        public static String[] SafeArray(params Object[] array_OBJECT)
        {
            String[] arrayResult = default;

            var array = SafeObject(array_OBJECT);

            var indexer = 0;

            do
            {
                Boolean shouldBreakCheck;

                shouldBreakCheck = array.Length.Equals(indexer) is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                String stringItem;

                stringItem = array[indexer];

                array[indexer] = SafeString(stringItem);

                indexer = indexer + 1;

                continue;

            } while (true);

            arrayResult = array;

            return arrayResult;
        }
    }
}
