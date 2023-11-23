using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    public partial struct ExpressionModuleWrite
    {
        public partial class ExpressionModuleFunctionFourty
        {
            public static T[] FunctionFlatContainerSurface<T>(Tuple<Int32, Int32, Int32, Int32, Expression>[] array_TUPLE)
            {
                T[] arrayResult = default;

                var list = FunctionFlatContainer(array_TUPLE);

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
