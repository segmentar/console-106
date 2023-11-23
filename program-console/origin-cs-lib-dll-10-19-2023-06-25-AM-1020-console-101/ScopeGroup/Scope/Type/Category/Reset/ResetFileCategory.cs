using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void ResetFileCategory()
        {
            ResetPhysicalOffset();

            ResetVirtualOffset();

            ResetLineNumber();

            return;
        }
    }
}
