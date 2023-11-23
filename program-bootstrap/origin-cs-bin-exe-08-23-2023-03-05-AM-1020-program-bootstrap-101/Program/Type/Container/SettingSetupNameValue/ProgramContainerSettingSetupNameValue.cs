using Core;

using Core.DimensionTwoSecond;

namespace Core
{
    using System;

    using System.Collections;

    internal partial class Program
    {
        internal static ArrayList ProgramSettingSetupContainer__NAME_VALUE(String item_TEXT)
        {
            ArrayList listResult = default;

            var boolean_contagious__EQUAL_OR_MORE_THAN = (item_TEXT.Length >= 2);

            Boolean hasNativeCheck;

            hasNativeCheck = boolean_contagious__EQUAL_OR_MORE_THAN is true;

            String nativeString;

            if (hasNativeCheck)
            {
                var first = item_TEXT[0];

                var second = item_TEXT[1];

                Char left, right;

                left = first;

                right = second;

                Char[] characterArray;

                characterArray = new Char[] { left, right };

                String stringEntry;

                stringEntry = new String(characterArray);

                nativeString = stringEntry;
            }
            else
            {
                nativeString = ArchitectureOneFirst.NativeString;
            }

            var list = new ArrayList();

            var line_feed = Convert.ToChar(10);

            var split__TEXT = item_TEXT.Split(new String[] { line_feed.ToString() }, StringSplitOptions.None);

            foreach (var item_LINE in split__TEXT)
            {
                var split__LINE = item_LINE.Split(new String[] { nativeString }, StringSplitOptions.None);

                Boolean shouldContniueContagious;

                shouldContniueContagious = split__LINE.Length.Equals(2) is false;

                if (shouldContniueContagious is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                var first = split__LINE[0];

                var second = split__LINE[1];

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
