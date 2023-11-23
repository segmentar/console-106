using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void EndOfFileArrayCheck()
        {
            Boolean shouldReturnCheck;

            shouldReturnCheck = MeasureFileArray.FileArray.Length.Equals(MeasureFileArray.FilePointer) is false;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            MeasureFlag.EndOfFileArrayFlag = true;

            return;
        }
    }
}
