using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    public partial struct MaterialreflectSecondarymodule
    {
        public partial class FunctionFifty
        {
            public static T[] FunctionLayerContainerSurface<T>(FunctionFourty[] FunctionSeventy__ARRAY)
            {
                T[] arrayResult = default;

                var list = FunctionLayerContainer(FunctionSeventy__ARRAY);

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
