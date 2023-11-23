using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    public partial struct MaterialreflectPrimarymodule
    {
        public partial class FunctionTwenty
        {
            public static T[] FunctionTupleArrayContainerSurface<T>(String InputString__VALUE, Char[] EscapeCharacter__ARRAY)
            {
                T[] arrayResult = default;

                var list = FunctionTupleArrayContainer(InputString__VALUE, EscapeCharacter__ARRAY);

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
