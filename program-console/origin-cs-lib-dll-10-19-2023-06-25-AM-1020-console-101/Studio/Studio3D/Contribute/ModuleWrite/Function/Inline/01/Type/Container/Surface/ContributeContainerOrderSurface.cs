using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    public partial struct ContributeModuleWriteInline
    {
        public partial class ModuleTen
        {
            public static T[] ContributeOrderContainerSurface<T>(Contribute[] array_CONTRIBUTE)
            {
                T[] arrayResult = default;

                var list = ContributeOrderContainer(array_CONTRIBUTE);

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
