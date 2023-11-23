using Core;

namespace Core
{
    using System;

    public partial class Virtualsolid
    {
        public static String[] SolidRenderSplit(String Path_VALUE)
        {
            String[] arrayResult = default;

            var Entity_UNDERSCORE = Convert.ToChar(95);

            var separator = new Char[] { Entity_UNDERSCORE };

            var split = Path_VALUE.Split(separator, StringSplitOptions.None);

            var array = split;

            arrayResult = array;

            return arrayResult;
        }
    }
}
