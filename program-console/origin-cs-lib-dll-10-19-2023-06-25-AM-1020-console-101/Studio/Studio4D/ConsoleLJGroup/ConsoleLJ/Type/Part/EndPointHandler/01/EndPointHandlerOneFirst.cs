using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public static Tuple<String, String>[] EndPointHandlerOneFirst(String item_TEXT, Tuple<String, Object>[] array__NAME_VALUE, String[] array_SPLIT, String item_LOWER, Int32 item__SPLIT_LENGTH, Boolean answer_LENGTH_has)
        {
            Tuple<String, String>[] arrayResult = default;

            var array = ConsoleLJPortalDispenserSurface(array_SPLIT, array__NAME_VALUE);

            arrayResult = EndPointHandlerTwoSecond(item_TEXT, array__NAME_VALUE, array_SPLIT, item_LOWER, item__SPLIT_LENGTH, answer_LENGTH_has, array);

            return arrayResult;
        }
    }
}
