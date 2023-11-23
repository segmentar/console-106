using Core;

namespace Core
{
    using System;

    internal partial class Material
    {
        internal static String SolidString(String String_VALUE)
        {
            String stringResult = default;

            var Item_CHARACTER_ARRAY = String_VALUE.ToCharArray();

            var Entry_CHARACTER_ARRAY = SolidCharacterArray(Item_CHARACTER_ARRAY);

            var result = new String(Entry_CHARACTER_ARRAY);

            stringResult = result;

            return stringResult;
        }
    }
}
