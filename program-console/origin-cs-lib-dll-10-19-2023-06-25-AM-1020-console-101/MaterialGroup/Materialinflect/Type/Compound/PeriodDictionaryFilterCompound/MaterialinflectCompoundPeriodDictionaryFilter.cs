using Core;

namespace Core
{
    using System;

    public partial struct Materialinflect
    {
        public static String[] MaterialinflectPeriodDictionaryFilterCompound(String HeaderString__VALUE, Int32 Filter_INTEGER)
        {
            String[] arrayResult = default;

            var PeriodDictionary__ARRAY = MaterialinflectPeriodDictionaryContainerSurface<Tuple<Int32, String>>(HeaderString__VALUE);

            var PeriodDictionaryFilter___ARRAY = MaterialinflectPeriodDictionaryFilterContainerSurface<Tuple<Int32, String>>(PeriodDictionary__ARRAY, Filter_INTEGER);

            var aoth = PeriodDictionaryFilter___ARRAY.Length;

            var array = new String[aoth];

            var indexer = 0;

            foreach (Tuple<Int32, String> PeriodDictionaryFilter___VALUE in PeriodDictionaryFilter___ARRAY)
            {
                var Value_ITEM = PeriodDictionaryFilter___VALUE.Item2;

                array[indexer] = Value_ITEM;

                indexer = indexer + 1;

                continue;
            }

            arrayResult = array;

            return arrayResult;
        }
    }
}
