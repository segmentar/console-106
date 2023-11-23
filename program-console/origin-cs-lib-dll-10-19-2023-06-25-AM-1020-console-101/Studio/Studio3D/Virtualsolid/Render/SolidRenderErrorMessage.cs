using Core;

namespace Core
{
    using System;

    public partial class Virtualsolid
    {
        public static String SolidRenderErrorMessage()
        {
            String stringResult = default;

            var descriptor = String.Empty;
            
            descriptor = descriptor + $"This object with {nameof(Virtualsolid)} origin just so happned to be default" + ' ' + ":(";

            var result = descriptor;

            stringResult = result;

            return stringResult;
        }
    }
}
