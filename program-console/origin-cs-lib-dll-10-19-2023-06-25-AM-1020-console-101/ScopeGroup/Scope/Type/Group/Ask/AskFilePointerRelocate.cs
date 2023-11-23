using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void AskFilePointerRelocate()
        {
            Boolean isEqualCheck, shouldReturnCheck;

            isEqualCheck = MeasureInstruction.FilePointerRelocate.Equals(-1) is true;

            shouldReturnCheck = isEqualCheck is true;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            MeasureFileArray.FilePointer = MeasureInstruction.FilePointerRelocate;

            ResetFilePointerRelocate();

            return;
        }
    }
}
