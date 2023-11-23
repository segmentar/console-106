using Core;

using Core.DimensionTwoSecond;

namespace Core
{
    using System;

    using System.Collections;

    internal partial class Program
    {
        internal static ArrayList ProgramInputNameValueContainer__NAME_VALUE(String[] array_SPLIT)
        {
            ArrayList listResult = default;

            var list = new ArrayList();

            foreach (var item_STRING in array_SPLIT)
            {
                var split = item_STRING.Split(new String[] { ArchitectureOneFirst.NativeString }, StringSplitOptions.None);

                Boolean shouldContniueContagious;

                shouldContniueContagious = split.Length.Equals(2) is false;

                if (shouldContniueContagious is true)
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

                String formatName, formatValue;

                formatName = name.Trim();

                formatValue = value.Trim();

                Boolean isNameEmptyCheck;

                isNameEmptyCheck = formatName.Equals(String.Empty) is true;

                shouldContniueContagious = isNameEmptyCheck is true;

                if (shouldContniueContagious is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                Tuple<String, String> tuple;

                tuple = new Tuple<String, String>(formatName, formatValue);

                list.Add(tuple);

                continue;
            }

            listResult = list;

            return listResult;
        }
    }
}
