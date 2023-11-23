using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public static String ForgeDashfulFormat(String String_VALUE)
        {
            String stringResult = default;

            var Entity_UNDER_SCORE = Convert.ToChar(95);

            var format = String_VALUE.Trim(Entity_UNDER_SCORE);

            var Entity_WHITE_SPACE = Convert.ToChar(32);

            var separator = new Char[] { Entity_WHITE_SPACE, Entity_UNDER_SCORE };

            var split = format.Split(separator, StringSplitOptions.None);

            var Entity_DASH = Convert.ToChar(45);

            var join = String.Join(Entity_DASH.ToString(), split);

            var result = join;

            stringResult = result;

            return stringResult;
        }
    }
}
