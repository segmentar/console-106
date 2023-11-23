using Core;

namespace Core
{
    using System;

    internal partial class Material
    {
        internal static String SolidRepresentObject(String Name_ITEM, Object Value_ITEM)
        {
            String stringResult = default;

            var descriptor = String.Empty;

            descriptor = descriptor + Name_ITEM + ':';

            descriptor = descriptor + '\n';

            descriptor = descriptor + Value_ITEM;

            var result = descriptor;

            stringResult = result;

            return stringResult;
        }
    }
}
