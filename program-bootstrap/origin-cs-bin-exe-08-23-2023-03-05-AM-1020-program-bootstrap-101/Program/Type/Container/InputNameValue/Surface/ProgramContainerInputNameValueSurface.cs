using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    internal partial class Program
    {
        internal static T[] ProgramInputNameValueContainerSurface__NAME_VALUE<T>(String[] array_SPLIT)
        {
            T[] arrayResult = default;

            var list = ProgramInputNameValueContainer__NAME_VALUE(array_SPLIT);

            IEnumerable enumerable;

            enumerable = list.OfType<T>().Cast<T>().ToArray();

            var reflect = (T[])(enumerable as Array);

            arrayResult = reflect;

            return arrayResult;
        }
    }
}
