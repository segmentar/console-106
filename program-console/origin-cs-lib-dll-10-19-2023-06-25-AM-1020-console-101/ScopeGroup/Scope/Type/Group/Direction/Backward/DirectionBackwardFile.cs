using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void DirectionBackwardFile()
        {
            var CurrentInitial__VALUE = TransactionCurrent();

            var previous = CurrentInitial__VALUE.Previous;

            while (true)
            {
                Boolean isDefaultCheck, shouldBreakCheck;

                isDefaultCheck = (previous == default) is true;

                shouldBreakCheck = isDefaultCheck is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                Boolean isEqualCheck, isNotEqualCheck;

                isEqualCheck = previous.Value.Filename.Equals(CurrentInitial__VALUE.Value.Filename) is true;

                isNotEqualCheck = isEqualCheck is false;

                if (isNotEqualCheck is true)
                {
                    while (true)
                    {
                        DirectionBackward();

                        var CurrentSubsequent__VALUE = TransactionCurrent();

                        Boolean isReferenceCheck;

                        isReferenceCheck = ReferenceEquals(CurrentSubsequent__VALUE, previous) is true;

                        if (isReferenceCheck is true)
                        {
                            break;
                        }
                        else
                            "false".ToString();

                        continue;
                    }

                    break;
                }
                else
                    "false".ToString();

                previous = previous.Previous;

                continue;
            }

            return;
        }
    }
}
