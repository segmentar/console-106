using Core;

namespace Core
{
    using System;

    public partial struct MaterialqueryRuntime
    {
        public void AnyRuntimeBoth(Boolean answer_LENGTH_has)
        {
            var boolean_safe_EQUAL_is = true;

            boolean_safe_EQUAL_is = boolean_safe_EQUAL_is && IsParenthesis is true;

            boolean_safe_EQUAL_is = boolean_safe_EQUAL_is && HasSquare is true;

            if (boolean_safe_EQUAL_is)
            {
                BothAny = true;
            }
            else
            {
                return;
            }
        }
    }
}
