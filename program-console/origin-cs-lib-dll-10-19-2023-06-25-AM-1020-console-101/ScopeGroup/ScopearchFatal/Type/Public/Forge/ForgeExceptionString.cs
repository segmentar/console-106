using Core;

namespace Core
{
    using System;

    public partial class ScopearchFatal
    {
        public static String ForgeExceptionString(ScopearchFatal ScopeFatal__VALUE)
        {
            String stringResult = default;

            var result = String.Empty;

            Boolean isDefaultCheck, isNotDefaultCheck;

            isDefaultCheck = (ScopeFatal__VALUE == default) is true;

            isNotDefaultCheck = isDefaultCheck is false;

            if (isNotDefaultCheck is true)
            {
                result = result + ScopeFatal__VALUE.Exception.ToString();
            }
            else
                "false".ToString();

            stringResult = result;

            return stringResult;
        }
    }
}
