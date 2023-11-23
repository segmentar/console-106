using Core;

namespace Core
{
    using System;

    using System.Collections;

    internal partial class Program
    {
        internal static ArrayList ProgramClassificationContainer(String[] array_SPLIT)
        {
            ArrayList listResult = default;

            var list = new ArrayList();

            var indexer = 0;

            do
            {
                var roth = (indexer - 1);

                var align = (roth + 4);

                var boolean_safe__EQUAL_OR_MORE_THAN = (align >= array_SPLIT.Length);

                Boolean shouldBreakCheck;

                shouldBreakCheck = boolean_safe__EQUAL_OR_MORE_THAN is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                Int32 one, two, three, four;

                one = (indexer + 0);

                two = (indexer + 1);

                three = (indexer + 2);

                four = (indexer + 3);

                var first = array_SPLIT[one];

                var second = array_SPLIT[two];

                var third = array_SPLIT[three];

                var fourth = array_SPLIT[four];

                var split_FIRST = first.Split();

                var split_LAST = fourth.Split();

                String firstLast, lastFirst;

                firstLast = split_FIRST[split_FIRST.Length - 1];

                lastFirst = split_LAST[0];

                var lower = firstLast.ToLower();

                Boolean isClassCheck;

                isClassCheck = lower.Equals("class") is true;

                if (isClassCheck is true)
                {
                    Tuple<String, String, String, String> tuple;

                    tuple = new Tuple<String, String, String, String>(firstLast, second, third, lastFirst);

                    list.Add(tuple);
                }
                else
                    "false".ToString();

                indexer = indexer + 1;

                continue;

            } while (true);

            listResult = list;

            return listResult;
        }
    }
}
