using Core;

namespace Core
{
    using System;

    internal partial class Material
    {
        internal static String SolidRenderFileName(String[] Split_ARRAY, Int32 Ordinal_VALUE)
        {
            String stringResult = default;

            var aoth = Split_ARRAY.Length;

            var roth = (aoth - 1);

            var eoth = Split_ARRAY[roth];

            var format = String.Format("{0} {1}", eoth, Ordinal_VALUE);

            var path_NAME_file = format; 

            var result = path_NAME_file;

            stringResult = result;

            return stringResult;
        }
    }
}
