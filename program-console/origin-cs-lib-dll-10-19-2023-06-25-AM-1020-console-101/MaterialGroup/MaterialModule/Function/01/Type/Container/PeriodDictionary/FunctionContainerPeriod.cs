using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial struct MaterialModule
    {
        public static ArrayList FunctionPeriodContainer(String HeaderString__VALUE)
        {
            ArrayList listResult = default;

            listResult = new ArrayList();

            var Entity_PERIOD = Convert.ToChar(46);

            Char[] characterArray;

            characterArray = HeaderString__VALUE.ToCharArray();

            var separator = new String[] { Entity_PERIOD.ToString() };

            var split = HeaderString__VALUE.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            int x, y, z;

            x = -1;

            y = 0;

            z = 0;

            for (; ; )
            {
                x = x + 1;

                var boolean_safe_BREAK_should = false;

                boolean_safe_BREAK_should = boolean_safe_BREAK_should || split.Length.Equals(y) is true;

                boolean_safe_BREAK_should = boolean_safe_BREAK_should || characterArray.Length.Equals(x) is true;

                Boolean shouldBreakCheck;

                shouldBreakCheck = boolean_safe_BREAK_should is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                Char character;

                character = characterArray[x];

                Boolean isPeriodContagentCheck, isNotPedirodAndEqual;

                isPeriodContagentCheck = character.Equals(Entity_PERIOD) is true;

                isNotPedirodAndEqual = (isPeriodContagentCheck is false) && (z.Equals(0) is true);

                if (isNotPedirodAndEqual is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                if (isPeriodContagentCheck)
                {
                    z = z + 1;

                    goto bypass;
                }
                else
                {
                    String stringItem;

                    stringItem = split[y];

                    var entity_WHITE_SPACE = Convert.ToChar(32);

                    var format = stringItem.Trim(entity_WHITE_SPACE);

                    var reflect_item_entry__COUNT = z;

                    var reflect_item_entry__ARGUMENT = format;

                    Tuple<Int32, String> tuple;

                    tuple = new Tuple<Int32, String>(reflect_item_entry__COUNT, reflect_item_entry__ARGUMENT);

                    z = 0;

                    listResult.Add(tuple);

                    y = y + 1;

                    goto bypass;
                }

                bypass:
                {
                    continue;
                }
            }

            return listResult;
        }
    }
}
