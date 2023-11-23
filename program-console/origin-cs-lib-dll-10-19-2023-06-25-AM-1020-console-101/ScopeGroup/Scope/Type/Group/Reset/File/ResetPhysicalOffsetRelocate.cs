using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void ResetPhysicalOffsetRelocate()
        {
            MeasureInstruction.PhysicalOffsetRelocate = -1;

            return;
        }
    }
}
