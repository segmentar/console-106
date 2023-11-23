using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public static void CallHandler(String[] array__END_POINT)
        {
            var boolean_safe__EQUAL_OR_MORE_THAN = (array__END_POINT.Length >= 2);

            Boolean hasLengthCheck, shouldReturnCheck;

            hasLengthCheck = boolean_safe__EQUAL_OR_MORE_THAN is true;

            shouldReturnCheck = hasLengthCheck is false;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            var first = array__END_POINT[0];

            var second = array__END_POINT[1];

            String call, file;

            call = first;

            file = second;

            CallHandlerOneFirst(array__END_POINT, call, file);

            return;
        }
    }
}
