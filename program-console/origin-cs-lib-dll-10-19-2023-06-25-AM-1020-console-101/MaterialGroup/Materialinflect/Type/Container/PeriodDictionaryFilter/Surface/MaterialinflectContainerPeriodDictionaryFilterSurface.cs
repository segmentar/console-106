using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    public partial struct Materialinflect
    {
        public static T[] MaterialinflectPeriodDictionaryFilterContainerSurface<T>(Tuple<Int32, String>[] PeriodDictionary__ARRAY, Int32 Filter_INTEGER)
        {
            T[] arrayResult = default;

            var list = MaterialinflectPeriodDictionaryFilterContainer(PeriodDictionary__ARRAY, Filter_INTEGER);

            IEnumerable enumerable;

            enumerable = list.OfType<T>().Cast<T>().ToArray();

            var reflect = (T[])(enumerable as Array);

            T[] array;

            array = reflect;

            arrayResult = array;

            return arrayResult;
        }
    }
}
