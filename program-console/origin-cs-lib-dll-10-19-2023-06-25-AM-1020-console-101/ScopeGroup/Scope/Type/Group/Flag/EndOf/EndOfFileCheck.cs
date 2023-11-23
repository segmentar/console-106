using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void EndOfFileCheck()
        {
            Boolean shouldReturnCheck;

            shouldReturnCheck = MeasureFileArray.Text.StringValue.Length.Equals(MeasureFile.PhysicalOffset) is false;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            MeasureFlag.EndOfFileFlag = true;

            return;
        }
    }
}
