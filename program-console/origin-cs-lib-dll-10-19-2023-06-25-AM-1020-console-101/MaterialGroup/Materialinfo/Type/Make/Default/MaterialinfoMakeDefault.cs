using Core;

namespace Core
{
    using System;

    public partial class Materialinfo
    {
        public static Materialinfo MakeMaterialinfoDefault(MaterialStringSafe HeaderSubstring__VALUE, MaterialStringSafe FooterSubstring__VALUE, MaterialCharacterArraySafe EscapeCharacter__ARRAY, Boolean answer_DEBUG_is)
        {
            Materialinfo materialinfoResult = default;

            var result = new MaterialinfoSequence(HeaderSubstring__VALUE, FooterSubstring__VALUE, EscapeCharacter__ARRAY, answer_DEBUG_is).Result;

            MaterialinfoPolicy.MaterialinfoArrayList.Add(result);

            materialinfoResult = result;

            return materialinfoResult;
        }
    }
}
