using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Scope
    {
        public static String SolidDictionaryPair(IDictionary Dictionary_VALUE, Int32 Count_VALUE)
        {
            String stringResult = default;

            var result = String.Empty;

            var list = new ArrayList(Dictionary_VALUE);

            var indexer = 0;

            foreach (var value in list)
            {
                Boolean shouldBreakCheck;

                shouldBreakCheck = Count_VALUE.Equals(indexer) is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                result = result + value;

                result = result + '\n';

                continue;
            }

            stringResult = result;

            return stringResult;
        }
    }
}
