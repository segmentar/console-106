using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void LocalLineCheck()
        {
            var Entity_PERIOD = Convert.ToChar(46);

            var FormatRight__ITEM = MeasureFile.Line.StringValue.TrimEnd();

            var FormatRight__ENTRY = FormatRight__ITEM.TrimEnd(Entity_PERIOD);

            var difference = (FormatRight__ITEM.Length - FormatRight__ENTRY.Length);

            Boolean isEqualCheck, shouldReturnCheck;

            isEqualCheck = (difference > 0) is true;

            shouldReturnCheck = isEqualCheck is false;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            MeasureFlag.LocalLineFlag = true;

            var OperationUppercase__ENTITY = "OPERATION";

            var OperationLowercase__ENTITY = "operation";

            var FormatLeft__VALUE = MeasureFile.Line.StringValue.TrimStart();

            var boolean_match_COUNT_is = false;

            boolean_match_COUNT_is = boolean_match_COUNT_is || FormatLeft__VALUE.StartsWith(OperationUppercase__ENTITY) is true;

            boolean_match_COUNT_is = boolean_match_COUNT_is || FormatLeft__VALUE.StartsWith(OperationLowercase__ENTITY) is true;

            if (boolean_match_COUNT_is is true)
            {
                MeasureValue.LocalLineMultilineCount = difference;
            }
            else
                "false".ToString();

            return;
        }
    }
}
