using Core;

namespace Core
{
    using System;

    public partial struct MaterialqueryRuntime
    {
        public void ParagraphRuntimeBoth(Boolean answer_LENGTH_has)
        {
            var boolean_safe_EQUAL_is = true;

            boolean_safe_EQUAL_is = boolean_safe_EQUAL_is && IsCurly is true;

            boolean_safe_EQUAL_is = boolean_safe_EQUAL_is && HasCurly is true;

            if (boolean_safe_EQUAL_is)
            {
                BothParagraph = true;
            }
            else
            {
                return;
            }
        }
    }
}
