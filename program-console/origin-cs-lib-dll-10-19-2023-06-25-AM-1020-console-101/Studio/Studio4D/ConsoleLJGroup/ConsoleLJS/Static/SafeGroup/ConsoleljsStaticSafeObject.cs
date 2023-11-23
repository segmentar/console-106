using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJS
    {
        public static String[] SafeObject(params Object[] array_OBJECT)
        {
            String[] arrayResult = default;

            var array = new String[array_OBJECT.Length];

            var indexer = 0;

            foreach (var item_OBJECT in array_OBJECT)
            {
                var entry_OBJECT = item_OBJECT.ToString();

                array[indexer] = entry_OBJECT;

                indexer = indexer + 1;

                continue;
            }

            arrayResult = array;

            return arrayResult;
        }
    }
}
