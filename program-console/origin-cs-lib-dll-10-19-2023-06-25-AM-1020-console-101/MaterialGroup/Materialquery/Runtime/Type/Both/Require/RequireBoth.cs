using Core;

namespace Core
{
    using System;

    public partial struct MaterialqueryRuntime
    {
        public void RequireRuntimeBoth(Boolean answer_LENGTH_has)
        {
            var boolean_safe_EQUAL_is = true;

            boolean_safe_EQUAL_is = boolean_safe_EQUAL_is && IsParenthesis is true;

            boolean_safe_EQUAL_is = boolean_safe_EQUAL_is && answer_LENGTH_has is false;

            if (boolean_safe_EQUAL_is)
            {
                BothRequire = true;
            }
            else
            {
                return;
            }
        }
    }
}
