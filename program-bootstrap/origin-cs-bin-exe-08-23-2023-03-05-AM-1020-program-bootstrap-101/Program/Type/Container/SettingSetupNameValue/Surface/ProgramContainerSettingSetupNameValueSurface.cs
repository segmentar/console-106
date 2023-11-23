using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    internal partial class Program
    {
        internal static T[] ProgramSettingSetupContainerSurface__NAME_VALUE<T>(String item_TEXT)
        {
            T[] arrayResult = default;

            var list = ProgramSettingSetupContainer__NAME_VALUE(item_TEXT);

            IEnumerable enumerable;

            enumerable = list.OfType<T>().Cast<T>().ToArray();

            var reflect = (T[])(enumerable as Array);

            arrayResult = reflect;

            return arrayResult;
        }
    }
}
