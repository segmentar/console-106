using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Linq;

    using System.Collections;

    public partial struct ExpressionModuleRead
    {
        public partial class ExpressionModuleFunctionThirty
        {
            public static T[] FunctionRegionContainerSurface<T>(FileStream item__FILE_STREAM, Tuple<Int32, Int32, Int32, Int32, String>[] array_TUPLE)
            {
                T[] arrayResult = default;

                var list = FunctionRegionContainer(item__FILE_STREAM, array_TUPLE);

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
