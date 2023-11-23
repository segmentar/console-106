using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    public partial class ConsoleLJ
    {
        public static T[] ConsoleLJEndPointNameValueContainerSurface__NAME_VALUE<T>(String[] array__END_POINT)
        {
            T[] arrayResult = default;

            var list = ConsoleLJEndPointNameValueContainer__NAME_VALUE(array__END_POINT);

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
