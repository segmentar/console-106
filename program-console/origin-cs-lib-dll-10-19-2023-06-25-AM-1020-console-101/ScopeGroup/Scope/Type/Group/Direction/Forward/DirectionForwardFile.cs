using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void DirectionForwardFile()
        {
            var CurrentInitial__VALUE = TransactionCurrent();

            var next = CurrentInitial__VALUE.Next;

            while (true)
            {
                Boolean isDefaultCheck, shouldBreakCheck;
                
                isDefaultCheck = (next == default) is true;

                shouldBreakCheck = isDefaultCheck is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                Boolean isEqualCheck, isNotEqualCheck;

                isEqualCheck = next.Value.Filename.Equals(CurrentInitial__VALUE.Value.Filename) is true;

                isNotEqualCheck = isEqualCheck is false;

                if (isNotEqualCheck is true)
                {
                    while (true)
                    {
                        DirectionForward();

                        var CurrentSubsequent__VALUE = TransactionCurrent();

                        Boolean isReferenceCheck;

                        isReferenceCheck = ReferenceEquals(CurrentSubsequent__VALUE, next) is true;

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

                next = next.Next;

                continue;
            }

            return;
        }
    }
}
