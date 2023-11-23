using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void ResetFilePointer()
        {
            MeasureFileArray.FilePointer = 0;

            return;
        }
    }
}
