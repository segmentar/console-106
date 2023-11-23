using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    public partial struct ExpressionModuleWrite
    {
        public partial class ExpressionModuleFunctionTen
        {
            public static T[] FunctionOrderContainerSurface<T>(Expression[] array_EXPRESSION)
            {
                T[] arrayResult = default;

                var list = FunctionOrderContainer(array_EXPRESSION);

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
