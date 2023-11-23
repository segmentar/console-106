using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        public static void CallHandler(String[] array_SPLIT, String item_LOWER, Int32 item_LENGTH, Boolean answer_LENGTH_has)
        {
            var boolean_safe_RETURN_should = false;

            boolean_safe_RETURN_should = boolean_safe_RETURN_should || answer_LENGTH_has is false;

            boolean_safe_RETURN_should = boolean_safe_RETURN_should || (item_LENGTH >= 2) is false;

            Boolean shouldReturnCheck;

            shouldReturnCheck = boolean_safe_RETURN_should is true;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            var first = array_SPLIT[0];

            var second = array_SPLIT[1];

            String call, escape;

            call = first;

            escape = second;

            CallHandlerOneFirst(array_SPLIT, item_LOWER, item_LENGTH, answer_LENGTH_has, call, escape);

            return;
        }
    }
}
