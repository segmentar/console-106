using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void AdvancePhysicalOffset()
        {
            MeasureFile.PhysicalOffset = MeasureFile.PhysicalOffset + 1;

            return;
        }
    }
}
