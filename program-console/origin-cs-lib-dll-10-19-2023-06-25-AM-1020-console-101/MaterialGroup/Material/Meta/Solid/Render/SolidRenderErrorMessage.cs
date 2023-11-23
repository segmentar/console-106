using Core;

namespace Core
{
    using System;

    internal partial class Material
    {
        internal static String SolidRenderErrorMessage()
        {
            String stringResult = default;

            var descriptor = String.Empty;
            
            descriptor = descriptor + $"This object with {nameof(Material)} origin just so happned to be default" + ' ' + ":(";

            var result = descriptor;

            stringResult = result;

            return stringResult;
        }
    }
}
