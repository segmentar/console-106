using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void ResetPhysicalOffset()
        {
            MeasureFile.PhysicalOffset = 0;

            return;
        }
    }
}
