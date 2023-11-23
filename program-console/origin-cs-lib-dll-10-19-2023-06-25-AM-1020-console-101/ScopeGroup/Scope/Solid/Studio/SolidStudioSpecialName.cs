using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static String StudioSpecialName(String Path_VALUE)
        {
            String stringResult = default;

            var Entity_DASH = Convert.ToChar(45);

            var Entity_UNDERSCORE = Convert.ToChar(95);

            var Splitseparator = new Char[] { Entity_DASH, Entity_UNDERSCORE };

            var split = Path_VALUE.Split(Splitseparator, StringSplitOptions.None);

            var Entity_BACK_SWASH = Convert.ToChar(92);

            var Joinseparator = Entity_BACK_SWASH.ToString();

            var join = String.Join(Joinseparator, split);

            var result = join;

            stringResult = result;

            return stringResult;
        }
    }
}
