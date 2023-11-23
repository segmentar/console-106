using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void GlobalLineCheck()
        {
            var Entity_COMMA = Convert.ToChar(44);

            var FormatInitial__ITEM = MeasureFile.Line.StringValue.TrimStart();

            var FormatSubsequent__ITEM = FormatInitial__ITEM.TrimStart(Entity_COMMA);

            var Aoth_LINE = FormatInitial__ITEM.Length;

            var Aoth_FORMAT = FormatSubsequent__ITEM.Length;

            var Aoth_DIFFERENCE = (Aoth_LINE - Aoth_FORMAT);

            Boolean isGlobalLineCheck, shouldReturnCheck;

            isGlobalLineCheck = Aoth_DIFFERENCE.Equals(1) is true;

            shouldReturnCheck = isGlobalLineCheck is false;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            MeasureFlag.GlobalLineFlag = true;

            return;
        }
    }
}
