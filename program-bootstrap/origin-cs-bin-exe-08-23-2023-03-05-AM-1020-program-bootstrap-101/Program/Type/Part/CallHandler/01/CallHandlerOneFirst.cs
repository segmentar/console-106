using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        public static void CallHandlerOneFirst(String[] array_SPLIT, String item_LOWER, Int32 item_LENGTH, Boolean answer_LENGTH_has, String item_CALL, String item_ESCAPE)
        {
            var lower = item_CALL.ToLower();

            Boolean shouldReturnCheck;

            shouldReturnCheck = lower.Equals("call") is false;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            var length = (array_SPLIT.Length - 2);

            String[] stringArray;

            stringArray = new String[length];

            Array.Copy(array_SPLIT, 2, stringArray, 0, length);

            var oth = item_ESCAPE[0];

            CallHandlerTwoSecond(array_SPLIT, item_LOWER, item_LENGTH, answer_LENGTH_has, item_CALL, item_ESCAPE, oth, stringArray);

            return;
        }
    }
}
