using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public static Tuple<String, String>[] EndPointHandlerThreeThird(String[] array_SPLIT, String item_LOWER, Int32 item__SPLIT_LENGTH, Boolean answer_LENGTH_has, Tuple<String, Object>[] array__NAME_VALUE, String[] array_PORTAL, String[] array_TERMINATOR)
        {
            Tuple<String, String>[] arrayResult = default;

            var array = ConsoleLJJoinDispenserSurface(array_TERMINATOR);

            arrayResult = EndPointHandlerFourFourth(array_SPLIT, item_LOWER, item__SPLIT_LENGTH,  answer_LENGTH_has, array__NAME_VALUE, array_PORTAL, array_TERMINATOR, array);

            return arrayResult;
        }
    }
}
