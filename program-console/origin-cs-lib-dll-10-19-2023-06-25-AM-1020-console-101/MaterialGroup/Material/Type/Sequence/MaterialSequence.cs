using Core;

namespace Core
{
    using System;

    internal partial class MaterialSequence
    {
        internal Material Result { get; set; } = default;

        internal MaterialSequence(MaterialStringSplitcharacter HeaderSplitcharacter__VALUE, String BodySubstring__VALUE, Boolean answer_DEBUG_is)
        {
            Debug(HeaderSplitcharacter__VALUE, BodySubstring__VALUE, answer_DEBUG_is);

            var HeaderSubstringsafe__VALUE = MaterialStringSafe.Simple(HeaderSplitcharacter__VALUE.StringValueSplit);

            var BodySubstringsafe__VALUE = MaterialStringSafe.Simple(BodySubstring__VALUE);

            Material element;

            element = new Material(HeaderSubstringsafe__VALUE, BodySubstringsafe__VALUE, answer_DEBUG_is);

            this.Result = element;

            return;
        }

        ~MaterialSequence()
        {
            return;
        }
    }
}
