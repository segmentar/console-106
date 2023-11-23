using Core;

using Core.DimensionTwoSecondSecondaryII.ConsoleLJ;

namespace Core
{
    using System;

    using System.Collections;

    public partial class ConsoleLJ
    {
        public static ArrayList ConsoleLJEndPointNameValueContainer__NAME_VALUE(String[] array__END_POINT)
        {
            ArrayList listResult = default;

            var list = new ArrayList();

            foreach (var item_STRING in array__END_POINT)
            {
                var split = item_STRING.Split(new String[] { ArchitectureConsoleLJOneFirst.NativeString }, StringSplitOptions.None);

                Boolean shouldContinueCheck;

                shouldContinueCheck = split.Length.Equals(2) is false;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                var first = split[0];

                var second = split[1];

                String name, value;

                name = first;

                value = second;

                Tuple<String, String> tuple;

                tuple = new Tuple<String, String>(name, value);

                list.Add(tuple);

                continue;
            }

            listResult = list;

            return listResult;
        }
    }
}
