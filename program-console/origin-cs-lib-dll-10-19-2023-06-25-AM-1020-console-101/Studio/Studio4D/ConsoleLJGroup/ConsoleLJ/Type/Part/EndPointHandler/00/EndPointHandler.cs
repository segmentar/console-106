using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public static Tuple<String, String>[] EndPointHandler(String item_TEXT, Tuple<String, Object>[] array__NAME_VALUE)
        {
            Tuple<String, String>[] arrayResult = default;

            var tuple = ForgeFlatTuple(item_TEXT);

            arrayResult = EndPointHandlerOneFirst(item_TEXT, array__NAME_VALUE, tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4);

            return arrayResult;
        }
    }
}
