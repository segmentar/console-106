using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class ConsoleLJ
    {
        public static Tuple<String, String>[] EndPointHandlerFourFourth(String[] array_SPLIT, String item_LOWER, Int32 item__SPLIT_LENGTH, Boolean answer_LENGTH_has, Tuple<String, Object>[] array__NAME_VALUE, String[] array_PORTAL, String[] array_TERMINATOR, String[] array_JOIN)
        {
            Tuple<String, String>[] arrayResult = default;

            var array = ConsoleLJEndPointNameValueContainerSurface__NAME_VALUE<Tuple<String, String>>(array_JOIN);

            foreach (Tuple<String, String> tuple in array)
            {
                String name, value;

                name = tuple.Item1;

                value = tuple.Item2;

                ConsoleLJNameValueVoid(name, value);

                continue;
            }

            var list = new ArrayList(array_JOIN);

            Boolean isEchoCheck;

            isEchoCheck = list.Contains("echo") is true;

            if (isEchoCheck is true)
            {
                SpecializeConsoleLJ.GetConsoleLJInstance().Echo(array_JOIN);
            }
            else
                "false".ToString();

            arrayResult = array;

            return arrayResult;
        }
    }
}
