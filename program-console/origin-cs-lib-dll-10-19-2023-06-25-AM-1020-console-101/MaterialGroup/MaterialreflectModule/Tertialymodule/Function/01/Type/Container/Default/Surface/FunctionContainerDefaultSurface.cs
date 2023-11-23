using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    public partial struct MaterialreflectTertiarymodule
    {
        public partial class FunctionTen
        {
            public static T[] FunctionDefaultContainerSurface<T>(SecondarymoduleFunctionEightyPort[] array_FUNCTION)
            {
                T[] arrayResult = default;

                var list = FunctionDefaultContainer(array_FUNCTION);

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
