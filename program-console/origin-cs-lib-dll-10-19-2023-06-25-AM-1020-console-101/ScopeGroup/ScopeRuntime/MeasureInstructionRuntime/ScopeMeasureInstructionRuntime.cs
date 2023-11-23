using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void MeasureInstructionRuntime()
        {
            MeasureInstruction.FilePointerRelocate = -1;

            MeasureInstruction.PhysicalOffsetRelocate = -1;

            return;
        }
    }
}