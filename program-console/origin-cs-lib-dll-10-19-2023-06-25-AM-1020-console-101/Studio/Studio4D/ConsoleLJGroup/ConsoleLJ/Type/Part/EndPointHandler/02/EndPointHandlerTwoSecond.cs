using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public static Tuple<String, String>[] EndPointHandlerTwoSecond(String item_TEXT, Tuple<String, Object>[] array__NAME_VALUE, String[] array_SPLIT, String item_LOWER, Int32 item__SPLIT_LENGTH, Boolean answer_LENGTH_has, String[] array_PORTAL)
        {
            Tuple<String, String>[] arrayResult = default; ;

            var array = ConsoleLJTerminatorDispenserSurface(array_PORTAL);

            arrayResult = EndPointHandlerThreeThird(array_SPLIT, item_LOWER, item__SPLIT_LENGTH, answer_LENGTH_has, array__NAME_VALUE, array_PORTAL, array);

            return arrayResult;
        }
    }
}
