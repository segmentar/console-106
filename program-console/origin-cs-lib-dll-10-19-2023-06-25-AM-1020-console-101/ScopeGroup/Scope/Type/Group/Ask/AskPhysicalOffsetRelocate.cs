using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void AskPhysicaloffsetRelocate()
        {
            Boolean isEqualCheck, shouldReturnCheck;

            isEqualCheck = MeasureInstruction.PhysicalOffsetRelocate.Equals(-1) is true;

            shouldReturnCheck = isEqualCheck is true;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            MeasureFile.PhysicalOffset = MeasureInstruction.PhysicalOffsetRelocate;

            ResetPhysicalOffsetRelocate();
            
            return;
        }
    }
}
