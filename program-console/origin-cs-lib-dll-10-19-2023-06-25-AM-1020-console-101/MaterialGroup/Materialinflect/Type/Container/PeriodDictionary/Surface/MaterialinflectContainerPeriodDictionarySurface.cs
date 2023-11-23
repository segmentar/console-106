using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    public partial struct Materialinflect
    {
        public static T[] MaterialinflectPeriodDictionaryContainerSurface<T>(String HeaderString__VALUE)
        {
            T[] arrayResult = default;

            var list = MaterialinflectPeriodDictionaryContainer(HeaderString__VALUE);

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
