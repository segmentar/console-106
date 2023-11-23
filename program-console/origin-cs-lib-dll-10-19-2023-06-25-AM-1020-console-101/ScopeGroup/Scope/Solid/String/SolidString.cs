using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static String SolidString(String String_ITEM)
        {
            String stringResult = default;

            var item_ARRAY = String_ITEM.ToCharArray();

            var entry_ARRAY = SolidCharacterArray(item_ARRAY);

            var result = new String(entry_ARRAY);

            stringResult = result;

            return stringResult;
        }
    }
}
