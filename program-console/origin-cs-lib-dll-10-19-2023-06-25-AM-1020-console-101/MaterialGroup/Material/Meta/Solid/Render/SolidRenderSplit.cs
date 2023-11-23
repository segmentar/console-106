using Core;

namespace Core
{
    using System;

    internal partial class Material
    {
        internal static String[] SolidRenderSplit(String Path_VALUE)
        {
            String[] arrayResult = default;

            var Entity_UNDER_SCORE = Convert.ToChar(95);

            var separator = new Char[] { Entity_UNDER_SCORE };

            var split = Path_VALUE.Split(separator, StringSplitOptions.None);

            var array = split;

            arrayResult = array;

            return arrayResult;
        }
    }
}
