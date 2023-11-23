using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    public partial struct MaterialreflectSecondarymodule
    {
        public partial class FunctionTen
        {
            public static T[] FunctionDefaultContainerSurface<T>(Char[] Array_OPEN, Char[] Array_CLOSE)
            {
                T[] arrayResult = default;

                var list = FunctionDefaultContainer(Array_OPEN, Array_CLOSE);

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
}
