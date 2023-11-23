using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void ResetLineNumber()
        {
            MeasureFile.LineNumber = 1;

            return;
        }
    }
}
