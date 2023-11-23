using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial struct Materialinflect
    {
        public static ArrayList MaterialinflectPeriodDictionaryFilterContainer(Tuple<Int32, String>[] PeriodDictionary__ARRAY, Int32 Filter_INTEGER)
        {
            ArrayList listResult = default;

            listResult = new ArrayList();
            
            foreach (Tuple<Int32, String> PeriodDictionary_VALUE in PeriodDictionary__ARRAY)
            {
                var Key_VALUE = PeriodDictionary_VALUE.Item1;

                Boolean shouldContinueCheck;

                shouldContinueCheck = Key_VALUE.Equals(Filter_INTEGER) is false;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                listResult.Add(PeriodDictionary_VALUE);

                continue;
            }

            return listResult;
        }
    }
}
