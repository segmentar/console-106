using Core;

namespace Core
{
    using System;

    using System.Collections;

    internal partial class Program
    {
        internal static ArrayList ProgramSplitNameValueContainer(String[] array_SPLIT)
        {
            ArrayList arrayList = default;

            var list = new ArrayList();

            foreach (var item_STRING in array_SPLIT)
            {
                var split = item_STRING.Split(new String[] { ArchitecturePageOneFirst.NativeString }, StringSplitOptions.None);

                var boolean_safe__EQUAL_THAN = (split.Length == 2);

                Boolean shouldContinue;

                shouldContinue = boolean_safe__EQUAL_THAN is false;

                if (shouldContinue is true)
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

            arrayList = list;

            return arrayList;
        }
    }
}
