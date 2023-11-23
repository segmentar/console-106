using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    public partial struct MaterialreflectPrimarymodule
    {
        public partial class FunctionThirty
        {
            public static T[] FunctionTupleArrayContainerSurface<T>(Char[] array_CHARACTER, Tuple<Char, String[]>[] array_HOLE, Tuple<Char, String[]>[] array_BIND)
            {
                T[] arrayResult = default;

                var list = FunctionTupleArrayContainer(array_CHARACTER, array_HOLE, array_BIND);

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
