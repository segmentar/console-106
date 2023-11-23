using Core;

namespace Core
{
    using System;

    public partial class Materialinfo
    {
        public static Materialinfo MakeMaterialinfoDefaultSurface(MaterialStringSafe HeaderSubstring__VALUE, MaterialStringSafe FooterSubstring__VALUE, MaterialCharacterArraySafe EscapeCharacter__ARRAY)
        {
            Materialinfo materialinfoResult = default;

            materialinfoResult = MakeMaterialinfoDefault(HeaderSubstring__VALUE, FooterSubstring__VALUE, EscapeCharacter__ARRAY, MaterialinfoPolicy.MaterialinfoDebugPolicy);

            return materialinfoResult;
        }
    }
}
