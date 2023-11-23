using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    public partial struct ExpressionModuleWrite
    {
        public partial class ExpressionModuleFunctionTwenty
        {
            public static T[] FunctionRelateContainerSurface<T>(Tuple<Int32, Expression>[] array_TUPLE)
            {
                T[] arrayResult = default;

                var list = FunctionRelateContainer(array_TUPLE);

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
