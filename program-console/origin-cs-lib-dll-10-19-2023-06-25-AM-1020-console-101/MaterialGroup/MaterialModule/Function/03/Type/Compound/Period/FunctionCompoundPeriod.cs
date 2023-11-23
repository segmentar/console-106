using Core;

namespace Core
{
    using System;

    public partial struct MaterialModule
    {
        public static String[] FunctionPeriodCompound(Tuple<Int32, String>[] array_TUPLE)
        {
            String[] arrayResult = default;

            var aoth = array_TUPLE.Length;

            var array = new String[aoth];

            var indexer = 0;

            foreach (Tuple<Int32, String> value_TUPLE in array_TUPLE)
            {
                var Value_ITEM = value_TUPLE.Item2;

                array[indexer] = Value_ITEM;

                indexer = indexer + 1;

                continue;
            }

            arrayResult = array;

            return arrayResult;
        }
    }
}
