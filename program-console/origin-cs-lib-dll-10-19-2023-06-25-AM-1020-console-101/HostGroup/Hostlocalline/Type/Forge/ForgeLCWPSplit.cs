using Core;

namespace Core
{
    using System;

    public partial class Hostlocalline
    {
        public static String[] ForgeLCWPSplit(String String_VALUE, StringSplitOptions StringSplitOptions___VALUE)
        {
            String[] arrayResult = default;

            var Entity_LINE_FEED = Convert.ToChar(10);

            var Entity_CARRIAGE_RETURN = Convert.ToChar(13);

            var Entity_WHITE_SPACE = Convert.ToChar(32);

            var Entity_PERIOD = Convert.ToChar(46);

            var separator = new Char[4] { Entity_LINE_FEED, Entity_CARRIAGE_RETURN, Entity_WHITE_SPACE, Entity_PERIOD };

            var split = String_VALUE.Split(separator, StringSplitOptions___VALUE);

            var array = split;

            arrayResult = array;

            return arrayResult;
        }
    }
}
