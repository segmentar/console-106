using Core;

namespace Core
{
    using System;

    public partial struct MaterialqueryRuntime
    {
        public void SentenceRuntimeBoth(Boolean answer_LENGTH_has)
        {
            var boolean_safe_EQUAL_is = true;

            boolean_safe_EQUAL_is = boolean_safe_EQUAL_is && IsCurly is true;

            boolean_safe_EQUAL_is = boolean_safe_EQUAL_is && answer_LENGTH_has is false;

            if (boolean_safe_EQUAL_is)
            {
                BothSentence = true;
            }
            else
            {
                return;
            }
        }
    }
}
