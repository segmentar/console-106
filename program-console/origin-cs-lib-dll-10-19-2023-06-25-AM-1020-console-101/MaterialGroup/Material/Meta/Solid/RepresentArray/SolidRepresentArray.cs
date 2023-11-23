using Core;

namespace Core
{
    using System;

    using System.Collections;

    internal partial class Material
    {
        internal static String SolidRepresentArray(String Name_ITEM, Object Value_ITEM)
        {
            String stringResult = default;

            var array = (Array)(Value_ITEM as Object);

            var list = new ArrayList(array);

            var descriptor = String.Empty;

            descriptor = descriptor + Name_ITEM + ':' + ' ' + ". . ." + ' ' + $"<{list.Count}>" + ':';

            descriptor = descriptor + '\n';

            descriptor = descriptor + String.Join('\n'.ToString(), list.ToArray());

            var result = descriptor;

            stringResult = result;

            return stringResult;
        }
    }
}
