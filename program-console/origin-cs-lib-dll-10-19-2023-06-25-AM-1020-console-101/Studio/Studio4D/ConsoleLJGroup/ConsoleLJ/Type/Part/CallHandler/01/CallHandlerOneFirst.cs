using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public static void CallHandlerOneFirst(String[] array__END_POINT, String item_CALL, String item_FILE)
        {
            Int32 itemCount;

            itemCount = 2;

            var length = (array__END_POINT.Length - itemCount);

            var array = new String[length];

            Array.Copy(array__END_POINT, itemCount, array, 0, length);

            CallHandlerTwoSecond(array__END_POINT, item_CALL, item_FILE, array);

            return;
        }
    }
}
