using Core;

namespace Core
{
    using System;

    internal partial class Material
    {
        internal static Material MakeMaterialDefaultSurface(MaterialStringSplitcharacter HeaderSplitcharacter__VALUE, String BodySubstring__VALUE)
        {
            Material materialResult = default;

            materialResult = MakeMaterialDefault(HeaderSplitcharacter__VALUE, BodySubstring__VALUE, MaterialPolicy.MaterialDebugPolicy);

            return materialResult;
        }
    }
}
