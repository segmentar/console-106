using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Linq;

    using System.Collections;

    public partial struct ExpressionModuleRead
    {
        public partial class ExpressionModuleFunctionFourty
        {
            public static T[] FunctionExpressionContainerSurface<T>(Tuple<Int32, Int32, Int32, Int32, String, Byte[]>[] array_TUPLE)
            {
                T[] arrayResult = default;

                var list = FunctionExpressionContainer(array_TUPLE);

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
