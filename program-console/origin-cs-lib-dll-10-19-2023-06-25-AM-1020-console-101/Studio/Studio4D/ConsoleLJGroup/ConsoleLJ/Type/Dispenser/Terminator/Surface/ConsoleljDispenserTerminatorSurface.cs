using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class ConsoleLJ
    {
        public static String[] ConsoleLJTerminatorDispenserSurface(String[] array_SPLIT)
        {
            String[] arrayResult = default;

            var list = new ArrayList(ConsoleLJTerminatorDispenser(array_SPLIT));

            var reflect = (String[])(list.ToArray(typeof(String)) as Array);

            var array = reflect;

            arrayResult = array;

            return arrayResult;
        }
    }
}
