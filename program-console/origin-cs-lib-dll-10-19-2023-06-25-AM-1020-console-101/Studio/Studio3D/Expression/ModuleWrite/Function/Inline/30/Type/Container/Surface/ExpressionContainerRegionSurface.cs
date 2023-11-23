using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    public partial struct ExpressionModuleWrite
    {
        public partial class ExpressionModuleFunctionThirty
        {
            public static T[] FunctionRegionContainerSurface<T>(Tuple<Int32, Int32, Expression>[] array_TUPLE, Int32[] RegionStartAdress__ARRAY, Int32[] RegionEndAddress__ARRAY, Int32 ExpressionLength__ITEM)
            {
                T[] arrayResult = default;

                var list = FunctionRegionContainer(array_TUPLE, RegionStartAdress__ARRAY, RegionEndAddress__ARRAY, ExpressionLength__ITEM);

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
