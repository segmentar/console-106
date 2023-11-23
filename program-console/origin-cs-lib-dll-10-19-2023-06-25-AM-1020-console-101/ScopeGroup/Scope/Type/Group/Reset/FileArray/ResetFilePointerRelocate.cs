using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void ResetFilePointerRelocate()
        {
            MeasureInstruction.FilePointerRelocate = -1;

            return;
        }
    }
}
