using Core;

namespace Core
{
    using System;

    internal partial class Material
    {
        internal static Material MakeMaterialDefault(MaterialStringSplitcharacter HeaderSplitcharacter__VALUE, String BodySubstring__VALUE, Boolean answer_DEBUG_is)
        {
            Material materialResult = default;

            var result = new MaterialSequence(HeaderSplitcharacter__VALUE, BodySubstring__VALUE, answer_DEBUG_is).Result;

            MaterialPolicy.MaterialArrayList.Add(result);

            materialResult = result;

            return materialResult;
        }
    }
}
