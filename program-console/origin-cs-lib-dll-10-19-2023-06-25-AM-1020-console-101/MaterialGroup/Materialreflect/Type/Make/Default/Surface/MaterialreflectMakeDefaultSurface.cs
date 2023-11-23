using Core;

namespace Core
{
    using System;

    internal partial class Materialreflect
    {
        internal static Materialreflect MakeMaterialreflectDefaultSurface(Material Material_VALUE, MaterialStringFormat StringFormat__VALUE, Char[] EscapeCharacter__ARRAY)
        {
            Materialreflect materialreflectResult = default;

            materialreflectResult = MakeMaterialreflectDefault(Material_VALUE, StringFormat__VALUE, EscapeCharacter__ARRAY, MaterialreflectPolicy.MaterialreflectDebugPolicy);

            return materialreflectResult;
        }
    }
}
