using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static Boolean LineFeedCompoundPredicate(Char value_CHARACTER)
        {
            Boolean booleanResult = default;

            var Entity_LINE_FEED = Convert.ToChar(10);

            Boolean isLineFeedContagentCheck;

            isLineFeedContagentCheck = value_CHARACTER.Equals(Entity_LINE_FEED) is true;

            if (isLineFeedContagentCheck)
            {
                booleanResult = true;
            }
            else
            {
                booleanResult = false;
            }

            return booleanResult;
        }
    }
}
