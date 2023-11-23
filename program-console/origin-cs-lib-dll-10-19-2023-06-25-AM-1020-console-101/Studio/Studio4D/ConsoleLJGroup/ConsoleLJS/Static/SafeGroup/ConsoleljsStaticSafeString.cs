using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJS
    {
        public static String SafeString(String item_STRING)
        {
            String stringResult = default;

            var array = SafeCharacterArray(item_STRING.ToCharArray());

            String stringItemEntry;

            stringItemEntry = new String(array);

            stringResult = stringItemEntry;

            return stringResult;
        }
    }
}
