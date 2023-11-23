using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void AdvanceFilePointer()
        {
            MeasureFileArray.FilePointer = MeasureFileArray.FilePointer + 1;

            return;
        }
    }
}
