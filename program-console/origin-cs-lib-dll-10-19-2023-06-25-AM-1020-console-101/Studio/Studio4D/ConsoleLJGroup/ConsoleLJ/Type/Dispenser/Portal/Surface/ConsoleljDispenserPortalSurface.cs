using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class ConsoleLJ
    {
        public static String[] ConsoleLJPortalDispenserSurface(String[] array_SPLIT, Tuple<String, Object>[] array__NAME_VALUE)
        {
            String[] arrayResult = default;

            var list = new ArrayList(ConsoleLJPortalDispenser(array_SPLIT, array__NAME_VALUE));

            var reflect = (String[])(list.ToArray(typeof(String)) as Array);

            var array = reflect;

            arrayResult = array;

            return arrayResult;
        }
    }
}
