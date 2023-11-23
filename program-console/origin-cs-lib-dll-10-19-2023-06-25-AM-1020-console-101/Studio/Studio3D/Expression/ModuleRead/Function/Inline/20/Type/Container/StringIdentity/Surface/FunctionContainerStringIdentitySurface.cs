using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Linq;

    using System.Collections;

    public partial struct ExpressionModuleRead
    {
        public partial class ExpressionModuleFunctionTwenty
        {
            public static T[] FunctionStringIdentityContainerSurface<T>(FileStream item__FILE_STREAM, Tuple<Int32, Int32, Int32> item_TUPLE)
            {
                T[] arrayResult = default;

                var list = FunctionStringIdentityContainer(item__FILE_STREAM, item_TUPLE);

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
