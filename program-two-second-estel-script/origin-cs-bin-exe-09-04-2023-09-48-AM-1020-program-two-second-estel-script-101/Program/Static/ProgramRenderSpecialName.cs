using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static String RenderSpecialName(String item_NAME)
        {
            String stringResult = default;

            var underscore = Convert.ToChar(95);

            var dash = Convert.ToChar(45);

            var replace = item_NAME.Replace(underscore.ToString(), dash.ToString());

            var result = replace;

            stringResult = result;

            return stringResult;
        }
    }
}
